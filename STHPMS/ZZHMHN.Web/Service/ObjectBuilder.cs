using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace ZZHMHN.Web.Service
{
    public class ObjectBuilderFactory : ZZHMHN.IBase.I_Core.IServiceLocator
    {

        #region objectcache
        private ConcurrentDictionary<string, Func<object>> _keyCaches = new ConcurrentDictionary<string, Func<object>>();
        private ConcurrentDictionary<Type, List<Func<object>>> _serviceTypeCaches = new ConcurrentDictionary<Type, List<Func<object>>>();

        #endregion

        #region AddBuilder
        public void AddBuilder<TServiceType>(Func<object> value, string key = null)
        {
            AddBuilder(value, typeof(TServiceType), key);
        }

        public void AddBuilder(Func<object> value, Type serviceType = null, string key = null)
        {
            if (serviceType != null)
            {
                List<Func<object>> lstCache = _serviceTypeCaches.GetOrAdd(serviceType, new List<Func<object>>());
                lstCache.Add(value);
            }

            if (key != null)
                _keyCaches.TryAdd(key, value);
        }

        public void RemoveBuidler<TServiceType>(string key = null)
        {
            RemoveBuidler(typeof(TServiceType), key);
        }

        public void RemoveBuidler(Type serviceType = null, string key = null)
        {
            List<Func<object>> lstCache = null;
            if (serviceType != null)
                _serviceTypeCaches.TryRemove(serviceType, out lstCache);
            if (lstCache != null)
                lstCache.Clear();


            Func<object> value = null;
            if (key != null)
                _keyCaches.TryRemove(key, out value);
        }

        public void ClearBuidler()
        {
            _keyCaches.Clear();
            _serviceTypeCaches.Clear();
        }
        #endregion

        #region IServiceLocator
        public IEnumerable<TService> GetAllInstances<TService>()
        {
            IEnumerable<object> value = GetAllInstances(typeof(TService));
            if (value == null) return default(IEnumerable<TService>);
            return value.Cast<TService>();
        }

        public IEnumerable<object> GetAllInstances(Type serviceType)
        {
            IEnumerable<object> iterator = null;
            List<Func<object>> lstObjects = null;

            _serviceTypeCaches.TryGetValue(serviceType, out lstObjects);

            if (lstObjects != null)
            {
                iterator = from o in lstObjects
                           select o();
            }

            return iterator;
        }

        public TService GetInstance<TService>()
        {
            object value = GetInstance(typeof(TService));
            if (value == null) return default(TService);
            return (TService)value;
        }

        public TService GetInstance<TService>(string key)
        {
            object value = GetInstance(typeof(TService), key);
            if (value == null) return default(TService);
            return (TService)value;
        }

        public object GetInstance(Type serviceType)
        {
            object value = null;
            IEnumerable<object> lstObjects = GetAllInstances(serviceType);
            if (lstObjects != null)
                value = lstObjects.First();


            return value;
        }

        public object GetInstance(Type serviceType, string key)
        {
            object value = null;
            Func<object> obj = null;

            _keyCaches.TryGetValue(key, out obj);
            if (obj != null)
                value = obj();

            return value;
        }

        public object GetService(Type serviceType)
        {
            return GetInstance(serviceType);
        }
        #endregion
    
    }
}
