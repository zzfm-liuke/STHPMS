using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.BLL.Core;
using ZZHMHN.IBase;
using ZZHMHN.IBase.I_BLL;
using ZZHMHN.IBase.I_Entity.Ihpms;

namespace ZZHMHN.BLL.Bussiness
{
    public class CodeInfoBussiness : BllBase,ICodeInfoBll
    {
      
        public List<T> Get<T>(T entity) where T : class ,ICODEINFO
        {
            //检查缓存
            if (!Common.Cache.MyCacheTools.IsCacheExist(entity.STNDNAME))
            {
                List<T> lst = this.Scene.Dal.CodeInfoRepository.Get<T>(entity);
                //List<T> lst = MyApp.Dal.CodeInfoRepository.Get<T>(entity);
                Common.Cache.MyCacheTools.SetCache(entity.STNDNAME, lst, 10);
            }

            return (List<T>)Common.Cache.MyCacheTools.GetCache(entity.STNDNAME);
        }


        public List<int> GetMaxNum()
        {
            return MyApp.Dal.CodeInfoRepository.GetMaxNum();
        }


        public long Insert(ICODEINFO entity)
        {
            return MyApp.Dal.BasisDao.IHPMS.Insert(entity);
        }
    }
}
