using System.ComponentModel.Composition;
using System.Windows.Controls;

namespace WPF.Framework
{
    public class View : UserControl, IView, IPartImportsSatisfiedNotification
    {
        private BootStrapper _BootStrapper = null;
        [Import]
        public BootStrapper BootStrapper
        {
            get { return _BootStrapper; }
            set { _BootStrapper = value; }
        }
        protected AppNavigationService NavigationManager { get { return BootStrapper.AppNavigationService; } }

        public View()
        {           
        }

        public void OnImportsSatisfied()
        {

        }

        public IViewInfo ViewInfo
        {
            get;
            set;
        }
    }
}
