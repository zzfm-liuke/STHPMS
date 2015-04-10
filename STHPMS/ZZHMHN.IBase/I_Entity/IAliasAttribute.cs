using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZHMHN.IBase.I_Entity
{
    [AttributeUsage(AttributeTargets.Interface)]
    public class IAliasAttribute : AliasAttribute
    {
        public IAliasAttribute(string name)
            : base(name)
        {
        }

    }
}
