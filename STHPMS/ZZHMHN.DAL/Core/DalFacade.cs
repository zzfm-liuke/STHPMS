using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.IBase;
using ZZHMHN.IBase.Common;
using ZZHMHN.IBase.Definition;
using ZZHMHN.IBase.I_Core;
using ZZHMHN.IBase.I_DAL;

namespace ZZHMHN.DAL.Core
{
    /// <summary>
    /// 数据层接口统一调用处
    /// </summary>
    public class DalFacade : DisposeObject, IDalFacade
    {
        private IDalFactory _factory;
        public IDalFactory Factory
        {
            get
            {
                IDalFactory factory=null;
                if (Scene == null)
                    factory = MyApp.Locator.GetInstance<IDalFactory>(TypeStringDefinition.DALFACTORY);
                else
                {
                    if (_factory == null)
                        _factory = MyApp.Locator.GetInstance<IDalFactory>();

                    factory = _factory;
                }

                System.Diagnostics.Debug.Assert(factory != null, "IDalFactory is null");

                return factory;
            }
        }
        public IScene Scene { get; set; }

        public ITestDal Test
        {
            get { return Ext.SetScence(Factory.GetTestDal(), this.Scene); }
        }

        #region dao
        public INavigationDao NavigationDao
        {
            get { return  Ext.SetScence(Factory.GetNavigationDao(), this.Scene); }
        }
        public IBasisDao BasisDao
        {
            get { return Ext.SetScence(Factory.GetBasisDao(), this.Scene); }
        }

        public IRoadsDao RoadsDao
        {
            get { return  Ext.SetScence(Factory.GetRoadsDao(), this.Scene); }
        }
        #endregion

        #region Repository

        public ICodeInfoRepository CodeInfoRepository
        {
            get { return  Ext.SetScence(Factory.GetCodeInfoRepository(), this.Scene); }
        }
        public IRoadWayRepository RoadWayRepository
        {
            get { return  Ext.SetScence(Factory.GetRoadWayRepository(), this.Scene); }
        }

        public IInventoryRepository InventoryRepository
        {
            get { return  Ext.SetScence(Factory.GetInventoryRepository(), this.Scene); }
        }

        public IDatabaseManagerRepository DatabaseManagerRepository
        {
            get { return  Ext.SetScence(Factory.GetDatabaseManagerRepository(), this.Scene); }
        }

        public ISelectionRepository SelectionRepository
        {
            get { return Ext.SetScence(Factory.GetSelectionRepository(), this.Scene); }
        }

        public IPmseltsRepository PmseltsRepository 
        {
            get { return Ext.SetScence(Factory.GetPmseltsRepository(),this.Scene); }
        }

        public IRdLayRepository RdLayRepository
        {
            get { return Ext.SetScence(Factory.GetRdLayRepository(),this.Scene); }
        }

        #endregion


        protected override void OnDispose()
        {
            Factory.Dispose();
            _factory = null;
        }








        public IMrpolicysetsRepository MrpolicysetsRepository
        {
            get { return Ext.SetScence(Factory.GetMrpolicysetsRepository(), this.Scene); }
        }


        public IDtparamRepository DtparamRepository
        {
            get { return Ext.SetScence(Factory.GetDtparamRepository(), this.Scene); }
        }


        public IRide_Model_CoefficientRepository Ride_Model_CoefficientRepository
        {
            get { return Ext.SetScence(Factory.GetRide_Model_CoefficientRepository(), this.Scene); }
        }


        public IPci_Model_CoefficientRepository Pci_Model_CoefficientRepository
        {
            get { return Ext.SetScence(Factory.GetPci_Model_CoefficientRepository(), this.Scene); }
        }


        public IFriction_Model_CoefficientsRepository Friction_Model_CoefficientsRepository
        {
            get { return Ext.SetScence(Factory.GetFriction_Model_CoefficientsRepository(), this.Scene); }
        }
    }
}
