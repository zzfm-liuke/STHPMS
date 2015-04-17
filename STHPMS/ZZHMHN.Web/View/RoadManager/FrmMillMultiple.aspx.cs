using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZZHMHN.IBase;
using ZZHMHN.Web.Entity.Ihpms;
//using ZZHMHN.Web.Entity.Select;
using Microsoft.VisualBasic;

namespace ZZHMHN.Web.View.RoadManager
{
    public partial class FrmMillMultiple : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //ViewState["Road_ID"] = Request.QueryString["Road_ID"];
                ViewState["Road_ID"] = "84";
                //道路编号，开始点和结束点
                ViewState["RoadCode"] = Request.QueryString["RoadCode"];
                ViewState["BeginPoint"] = Request.QueryString["BeginPoint"];
                ViewState["EndPotin"] = Request.QueryString["EndPotin"];
               
                Bind();
            }
        }

        void Bind()
        {
            List<RDLAY> SegDs = MyApp.Bll.RdLayBill.GetMaxLayNum<RDLAY>(ViewState["RoadCode"].ToString(), Session["segIDs"].ToString(), ViewState["BeginPoint"].ToString(), ViewState["EndPotin"].ToString());
            if (SegDs.Count > 0)
            {
                //组合segid和LAYERNUM
                string where = "";
                foreach (RDLAY r in SegDs)
                {
                    where += string.Format("(SEGID={0} and LAYERNUM={1}) or", r.SEGID, r.LAYERNUM);
                }
                //去掉最后or
                where = where.Substring(0, where.Length - 2);
                //根据条件查询RDLAY,包括SEGID,LAYERNUM,LAYERTHICK
                List<RDLAY> NewRdLay = MyApp.Bll.RdLayBill.GetRdLay<RDLAY>(where);

                //List<RDLAY> LayTb = MyApp.Bll.RdLayBill.Get<RDLAY>();//查询所有RdLay
                double MinThick = 9999;
                foreach (RDLAY segDs_RdLay in NewRdLay)
                {
                    //定位LayTb的某个RDLAY
                    //RDLAY rdLay_Seek = SeekRdLay(segDs_RdLay.SEGID, segDs_RdLay.LAYERNUM, LayTb);
                    //if (rdLay_Seek == null)
                    //{
                    //    ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('更新部分没有定义层');</script>");
                    //    txtInRemoved.Enabled = false;
                    //    btn_OK.Enabled = false;
                    //    return;
                    //}
                    //else if (Conversion.Val(rdLay_Seek.LAYERTHICK) <= 0)
                    //{
                    //    ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('更新部分有无效的顶层厚度');</script>");
                    //    txtInRemoved.Enabled = false;
                    //    btn_OK.Enabled = false;
                    //    return;
                    //}
                    //else if (rdLay_Seek.MTRLTYPE !="")
                    //{
                    //    if (Conversion.Val(rdLay_Seek.MTRLTYPE) < 100 || Conversion.Val(rdLay_Seek.MTRLTYPE) > 139)
                    //    {
                    //        ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('更新部分的顶层不是AC');</script>");
                    //        txtInRemoved.Enabled = false;
                    //        btn_OK.Enabled = false;
                    //        return;
                    //    }
                    //}
                    if (Conversion.Val(segDs_RdLay.LAYERTHICK) < MinThick)
                    {
                        MinThick = Conversion.Val(segDs_RdLay.LAYERTHICK);
                    }
                }
                lblMin.Text = MinThick.ToString();//保存最小值
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('更新部分没有定义层');</script>");
                txtInRemoved.Enabled = false;
                btn_OK.Enabled = false;
            }
        }

        //定位RDLAY
        RDLAY SeekRdLay(int segId, float LAYERNUM,List<RDLAY> temp)
        {
            foreach (RDLAY r in temp)
            {
                if (r.SEGID == segId && r.LAYERNUM == LAYERNUM)
                {
                    return r;
                }
            }
            return null;
        }

        protected void btn_OK_Click(object sender, EventArgs e)
        {
            if (Common.Rex.Regexlib.IsNumber(txtInRemoved.Text))
            {
                double MinThick = double.Parse(lblMin.Text);
                if (Conversion.Val(txtInRemoved.Text) > MinThick)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('输入值不能大于最小值');</script>");
                    txtInRemoved.Text = MinThick.ToString();
                }
                else
                {
                    List<RDLAY> SegDs = MyApp.Bll.RdLayBill.GetMaxLayNum<RDLAY>(ViewState["RoadCode"].ToString(), Session["segIDs"].ToString(), ViewState["BeginPoint"].ToString(), ViewState["EndPotin"].ToString());
                    if (SegDs.Count > 0)
                    {
                        //组合segid和LAYERNUM
                        string where = "";
                        foreach (RDLAY r in SegDs)
                        {
                            where += string.Format("(SEGID={0} and LAYERNUM={1}) or",r.SEGID,r.LAYERNUM);
                        }
                        //去掉最后or
                        where = where.Substring(0, where.Length - 2);
                        //根据条件查询RDLAY,包括SEGID,LAYERNUM,LAYERTHICK
                        List<RDLAY> NewRdLay = MyApp.Bll.RdLayBill.GetRdLay<RDLAY>(where);
                        foreach (RDLAY r in NewRdLay)
                        {
                            if (float.Parse(txtInRemoved.Text) >= r.LAYERTHICK)
                            {
                                //删除该行
                                MyApp.Bll.RdLayBill.Delete(r);
                            }
                            else
                            {
                                r.LAYERTHICK = r.LAYERTHICK - float.Parse(txtInRemoved.Text);
                                //修改该行
                                MyApp.Bll.RdLayBill.Update(r);
                            }
                        }
                    }
                    //执行成功
                    Response.Write("<script>alert('执行成功!');window.close();</script>");
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请输入有效数字');</script>");
            }
        }
    }
}