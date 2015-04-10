using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.IBase.I_Entity;
using ZZHMHN.IBase.I_Entity.IPCIWCI;

namespace ZZHMHN.IBase.I_DAL
{
    public interface ITestDal:IDal
    {
        int Add(ITestEntity entity);
        List<T> Get<T>(T entity) where T : ICOEFF_A;
        void TestScence();
    }
}
