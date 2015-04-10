using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.IBase.I_Entity;
using ZZHMHN.IBase.I_Entity.IPCIWCI;

namespace ZZHMHN.IBase.I_BLL
{
    public interface ITestBll:IBll
    {
        int AddWith10(ITestEntity entity);
        long Insert(ICOEFF_A entity);
        long Update(ICOEFF_A entity);
        int Delete(ICOEFF_A entity);
        List<T> Get<T>() where T : class ,ICOEFF_A;
        List<T> Get<T>(T entity) where T : class ,ICOEFF_A;
        void TestScence();
    }
}
