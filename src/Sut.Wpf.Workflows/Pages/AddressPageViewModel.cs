using System.ComponentModel;
#if NETFX_45
using System.Runtime.CompilerServices;
#endif

namespace Sut.Wpf.Workflows.Pages
{
    public class AddressPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(
#if NETFX_45
            [CallerMemberName]
#endif
            string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}