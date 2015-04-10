using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.IBase.Definition;
using ZZHMHN.IBase.I_BLL;
using ZZHMHN.IBase.I_Core;
using ZZHMHN.IBase.I_DAL;
using ZZHMHN.IBase.I_UI;

namespace ZZHMHN.IBase
{
    public static class MyApp
    {
        static MyApp()
        {
            Locator = CreateInstance(TypeStringDefinition.OBJECTBUILDERFACTORY_ASSEMBLY, TypeStringDefinition.OBJECTBUILDERFACTORY_TYPE) as IServiceLocator; ;
        }

        public static IServiceLocator Locator { get; private set; }
        public static IUIFacade UI { get { return Locator.GetInstance<IUIFacade>(TypeStringDefinition.UIFACADE); } }
        public static IBllFacade Bll { get { return Locator.GetInstance<IBllFacade>(TypeStringDefinition.BLLFACADE); } }
        public static IDalFacade Dal { get { return Locator.GetInstance<IDalFacade>(TypeStringDefinition.DALFACADE); } }
        public static IScene Scene { get { return Locator.GetInstance<IScene>(); } }

        #region 对象的创建
        public static object CreateInstance(string assemblyName, string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
                return null;

            object obj = null;

            try
            {
                if (!string.IsNullOrEmpty(assemblyName))
                {
                    var assemblyList = AppDomain.CurrentDomain.GetAssemblies();
                    foreach (var a in assemblyList)
                    {
                        if (a.FullName.Contains(assemblyName))
                        {
                            obj = a.CreateInstance(typeName);
                            break;
                        }
                    }

                    if (obj == null)
                    {
                        Assembly a=Assembly.Load(assemblyName);
                        obj = a.CreateInstance(typeName);
                    }
                }
                else
                {
                    var type = Type.GetType(typeName);
                    if (type != null) obj = type.Assembly.CreateInstance(typeName);
                }
            }
            catch (Exception ex)
            {
                string msg = "获取对象失败——AssemblyName:" + assemblyName + "——TypeName:" + typeName +"--"+ex.Message;
                throw new Exception(msg);
            }


            return obj;

        }
        #endregion
    }
}

