using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZHMHN.IBase.I_DAL
{
    public interface INavigationDao : IDal
    {
        List<object> GetData();
    }
}
