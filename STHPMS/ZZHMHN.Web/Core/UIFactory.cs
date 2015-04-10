using ZZHMHN.IBase.Common;
using ZZHMHN.IBase.I_UI;
using ZZHMHN.Web.UI;

namespace ZZHMHN.Web.Core
{
    /// <summary>
    /// ui 层对象创建工厂
    /// </summary>
    public class UIFactory : DisposeObject, IUIFactory
    {
        #region test
        private ITestUI _testUI;
        public ITestUI GetTestUI()
        {
            if (_testUI == null)
                _testUI = new TestUI();

            return _testUI;
        }

        public void DisposeTestUI()
        {
            if (_testUI != null)
                _testUI.Dispose();
        }
        #endregion
       

        protected override void OnDispose()
        {
            DisposeTestUI();
        }
    }
}