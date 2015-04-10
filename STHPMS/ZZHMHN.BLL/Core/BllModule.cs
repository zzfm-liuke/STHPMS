using ZZHMHN.IBase;
using ZZHMHN.IBase.Common;
using ZZHMHN.IBase.Definition;
using ZZHMHN.IBase.I_BLL;
using ZZHMHN.IBase.I_Core;

namespace ZZHMHN.BLL.Core
{
    public class BllModule : DisposeObject, IModule
    {
        public void Init()
        {
            System.Diagnostics.Debug.WriteLine("BllModule");

            IBllFactory factory=new BllFactory();
            IBllFacade facade = new BllFacade();

            MyApp.Locator.AddBuilder<IObjectFactory>(() => factory, TypeStringDefinition.BLLFACTORY);
            MyApp.Locator.AddBuilder<IFacade>(() => facade, TypeStringDefinition.BLLFACADE);


            MyApp.Locator.AddBuilder<IBllFactory>(() => new BllFactory());
            MyApp.Locator.AddBuilder<IBllFacade>(() => new BllFacade());
        }
        

        protected override void OnDispose()
        {
            MyApp.Locator.RemoveBuidler<IObjectFactory>(TypeStringDefinition.BLLFACTORY);
            MyApp.Locator.RemoveBuidler<IFacade>(TypeStringDefinition.BLLFACADE);


            MyApp.Locator.RemoveBuidler<IBllFactory>();
            MyApp.Locator.RemoveBuidler<IBllFacade>();
        }
    }
}
