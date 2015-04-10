using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.BLL.Core;
using ZZHMHN.IBase;
using ZZHMHN.IBase.I_BLL;
using ZZHMHN.IBase.I_Entity.IPCIWCI;

namespace ZZHMHN.BLL.Bussiness
{
    public class TestBussiness : BllBase, ITestBll
    {
        public int AddWith10(IBase.I_Entity.ITestEntity entity)
        {
            return MyApp.Dal.Test.Add(entity) + 10;
        }

        public long Insert(ICOEFF_A entity)
        {
            return MyApp.Dal.BasisDao.PCIWCI.Insert(entity);
        }

        public long Update(ICOEFF_A entity)
        {
            return MyApp.Dal.BasisDao.PCIWCI.Update(entity);
        }

        public int Delete(ICOEFF_A entity)
        {
            return MyApp.Dal.BasisDao.PCIWCI.Delete<ICOEFF_A>(new { Distress_ID = entity.Distress_ID, Severity = entity.Severity, Max_Distress_Density = entity.Max_Distress_Density });
        }

        public List<T> Get<T>() where T : class ,ICOEFF_A
        {
            return MyApp.Dal.BasisDao.PCIWCI.Select<T>();
        }

        public List<T> Get<T>(T entity) where T : class ,ICOEFF_A
        {
            return MyApp.Dal.Test.Get<T>(entity);
        }


        public void TestScence()
        {
            this.Scene.Dal.Test.TestScence();
        }
    }
}
