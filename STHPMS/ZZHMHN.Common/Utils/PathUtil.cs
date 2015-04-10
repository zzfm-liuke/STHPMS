using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ZZHMHN.Common.Utils
{
    public class PathUtil
    {
        public static string MapAbsolutePath(string relativePath)
        {
            return System.IO.Path.Combine(HttpRuntime.AppDomainAppPath, relativePath);
        }
    }
}
