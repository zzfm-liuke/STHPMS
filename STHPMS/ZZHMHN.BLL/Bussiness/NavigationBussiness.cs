using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.BLL.Core;
using ZZHMHN.IBase;
using ZZHMHN.IBase.I_BLL;

namespace ZZHMHN.BLL.Bussiness
{
    public class NavigationBussiness : BllBase, INavigationBill
    {
        public string GetData()
        {
            return JsonConvert.SerializeObject(MyApp.Dal.NavigationDao.GetData());
        }
    }
}
