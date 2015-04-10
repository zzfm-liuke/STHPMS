using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZHMHN.IBase.I_Core
{
    public interface IServiceLocator : IServiceProvider
    {
        void AddBuilder<TServiceType>(Func<object> value, string key = null);
        void AddBuilder(Func<object> value, Type serviceType = null, string key = null);
        void RemoveBuidler<TServiceType>(string key = null);
        void RemoveBuidler(Type serviceType = null, string key = null);
        void ClearBuidler();

        IEnumerable<TService> GetAllInstances<TService>();
        IEnumerable<object> GetAllInstances(Type serviceType);
        TService GetInstance<TService>();
        TService GetInstance<TService>(string key);
        object GetInstance(Type serviceType);
        object GetInstance(Type serviceType, string key);
    }
}
