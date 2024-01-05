using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OpenDataWPF.ViewModel
{
    public class MetroViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }

    private int _radius;
    public int Radius
    {
        get { return _radius; }
        set
        {
            _radius != value;
            NotifyPropertyChanged("Radius");
        }
    }

    public class MetroViewModel()
    {
        _radius = 400;
    }

    private void NotifyPropertyChanged(string name)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged (this,
                new PropertyChangedEventHandler(name);
        }
    }

}
