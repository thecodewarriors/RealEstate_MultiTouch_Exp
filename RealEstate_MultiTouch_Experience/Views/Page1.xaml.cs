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
    [ViewExport("page1",true)]
    public partial class Page1 : View
    {
        public Page1()
        {
            InitializeComponent();
            Loaded += new RoutedEventHandler(Page1_Loaded);
        }

        void Page1_Loaded(object sender, RoutedEventArgs e)
        {
            var v = this.DataContext;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.NavigateTo("page2");
        }
    }
}
