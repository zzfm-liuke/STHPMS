
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

        public IPmseltsBill GetPmseltsBill()
        {
            return new PmseltsBussiness();
        }


        public ISelectionBill GetSelectionBill()
        {
            return new SelectionBussiness();
        }


        public IRdLayBill GetRdLayBill()
        {
            return new RdLayBussiness();
        }


        public IMrpolicysetsBill GetMrpolicysetsBill()
        {
            return new MrpolicysetsBussiness();
        }


        public IDtparamBill GetDtparamBill()
        {
            return new DtparamBussiness();
        }


        public IRide_Model_CoefficientBill GetRide_Model_CoefficientBill()
        {
            return new Ride_Model_CoefficientBussiness();
        }

        public IPci_Model_CoefficientBill GetPci_Model_CoefficientBill()
        {
            return new Pci_Model_CoefficientBussiness();
        }


        public IFriction_Model_CoefficientsBill GetFriction_Model_CoefficientsBill()
        {
            return new Friction_Model_CoefficientsBussiness();
        }
    }
}
