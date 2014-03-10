using WPF.Framework;

namespace RealEstate_MultiTouch_Experience
{
    [ViewModelExport("MainViewModel", true)]
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            Name = "Page 11";
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                RaisePropertyChanged("Name");
            }
        }
    }
}
