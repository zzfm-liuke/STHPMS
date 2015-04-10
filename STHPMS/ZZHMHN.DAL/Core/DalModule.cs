using ZZHMHN.IBase;
using ZZHMHN.IBase.Common;
using ZZHMHN.IBase.Definition;
using ZZHMHN.IBase.I_Core;
using ZZHMHN.IBase.I_DAL;

namespace ZZHMHN.DAL.Core
{
    public class DalModule : DisposeObject, IModule
    {
        public void Init()
        {
            System.Diagnostics.Debug.WriteLine("DalModule");

            IDalFactory factory = new DalFactory();
            IDalFacade facade = new DalFacade();


            MyApp.Locator.AddBuilder<IObjectFactory>(() => factory, TypeStringDefinition.DALFACTORY);
            MyApp.Locator.AddBuilder<IFacade>(() => facade, TypeStringDefinition.DALFACADE);

            MyApp.Locator.AddBuilder<IDalFactory>(() => new DalFactory());
            MyApp.Locator.AddBuilder<IDalFacade>(() => new DalFacade());
        }


        protected override void OnDispose()
        {
            MyApp.Locator.RemoveBuidler<IObjectFactory>(TypeStringDefinition.DALFACTORY);
            MyApp.Locator.RemoveBuidler<IFacade>(TypeStringDefinition.DALFACADE);

            MyApp.Locator.RemoveBuidler<IDalFactory>();
            MyApp.Locator.RemoveBuidler<IDalFacade>();
        }
    }
}
