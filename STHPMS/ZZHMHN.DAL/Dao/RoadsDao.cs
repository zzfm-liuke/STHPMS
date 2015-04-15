using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.DAL.Core;
using ZZHMHN.IBase;
using ZZHMHN.IBase.Definition;
using ZZHMHN.IBase.I_DAL;

namespace ZZHMHN.DAL.Dao
{
    public class RoadsDao : DalBase, IRoadsDao
    {
        public RoadsDao()
        {
            _configStrings = ConfigStringsFactory.NewConfigStrings();
        }
        public IDalFactory Factory
        {
            get
            {
                IDalFactory factory = MyApp.Locator.GetInstance<IDalFactory>(TypeStringDefinition.DALFACTORY);
                System.Diagnostics.Debug.Assert(factory != null, "IDalFactory is null");

                return factory;
            }
        }

        public string DataSource
        {
            get;
            set;
        }

        private ConfigStrings _configStrings;
        #region Repository
        public IRepository IHPMS
        {
            get { return Factory.GetRepository(string.Format(_configStrings.IHPMSConnectionString, DataSource)); }
        }
        public IRepository Prefer
        {
            get { return Factory.GetRepository(string.Format(_configStrings.PreferConnectionString, DataSource)); }
        }
        public IRepository Select
        {
            get { return Factory.GetRepository(string.Format(_configStrings.SelectConnectionString, DataSource)); }
        }
        #endregion

        protected override void OnDispose()
        {
            _configStrings = null;
            base.OnDispose();
        }
    }
}
