using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Filmfestival.misc
{
    public class BindableBase : INotifyPropertyChanged
    {
        public void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        //INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
