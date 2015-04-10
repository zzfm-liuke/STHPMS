using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.BLL.Core;
using ZZHMHN.IBase;
using ZZHMHN.IBase.I_BLL;
using ZZHMHN.IBase.I_Entity.Ihpms;

namespace ZZHMHN.BLL.Bussiness
{
    public class InventoryBussiness : BllBase, IInventoryBill
    {
        public List<T> GetBegin<T>(int RoadNum, int rdSelectedIndex) where T : class, IINVNTORY
        {
            //用户库和基础库的联查
            return MyApp.Dal.InventoryRepository.GetBegin<T>(RoadNum, rdSelectedIndex);
        }


        public List<T> GetEnd<T>(int RoadNum, string beginDrowDownList) where T : class, IINVNTORY
        {
            return MyApp.Dal.InventoryRepository.GetEnd<T>(RoadNum, beginDrowDownList);
        }
    }
}
