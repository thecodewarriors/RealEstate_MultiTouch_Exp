using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.Composition;

namespace WPF.Framework
{
    [Export]
    public class BootStrapper : IPartImportsSatisfiedNotification
    {
        [Import(typeof(INavigationService))]
        public AppNavigationService AppNavigationService;

        [ImportMany]
        public IEnumerable<Lazy<IView, IViewInfo>> Views { get; private set; }

        [ImportMany]
        public IEnumerable<Lazy<IViewModel, IViewModelInfo>> ViewModels { get; private set; }

        private IView _DefaultView;
        public IView DefaultView
        {
            get
            {
                if (_DefaultView != null)
                    return _DefaultView;

                try
                {
                    _DefaultView = Views.Where(x => x.Metadata.IsDefault).Select(x => x.Value).FirstOrDefault();
                    if (_DefaultView == null)
                        throw new ArgumentNullException("DefaultView", "No Default View Exist");
                }
                catch (Exception ex)
                {
                    //Log
                }

                return _DefaultView;
            }
        }

        private IViewModel _DefaultViewModel;
        public IViewModel DefaultViewModel
        {
            get
            {
                if (_DefaultViewModel != null)
                    return _DefaultViewModel;
                try
                {

                    _DefaultViewModel = ViewModels.Where(x => x.Metadata.IsDefault).Select(x => x.Value).FirstOrDefault();
                    if (_DefaultViewModel == null)
                        throw new ArgumentNullException("DefaultViewModel", "No Default View Model Exist");
                }
                catch (Exception ex)
                {
                    //log
                }

                return _DefaultViewModel;
            }
        }

        public IView GetView(string aliasName)
        {
            return Views.Where(x => x.Metadata.Alias.Equals(aliasName, StringComparison.InvariantCultureIgnoreCase))
                .Select(x => x.Value).FirstOrDefault();
        }
        public IViewModel GetViewModel(string aliasName)
        {
            return ViewModels.Where(x => x.Metadata.Alias.Equals(aliasName, StringComparison.InvariantCultureIgnoreCase))
                .Select(x => x.Value).FirstOrDefault();
        }

        public void OnImportsSatisfied()
        {

        }
    }
}
