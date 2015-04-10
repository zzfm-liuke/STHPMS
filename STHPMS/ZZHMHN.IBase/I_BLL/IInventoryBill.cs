using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.IBase.I_Entity;
using ZZHMHN.IBase.I_Entity.Ihpms;


namespace ZZHMHN.IBase.I_BLL
{
    /// <summary>
    /// 库存接口
    /// </summary>
    public interface IInventoryBill : IBll
    {
        /// <summary>
        /// 返回FrmMutipleParameterManager页面的Begin项
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="RoadNum">道路编号</param>
        /// /// <param name="rdSelectedIndex">FrmMutipleParameterManager页面单选按钮选项</param>
        /// <returns></returns>
        List<T> GetBegin<T>(int RoadNum, int rdSelectedIndex) where T : class ,IINVNTORY;
        /// <summary>
        /// 返回FrmMutipleParameterManager页面的Begin项
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="RoadNum">道路编号</param>
        /// <param name="beginDrowDownList">FrmMutipleParameterManager页面开始选项值</param>
        /// <returns></returns>
        List<T> GetEnd<T>(int RoadNum, string beginDrowDownList) where T : class ,IINVNTORY;
    }
}
