using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZHMHN.IBase.I_Core
{
    public abstract class ModuleBase:IModule
    {

        #region IDisposable

        protected bool IsDisposed { get; set; }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool isDisposing)
        {
            try
            {
                if (!this.IsDisposed)
                {
                    if (isDisposing)
                    {
                        OnDispose();
                    }
                }
            }
            finally
            {
                this.IsDisposed = true;
            }
        }

        protected virtual void OnDispose()
        {
        }
        #endregion 
    
        public virtual void Init()
        {
        }
    }
}
