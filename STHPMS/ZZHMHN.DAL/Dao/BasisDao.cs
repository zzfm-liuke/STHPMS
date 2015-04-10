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
    public class BasisDao : DalBase, IBasisDao
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

        #region Repository
        public IRepository Archive
        {
            get { return Factory.GetRepository(string.Format(ConfigStrings.ArchiveConnectionString, "")); }
        }
        public IRepository IHPMS
        {
            get { return Factory.GetRepository(string.Format(ConfigStrings.IHPMSConnectionString, "")); }
        }
        public IRepository PCIWCI
        {
            get { return Factory.GetRepository(string.Format(ConfigStrings.PCIWCIConnectionString, "")); }
        }
        public IRepository Prefer
        {
            get { return Factory.GetRepository(string.Format(ConfigStrings.PreferConnectionString, "")); }
        }
        public IRepository Select
        {
            get { return Factory.GetRepository(string.Format(ConfigStrings.SelectConnectionString, "")); }
        }
        #endregion
    }
}
