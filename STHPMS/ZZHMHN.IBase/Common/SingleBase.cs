using System;
using System.Collections.Generic;

namespace ZZHMHN.IBase.Common
{
    public class SingleBase:DisposeObject
    {
        #region single
        private static object _objLocked = new object();
        private Dictionary<int, object> m_cache = new Dictionary<int, object>();
        
        protected T Get<T>(Action<T> initial=null)
                where T : new()
        {
            lock (_objLocked)
            {
                object value = default(T);
                int key = typeof(T).GetHashCode();

                if (this.m_cache.TryGetValue(key, out value))
                {
                    return (T)value;
                }

                if (!this.m_cache.TryGetValue(key, out value))
                {
                    value = new T();
                    if (initial != null) initial((T)value);
                    this.m_cache[key] = value;
                }

                return (T)value;
            }
           
        }

        protected T Get<T>(T value)
                where T : new()
        {
            lock (_objLocked)
            {
                int key = value.GetType().GetHashCode();

                if (!this.m_cache.ContainsKey(key))
                {
                    this.m_cache[key] = value;
                }
                else
                {
                    throw new Exception(string.Format("{0}类型已存在!", typeof(T).Name));
                }

                return value;
            }
        }

        protected bool Remove<T>(T value)
        {
            lock (_objLocked)
            {
                int key = value.GetType().GetHashCode();
                IDisposable dispose = value as IDisposable;
                if (dispose != null) dispose.Dispose();
                return this.m_cache.Remove(key); ;
            }            
        }
        #endregion

        #region IDisposable

        protected override void OnDispose()
        {
            m_cache = null;

            base.OnDispose();
        }
        #endregion 
    }
}
