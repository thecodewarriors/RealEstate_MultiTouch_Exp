using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF.Framework;

namespace RealEstate_MultiTouch_Experience
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    [ViewExport("page2", false, "Page2ViewModel")]
    public partial class Page2 : View
    {
        public Page2()
        {
            InitializeComponent();
            Loaded += new RoutedEventHandler(Page2_Loaded);
        }

        void Page2_Loaded(object sender, RoutedEventArgs e)
        {
            var d = this.DataContext;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.Back();            
        }
    }
}
