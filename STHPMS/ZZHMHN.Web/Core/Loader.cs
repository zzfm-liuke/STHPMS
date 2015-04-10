using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using ZZHMHN.IBase;
using ZZHMHN.IBase.I_Core;

namespace ZZHMHN.Web.Core
{
    public class Loader
    {
        public void Start()
        {
            LoggerConfigure();
            InitModule();
        }

        private void InitModule()
        {
            string[,] assemblyTypeList = { { "ZZHMHN.Web", "ZZHMHN.Web.Core.WebModule" }, 
                                         { "ZZHMHN.BLL", "ZZHMHN.BLL.Core.BllModule" }, 
                                         { "ZZHMHN.DAL", "ZZHMHN.DAL.Core.DalModule" } };
            

            for (int i = 0; i < assemblyTypeList.GetLength(0); i++)
            {
                IModule module = ZZHMHN.IBase.MyApp.CreateInstance(assemblyTypeList[i,0],assemblyTypeList[i,1]) as IModule;
                if (module != null)
                    module.Init();
            }


            System.Diagnostics.Debug.Assert(MyApp.Bll != null, "BllFacade is null");
            System.Diagnostics.Debug.Assert(MyApp.Dal != null, "DalFacade is null");
            System.Diagnostics.Debug.Assert(MyApp.UI != null, "UIFacade is null");
        }


        private static void LoggerConfigure()
        {
            string logPath = HttpContext.Current.Server.MapPath("~/config/log4net.config");
            if (File.Exists(logPath))
                XmlConfigurator.Configure(new FileInfo(logPath));
        }
    }
}