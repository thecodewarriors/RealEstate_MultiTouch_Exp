using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPF.Framework
{
    public interface IViewModel
    {
        IViewModelInfo ViewModelInfo { get; }
        BootStrapper BootStrapper{get; }
    }
}
