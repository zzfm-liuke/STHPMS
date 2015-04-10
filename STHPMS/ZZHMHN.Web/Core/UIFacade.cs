using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZZHMHN.IBase;
using ZZHMHN.IBase.Common;
using ZZHMHN.IBase.Definition;
using ZZHMHN.IBase.I_Core;
using ZZHMHN.IBase.I_UI;

namespace ZZHMHN.Web.Core
{
    /// <summary>
    /// ui层对象统一调用处
    /// </summary>
    public class UIFacade : DisposeObject, IUIFacade
    {

        private IUIFactory _factory;
        public IUIFactory Factory
        {
            get
            {
                IUIFactory factory = null;
                if (Scene == null)
                {
                    factory = MyApp.Locator.GetInstance<IUIFactory>(TypeStringDefinition.UIFACTORY);
                }
                else
                {
                    if (_factory==null)
                        _factory = MyApp.Locator.GetInstance<IUIFactory>();

                    factory = _factory;
                }
                System.Diagnostics.Debug.Assert(factory != null, "IUIFactory is null"); 
                return factory;
            }
        }

        public IScene Scene { get; set; }

        public ITestUI Test
        {
            get { return Ext.SetScence(Factory.GetTestUI(), this.Scene); }
        }

        protected override void OnDispose()
        {
            Factory.Dispose();
            _factory = null;
        }
    }
}