using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.IBase.I_Entity;

namespace ZZHMHN.IBase.I_UI
{
    public interface ITestUI:IUI
    {
        string PrintAddResult(ITestEntity entity);
    }
}
