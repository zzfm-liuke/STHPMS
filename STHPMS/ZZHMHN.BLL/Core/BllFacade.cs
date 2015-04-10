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


        protected override void OnDispose()
        {
            Factory.Dispose();
            _factory=null;
        }

    }
}
