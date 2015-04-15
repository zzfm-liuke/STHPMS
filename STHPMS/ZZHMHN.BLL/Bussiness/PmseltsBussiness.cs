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
    public class PmseltsBussiness : BllBase, IPmseltsBill
    {
        public List<T> Get<T>(IPMSELT entity) where T : class, IPMSELT
        {
            return this.Scene.Dal.PmseltsRepository.Get<T>(entity);
           
        }


        public List<string> GetVal_OP(string stnd_name)
        {
            return this.Scene.Dal.PmseltsRepository.GetVal_OP(stnd_name);
        }


        public int ExcuteSqlByIHPMS(string table, string field, string fieldValue, string RoadNum, string segIds, string begin, string end)
        {
            return MyApp.Dal.PmseltsRepository.ExcuteSqlByIHPMS(table, field, fieldValue, RoadNum, segIds, begin, end);
        }
    }
}
