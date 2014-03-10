using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPF.Framework
{
    public interface INavigationService
    {
        void NavigateTo(string viewName);
        void NavigateTo(object viewObject);
        void Back();
    }
}
