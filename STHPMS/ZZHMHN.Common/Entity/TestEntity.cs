using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.IBase;
using ZZHMHN.IBase.I_Entity;
using ZZHMHN.Web.Core;

namespace ZZHMHN.Web.Entity
{
    public class TestEntity : EntityBase, ITestEntity
    {
        public int X
        {
            get;
            set;
        }

        public int Y
        {
            get;
            set;
        }
    }
}
