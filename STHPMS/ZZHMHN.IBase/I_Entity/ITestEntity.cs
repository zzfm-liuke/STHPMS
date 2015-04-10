using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZHMHN.IBase.I_Entity
{
    public interface ITestEntity:IEntity
    {
        int X { get; set; }
        int Y { get; set; }
    }
}
