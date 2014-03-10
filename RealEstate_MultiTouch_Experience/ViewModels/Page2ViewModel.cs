using WPF.Framework;

namespace RealEstate_MultiTouch_Experience
{
    [ViewModelExport("Page2ViewModel", false)]
    public class Page2ViewModel : ViewModelBase
    {
        public Page2ViewModel()
        {
            Name = "Page 222";
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; RaisePropertyChanged("Name"); }
        }

        public override void OnImportsSatisfied()
        {

        }
    }
}
