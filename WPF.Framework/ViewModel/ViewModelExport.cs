using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace WPF.Framework
{
    [MetadataAttribute, AttributeUsage(AttributeTargets.Class,AllowMultiple = false, Inherited = false)]
    public class ViewModelExport : ExportAttribute, IViewModelInfo
    {
        public ViewModelExport(string alias, bool isDefault,  bool createByDefault)
            : base(typeof(IViewModel))
        {
            this.Alias = alias;
            this.IsDefault = isDefault;           
            this.CreateByDefault = createByDefault;
        }
         public ViewModelExport(string alias, bool isDefault)
            : this(alias,isDefault,false)
        {
        }

        public string Alias
        {
            get;
            set;
        }

        public bool IsDefault
        {
            get;
            set;
        }

        public bool CreateByDefault
        {
            get;
            set;
        }
    }
}
