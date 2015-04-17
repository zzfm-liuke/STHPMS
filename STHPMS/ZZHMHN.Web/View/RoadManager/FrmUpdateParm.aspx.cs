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
    public partial class FrmUpdateParm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //ViewState["Road_ID"] = Request.QueryString["Road_ID"];
                ViewState["Road_ID"] = "84";
                BindParm(ViewState["Road_ID"].ToString());

                //道路编号，开始点和结束点
                ViewState["RoadCode"] = Request.QueryString["RoadCode"];
                ViewState["BeginPoint"] = Request.QueryString["BeginPoint"];
                ViewState["EndPotin"] = Request.QueryString["EndPotin"];
               
            }
        }

        void BindParm(string Road_ID)
        {
            using (ZZHMHN.IBase.I_Core.IScene sence = MyApp.Scene)
            {
                sence.Context = new ZZHMHN.Web.Core.InvokeContext("", Road_ID);
                List<PMSELTS> lst = sence.Bll.Pmselts.Get<PMSELTS>(new PMSELTS { UPDATE_MULT = -1 });
                ddl_Parm.DataSource = lst;
                ddl_Parm.DataTextField = "ENGL_NAME";
                ddl_Parm.DataValueField = "STND_NAME";
                ddl_Parm.DataBind();
                ddl_Parm.SelectedIndex = 0;

                ddl_Parm_SelectedIndexChanged(this, null);
            }
        }

        protected void ddl_Parm_SelectedIndexChanged(object sender, EventArgs e)
        {
            //找到ddl_parm值所在的Val_op1
            List<string> val_op1 = null;
            using (ZZHMHN.IBase.I_Core.IScene sence = MyApp.Scene)
            {
                sence.Context = new ZZHMHN.Web.Core.InvokeContext("", ViewState["Road_ID"].ToString());
                val_op1 = sence.Bll.Pmselts.GetVal_OP(ddl_Parm.SelectedValue.Trim());//STNDNAME
            }

            if (val_op1 != null && val_op1[0].Trim() == "T")
            {
                txtParamValue.Visible = false;
                //绑定ddl_ParmValue
                using (ZZHMHN.IBase.I_Core.IScene sence = MyApp.Scene)
                {
                    sence.Context = new ZZHMHN.Web.Core.InvokeContext("", ViewState["Road_ID"].ToString());
                    CODEINFO temp = new CODEINFO()
                    {
                        STNDNAME = ddl_Parm.SelectedValue.Trim()
                    };
                    List<CODEINFO> lstCode = sence.Bll.CodeInfo.Get<CODEINFO>(temp);
                    ddl_Value.DataSource = lstCode;
                    ddl_Value.DataTextField = "info";
                    ddl_Value.DataValueField = "code";
                    ddl_Value.DataBind();
                    ddl_Value.SelectedIndex = 0;
                    ddl_Value.Visible = true;
                }
            }
            else
            {
                txtParamValue.Visible = true;
                ddl_Value.Visible = false;
            }
        }

        protected void btn_OK_Click(object sender, EventArgs e)
        {
            //根据ddl_Parm.SelectedValue取出
            using (ZZHMHN.IBase.I_Core.IScene sence = MyApp.Scene)
            {
                sence.Context = new ZZHMHN.Web.Core.InvokeContext("", ViewState["Road_ID"].ToString());
                List<PMSELTS> lst = sence.Bll.Pmselts.Get<PMSELTS>(new PMSELTS { STND_NAME = ddl_Parm.SelectedValue });//查询单个PMSELTS
                PMSELTS temp = null;
                if (lst.Count > 0)
                {
                    temp = lst[0];
                    string tableName, fieldName, fieldValue=null;
                    string[] tableName_fieldName = temp.STND_NAME.Split('.');//得到用户库的segid
                    
                    if (tableName_fieldName.Length == 2)
                    {
                        tableName = tableName_fieldName[0].Trim();
                        fieldName = tableName_fieldName[1].Trim();
                        //根据判断更新
                        if (temp.VAL_OP1.Trim() == "T")
                        {
                            fieldValue = ddl_Value.SelectedValue;
                        }
                        else if (temp.TYPE.Trim() == "C")
                        {
                            if (txtParamValue.Text == "")
                            {
                                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请输入有效文字');</script>");
                                return;
                            }
                            fieldValue = txtParamValue.Text;
                        }
                        else if (temp.TYPE.Trim() == "D")
                        {
                            if (Common.Rex.Regexlib.IsDate(txtParamValue.Text))
                            {
                                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请输入有效日期');</script>");
                                return;
                            }

                            fieldValue = "#" + txtParamValue.Text + "#";
                        }
                        else if (temp.TYPE.Trim() == "N")
                        {
                            double UpdtVal = Conversion.Val(txtParamValue.Text);
                            
                            if (temp.VAL_OP1.Trim() == ">=")
                            {
                                if (temp.VAL_LOG_OP.Trim() == "A")
                                {
                                    if (temp.VAL_OP2.Trim() == "<=")
                                    {
                                        if (UpdtVal < Conversion.Val(temp.VAL_ARG1) || UpdtVal > Conversion.Val(temp.VAL_ARG2))
                                        {
                                            ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('该值必须大于等于" + temp.VAL_ARG1.Trim() + "且小于等于" + temp.VAL_ARG2.Trim() + "');</script>");
                                            return;
                                        }
                                    }
                                    else if (temp.VAL_OP2.Trim() == "<")
                                    {
                                        if (UpdtVal < Conversion.Val(temp.VAL_ARG1) || UpdtVal >= Conversion.Val(temp.VAL_ARG2))
                                        {
                                            ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('该值必须大于等于" + temp.VAL_ARG1.Trim() + "且小于" + temp.VAL_ARG2.Trim() + "');</script>");
                                            return;
                                        }
                                    }
                                }
                                else if (temp.VAL_LOG_OP.Trim() == "O")
                                {
                                    if (temp.VAL_OP2.Trim() == "<=")
                                    {
                                        if (!(UpdtVal >= Conversion.Val(temp.VAL_ARG1) || UpdtVal <= Conversion.Val(temp.VAL_ARG2)))
                                        {
                                            ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('该值必须大于等于" + temp.VAL_ARG1.Trim() + "或小于等于" + temp.VAL_ARG2.Trim() + "');</script>");
                                            return;
                                        }
                                    }
                                    else if (temp.VAL_OP2.Trim() == "<")
                                    {
                                        if (!(UpdtVal >= Conversion.Val(temp.VAL_ARG1) || UpdtVal < Conversion.Val(temp.VAL_ARG2)))
                                        {
                                            ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('该值必须大于等于" + temp.VAL_ARG1.Trim() + "或小于" + temp.VAL_ARG2.Trim() + "');</script>");
                                            return;
                                        }
                                    }
                                }
                                else
                                {
                                    if (UpdtVal < Conversion.Val(temp.VAL_ARG1))
                                    {
                                        ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('该值必须大于等于" + temp.VAL_ARG1.Trim() + "');</script>");
                                        return;
                                    }
                                }
                            }
                            else if (temp.VAL_OP1.Trim() == ">")
                            {
                                if (temp.VAL_LOG_OP.Trim() == "A")
                                {
                                    if (temp.VAL_OP2.Trim() == "<=")
                                    {
                                        if (UpdtVal <= Conversion.Val(temp.VAL_ARG1) || UpdtVal > Conversion.Val(temp.VAL_ARG2))
                                        {
                                            ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('该值必须大于" + temp.VAL_ARG1.Trim() + "且小于等于" + temp.VAL_ARG2.Trim() + "');</script>");
                                            return;
                                        }
                                    }
                                    else if (temp.VAL_OP2.Trim() == "<")
                                    {
                                        if (UpdtVal <= Conversion.Val(temp.VAL_ARG1) || UpdtVal >= Conversion.Val(temp.VAL_ARG2))
                                        {
                                            ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('该值必须大于" + temp.VAL_ARG1.Trim() + "且小于" + temp.VAL_ARG2.Trim() + "');</script>");
                                            return;
                                        }
                                    }
                                }
                                else if (temp.VAL_LOG_OP.Trim() == "O")
                                {
                                    if (temp.VAL_OP2.Trim() == "<=")
                                    {
                                        if (!(UpdtVal > Conversion.Val(temp.VAL_ARG1) || UpdtVal <= Conversion.Val(temp.VAL_ARG2)))
                                        {
                                            ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('该值必须大于" + temp.VAL_ARG1.Trim() + "或小于等于" + temp.VAL_ARG2.Trim() + "');</script>");
                                            return;
                                        }
                                    }
                                    else if (temp.VAL_OP2.Trim() == "<")
                                    {
                                        if (!(UpdtVal > Conversion.Val(temp.VAL_ARG1) || UpdtVal < Conversion.Val(temp.VAL_ARG2)))
                                        {
                                            ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('该值必须大于" + temp.VAL_ARG1.Trim() + "或小于" + temp.VAL_ARG2.Trim() + "');</script>");
                                            return;
                                        }
                                    }
                                }
                                else
                                {
                                    if (UpdtVal <= Conversion.Val(temp.VAL_ARG1))
                                    {
                                        ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('该值必须大于" + temp.VAL_ARG1.Trim() + "');</script>");
                                        return;
                                    }
                                }
                            }
                            fieldValue = UpdtVal.ToString();
                        }
                        //执行修改
                        MyApp.Bll.Pmselts.ExcuteSqlByIHPMS(tableName, fieldName, fieldValue, ViewState["RoadCode"].ToString(), Session["segIDs"].ToString(), ViewState["BeginPoint"].ToString(), ViewState["EndPotin"].ToString());
                        Response.Write( "<script>alert('修改成功!');window.close();</script>");
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('表或字段此参数的名称不完整,多段更新无法完成');</script>");
                    }
                }

            }
        }

        
    }
}