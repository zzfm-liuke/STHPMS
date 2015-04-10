using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZHMHN.Common.Extension
{
    public static class ExtHelper
    {
        public static  string GetDatbaseNameById(this string id)
        {
            return "_" + id;
        }
    }
}
