using ZZHMHN.IBase;
using ZZHMHN.IBase.Common;
using ZZHMHN.IBase.Definition;
using ZZHMHN.IBase.I_BLL;
using ZZHMHN.IBase.I_Core;

namespace ZZHMHN.BLL.Core
{
    /// <summary>
    /// 业务层接口统一调用处
    /// </summary>
    public class BllFacade : DisposeObject, IBllFacade
    {
        private IBllFactory _factory;
        public IBllFactory Factory
        {
            get
            {
                IBllFactory factory =null;
                if (Scene==null)
                    factory= MyApp.Locator.GetInstance<IBllFactory>(TypeStringDefinition.BLLFACTORY);
                else
                {
                    if (_factory==null)
                        _factory=MyApp.Locator.GetInstance<IBllFactory>();

                    factory = _factory;
                }
                    

                System.Diagnostics.Debug.Assert(factory != null, "IBllFactory is null");
                return factory;
            }
        }
        public IScene Scene { get; set; }

        public ITestBll Test
        {
            get { return  Ext.SetScence(Factory.GetTestBill(), this.Scene); }
        }       

        public INavigationBill Navigation
        {
            get { return Ext.SetScence(Factory.GetNavigationBill(),this.Scene); }
        }

        public IDatabaseManagerBill RoadDatabase
        {
            get { return Ext.SetScence(Factory.GetRoadDatabaseBill(), this.Scene); }
        }

        public ICodeInfoBll CodeInfo
        {
            get { return Ext.SetScence(Factory.GetCodeBill(), this.Scene); }
        }


        public IRoadWayBill RoadWay
        {
            get { return Ext.SetScence(Factory.GetRoadWayBill(), this.Scene); }
        }

        public IInventoryBill Inventory
        {
            get { return Ext.SetScence(Factory.GetInventoryBill(), this.Scene); }
        }

        public IPmseltsBill Pmselts
        {
            get { return Ext.SetScence(Factory.GetPmseltsBill(), this.Scene); }
        }

        protected override void OnDispose()
        {
            Factory.Dispose();
            _factory=null;
        }



        public ISelectionBill Selection
        {
            get { return Ext.SetScence(Factory.GetSelectionBill(),this.Scene); }
        }


        public IRdLayBill RdLayBill
        {
            get { return Ext.SetScence(Factory.GetRdLayBill(), this.Scene); }
        }


        public IMrpolicysetsBill MrpolicysetsBill
        {
            get { return Ext.SetScence(Factory.GetMrpolicysetsBill(),this.Scene); }
        }


        public IDtparamBill DtparamBill
        {
            get { return Ext.SetScence(Factory.GetDtparamBill(),this.Scene); }
        }


        public IRide_Model_CoefficientBill Ride_Model_CoefficientBill
        {
            get { return Ext.SetScence(Factory.GetRide_Model_CoefficientBill(), this.Scene); }
        }

        public IPci_Model_CoefficientBill Pci_Model_CoefficientBill
        {
            get { return Ext.SetScence(Factory.GetPci_Model_CoefficientBill(), this.Scene); }
        }


        public IFriction_Model_CoefficientsBill Friction_Model_CoefficientsBill
        {
            get { return Ext.SetScence(Factory.GetFriction_Model_CoefficientsBill(), this.Scene); }
        }
    }
}
