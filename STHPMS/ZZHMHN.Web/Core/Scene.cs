using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZZHMHN.IBase;
using ZZHMHN.IBase.Common;
using ZZHMHN.IBase.I_BLL;
using ZZHMHN.IBase.I_Core;
using ZZHMHN.IBase.I_DAL;
using ZZHMHN.IBase.I_UI;

namespace ZZHMHN.Web.Core
{
    public class Scene : DisposeObject, IScene
    {
        public Scene()
        {
            UI = MyApp.Locator.GetInstance<IUIFacade>();
            Bll = MyApp.Locator.GetInstance<IBllFacade>(); 
            Dal = MyApp.Locator.GetInstance<IDalFacade>();

            UI.Scene = this;
            Bll.Scene = this;
            Dal.Scene = this;
        }

        public IContext Context
        {
            get;
            set;
        }
        public IUIFacade UI
        {
            get;
            set;
        }
        public IBllFacade Bll
        {
            get;
            set;
        }
        public IDalFacade Dal
        {
            get;
            set;
        }

        protected override void OnDispose()
        {
            if (UI != null) UI.Dispose();
            if (Bll != null) Bll.Dispose();
            if (Dal != null) Dal.Dispose();

            UI = null;
            Bll = null;
            Dal = null;
            base.OnDispose();
        }
    }
}