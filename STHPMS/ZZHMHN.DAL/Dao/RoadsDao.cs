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

        #region Repository
        public IRepository IHPMS
        {
            get { return Factory.GetRepository(string.Format(ConfigStrings.IHPMSConnectionString, DataSource)); }
        }
        public IRepository Prefer
        {
            get { return Factory.GetRepository(string.Format(ConfigStrings.PreferConnectionString, DataSource)); }
        }
        public IRepository Select
        {
            get { return Factory.GetRepository(string.Format(ConfigStrings.SelectConnectionString, DataSource)); }
        }
        #endregion
    }
}
