using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZHMHN.Common.Cache
{
    public class MyCacheTools
    {
        #region 存入Cache
        /// <summary>
        /// 存入Cache
        /// </summary>
        /// <param name="key">缓存key</param>
        /// <param name="value">缓存的值</param>
        /// <param name="time_HH">存xx小时</param>
        /// <returns>是否执行成功[bool]</returns>
        public static bool SetCache(string key, object value, int time_HH)
        {
            bool result = false;
            try
            {
                DateTime dt = DateTime.Now.AddHours(time_HH);
                System.Web.HttpRuntime.Cache.Insert(key, value, null,
                    dt, System.Web.Caching.Cache.NoSlidingExpiration);
                result = true;
            }
            catch (System.Exception ex) { }
            return result;
        }
        #endregion

        #region 取得Cache
        /// <summary>
        /// 取得Cache
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>object类型</returns>
        public static object GetCache(string key)
        {
            return System.Web.HttpRuntime.Cache.Get(key);
        }
        #endregion

        #region 查询Cache是否存在
        /// <summary>
        /// 查询Cache是否存在
        /// </summary>
        /// <param name="key">key 值</param>
        /// <returns>bool</returns>
        public static bool IsCacheExist(string key)
        {
            bool result = false;

            object temp = System.Web.HttpRuntime.Cache.Get(key);
            if (null != temp)
            {
                result = true;
            }
            return result;
        }
        #endregion

    }
}
