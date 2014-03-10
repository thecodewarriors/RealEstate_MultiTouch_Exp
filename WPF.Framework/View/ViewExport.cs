using System.ComponentModel.Composition;
using System;

namespace WPF.Framework
{
    [MetadataAttribute,AttributeUsage(AttributeTargets.Class,AllowMultiple=false,Inherited=false)]
    public class ViewExport : ExportAttribute,IViewInfo
    {

        public ViewExport(string alias, bool isDefault)
            : this(alias,isDefault, string.Empty,false)
        {
        }

        public ViewExport(string alias, bool isDefault, string dataContextAlias)
            : this(alias, isDefault, dataContextAlias, false)
        {
        }

        public ViewExport(string alias, bool isDefault, string dataContextAlias, bool createByDefault)
            : base(typeof(IView))
        {
            this.Alias = alias;
            this.IsDefault = isDefault;
            this.DataContextAlias = dataContextAlias;
            this.CreateByDefault = createByDefault;
        }

        public string Alias
        {
            get;
            set;
        }

        public bool IsDefault
        {
            get;set;
        }

        public bool CreateByDefault
        {
            get;
            set;
        }

        public string DataContextAlias
        {
            get;
            set;
        }
    }
}
