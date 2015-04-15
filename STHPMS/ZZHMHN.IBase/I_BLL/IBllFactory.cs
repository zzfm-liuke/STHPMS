using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.IBase.I_Core;

namespace ZZHMHN.IBase.I_BLL
{
    /// <summary>
    /// 业务层统一创建工厂类
    /// </summary>
    public interface IBllFactory : IObjectFactory
    {
        ITestBll GetTestBill();
        INavigationBill GetNavigationBill();
        IDatabaseManagerBill GetRoadDatabaseBill();

        IRoadWayBill GetRoadWayBill();

        ICodeInfoBll GetCodeBill();

        IInventoryBill GetInventoryBill();

        IPmseltsBill GetPmseltsBill();

        ISelectionBill GetSelectionBill();

        IRdLayBill GetRdLayBill();
    }
}
