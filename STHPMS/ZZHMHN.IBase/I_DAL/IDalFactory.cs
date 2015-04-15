using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.IBase.I_Core;

namespace ZZHMHN.IBase.I_DAL
{
    /// <summary>
    /// 数据层对象统一创建工厂类
    /// </summary>
    public interface IDalFactory : IObjectFactory
    {
        ITestDal GetTestDal();
        IRepository GetRepository(string connectionString, bool openConnection = true);
        IDatabaseManagerRepository GetDatabaseManagerRepository();
        INavigationDao GetNavigationDao();
        IBasisDao GetBasisDao();
        IRoadsDao GetRoadsDao();

        //CodeInfo表
        ICodeInfoRepository GetCodeInfoRepository();
        IRoadWayRepository GetRoadWayRepository();

        IInventoryRepository GetInventoryRepository();

        ISelectionRepository GetSelectionRepository();

        IPmseltsRepository GetPmseltsRepository();

        IRdLayRepository GetRdLayRepository();
    }
}
