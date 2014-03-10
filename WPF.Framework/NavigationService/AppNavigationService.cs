using System;
using System.Linq;
using System.Windows.Navigation;
using System.ComponentModel.Composition;

namespace WPF.Framework
{
    [Export(typeof(INavigationService))]
    public class AppNavigationService : INavigationService, IPartImportsSatisfiedNotification
    {
        internal NavigationService NavigationService { get; set; }

        [Import]
        protected BootStrapper BootStrapper { get; private set; }

        public AppNavigationService()
        {

        }

        public void NavigateTo(string viewName)
        {
            var view = BootStrapper.Views.FirstOrDefault(x => x.Metadata.Alias.Equals(viewName,StringComparison.InvariantCultureIgnoreCase));
            if (view != null)
            {
                string datacontext = view.Metadata.DataContextAlias;
                View viewObject = (View)view.Value;
                if (viewObject != null)
                {
                    if (string.IsNullOrWhiteSpace(datacontext))
                        viewObject.DataContext = BootStrapper.DefaultViewModel;
                    else if (viewObject.DataContext == null)
                        viewObject.DataContext = BootStrapper.ViewModels.FirstOrDefault(x => x.Metadata.Alias.Equals(datacontext, StringComparison.InvariantCultureIgnoreCase)).Value;

                    NavigateTo(viewObject);
                }
            }
        }

        public void NavigateTo(object viewObject)
        {
            if (viewObject != null)
            {
                NavigationService.Navigate(viewObject);
            }
        }

        public void Back()
        {
            NavigationService.GoBack();
        }

        public void OnImportsSatisfied()
        {

        }
    }
}
