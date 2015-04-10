using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZZHMHN.IBase;
using ZZHMHN.IBase.I_Entity;
using ZZHMHN.IBase.I_UI;
using ZZHMHN.Web.Core;
using ZZHMHN.Web.Entity;

namespace ZZHMHN.Web.UI
{
    public class TestUI:UIBase,ITestUI
    {
        public string PrintAddResult(ITestEntity entity)
        {
            return string.Format("程序计算结果:{0}", MyApp.Bll.Test.AddWith10(entity)); 

        }
    }
}