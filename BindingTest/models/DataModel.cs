using System.ComponentModel;
using System.Runtime.InteropServices;

namespace BindingTest.models
{
    class DataModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private bool _Checked = false;
        public bool Checked
        {
            get { return _Checked; }
            set
            {
                if (_Checked != value)
                {
                    _Checked = value;
                    OnPropertyChanged("Checked");
                }
            }
        }

        public void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                try
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(name));
                }
                catch (COMException) { }
            }
        }
    }
}
