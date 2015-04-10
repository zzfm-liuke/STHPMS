
using ZZHMHN.BLL.Bussiness;
using ZZHMHN.IBase.Common;
using ZZHMHN.IBase.I_BLL;

namespace ZZHMHN.BLL.Core
{
    /// <summary>
    /// 业务层对象创建工厂
    /// </summary>
    public class BllFactory : SingleBase, IBllFactory
    {    
        #region Test
        public ITestBll GetTestBill()
        {
            return Get<TestBussiness>();
        }
        
        #endregion

        public INavigationBill GetNavigationBill()
        {
            return new NavigationBussiness();
        }

        public IDatabaseManagerBill GetRoadDatabaseBill()
        {
            return Get<DatabaseManagerBussiness>();
        }


        public ICodeInfoBll GetCodeBill()
        {
            return new CodeInfoBussiness();
        }


        public IRoadWayBill GetRoadWayBill()
        {
            return new RoadWayBussiness();
        }

        public IInventoryBill GetInventoryBill()
        {
            return new InventoryBussiness();
        }
    }
}
