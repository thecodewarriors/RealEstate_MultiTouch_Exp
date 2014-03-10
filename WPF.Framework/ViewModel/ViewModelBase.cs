using System.ComponentModel.Composition;

namespace WPF.Framework
{
    public abstract class ViewModelBase : ModelBase, IViewModel, IPartImportsSatisfiedNotification
    {
        private BootStrapper _BootStrapper = null;
        [Import]
        public BootStrapper BootStrapper
        {
            get { return _BootStrapper; }
            set { _BootStrapper = value; }
        }

        protected AppNavigationService NavigationManager { get { return BootStrapper.AppNavigationService; } }

        public ViewModelBase()
        {

        }

        public virtual void OnImportsSatisfied()
        {

        }

        public IViewModelInfo ViewModelInfo
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}
