using System.Windows;
using System.Windows.Media;

namespace WPF.Framework
{
    public static class Helper
    {
        public static T FindVisualChild<T>(this DependencyObject root) where T : DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(root); i++)
            {
                DependencyObject element = VisualTreeHelper.GetChild(root, i);

                if (element != null && element is T)
                    return (T)element;
                else
                {
                    T t = FindVisualChild<T>(element);
                    if (t != null)
                        return t;
                }
            }
            return null;
        }
    }
}
