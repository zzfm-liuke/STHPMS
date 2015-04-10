using ZZHMHN.IBase;
using ZZHMHN.IBase.Common;
using ZZHMHN.IBase.Definition;
using ZZHMHN.IBase.I_Core;
using ZZHMHN.IBase.I_UI;

namespace ZZHMHN.Web.Core
{
    public class WebModule :DisposeObject, IModule
    {
        public void Init()
        {
            System.Diagnostics.Debug.WriteLine("WebModule");

            IUIFactory factory = new UIFactory();
            IUIFacade facade = new UIFacade();


            MyApp.Locator.AddBuilder<IObjectFactory>(() => factory, TypeStringDefinition.UIFACTORY);
            MyApp.Locator.AddBuilder<IFacade>(() => facade, TypeStringDefinition.UIFACADE);

            MyApp.Locator.AddBuilder<IUIFactory>(() => new UIFactory());
            MyApp.Locator.AddBuilder<IUIFacade>(() => new UIFacade());
            MyApp.Locator.AddBuilder<IScene>(() => new Scene());
        }


        protected override void OnDispose()
        {
            MyApp.Locator.RemoveBuidler<IObjectFactory>(TypeStringDefinition.UIFACTORY);
            MyApp.Locator.RemoveBuidler<IFacade>(TypeStringDefinition.UIFACADE);

            MyApp.Locator.RemoveBuidler<IUIFactory>();
            MyApp.Locator.RemoveBuidler<IUIFacade>();        
            MyApp.Locator.RemoveBuidler<IScene>();
        }
    }
}