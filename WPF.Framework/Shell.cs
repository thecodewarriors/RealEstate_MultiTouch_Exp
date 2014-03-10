using System;
using System.Windows;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition;
using System.Windows.Controls;

namespace WPF.Framework
{
    public class Shell : Window, IPartImportsSatisfiedNotification
    {
        [Import]
        protected BootStrapper BootStrapper { get; private set; }

        protected AppNavigationService NavigationManager { get { return BootStrapper.AppNavigationService; } }

        public Shell()
        {
            Loaded += new RoutedEventHandler(KinectWindow_Loaded);
        }

        void KinectWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //if (DesignerProperties.GetIsInDesignMode(this))
            //    return;
            Compose();
        }

        private void Compose()
        {
            try
            {
                AssemblyCatalog aslog = new AssemblyCatalog(this.GetType().Assembly);
                DirectoryCatalog dlog = new DirectoryCatalog(AppDomain.CurrentDomain.BaseDirectory);
                AggregateCatalog alog = new AggregateCatalog(dlog, aslog);
                CompositionContainer container = new CompositionContainer(alog);
                container.ComposeParts(this);
            }
            catch (Exception ex)
            {
            }
        }

        private void InitializeNavigation()
        {
            Frame frame = this.FindVisualChild<Frame>();
            NavigationManager.NavigationService = frame.NavigationService;
        }

        public void OnImportsSatisfied()
        {            
            InitializeNavigation();
            this.DataContext = BootStrapper.DefaultViewModel;
            var defaultView = BootStrapper.DefaultView;
            if (defaultView != null)
                NavigationManager.NavigateTo(defaultView);
        }
    }
}
