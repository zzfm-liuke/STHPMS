using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.IBase.I_Entity;
using ZZHMHN.IBase.I_Entity.Ihpms;

namespace ZZHMHN.IBase.I_BLL
{
    public interface IPmseltsBill : IBll
    {
        List<T> Get<T>(IPMSELT entity) where T : class ,IPMSELT;
        List<string> GetVal_OP(string stnd_name);

        int ExcuteSqlByIHPMS(string table, string field, string fieldValue, string RoadNum, string segIds, string begin, string end);
    }
}
