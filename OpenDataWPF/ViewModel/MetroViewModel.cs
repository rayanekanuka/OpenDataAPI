using OpenDataLibrary;
using OpenDataWPF.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace OpenDataWPF.ViewModel
{
    public class MetroViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double _lon;
        private double _lat;
        private int _radius;


        public MetroViewModel()
        {
            Longitude = 5.731369390899194;
            Latitude = 45.18447955700181;
            Radius = 500;
        }

        public double Longitude
        {
            get
            {
                return _lon;
            }
            set
            {
                if (_lon != value)
                {
                    _lon = value;
                    NotifyPropertyChanged("Longitude");
                }
            }
        }

        public double Latitude
        {
            get
            {
                return _lat;
            }
            set
            {
                if (_lat != value)
                {
                    _lat = value;
                    NotifyPropertyChanged("Latitude");
                }
            }
        }

        public int Radius
        {
            get { return _radius; }
            set
            {
                if (_radius != value)
                {
                    _radius = value;
                    NotifyPropertyChanged("Radius");
                }
            }
        }

        public void NotifyPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(name));
            }
        }

          
        private ICommand _loadCommand;
        public ICommand LoadCommand
        {
            get
            {
                if (_loadCommand == null)
                {
                    _loadCommand = new RelayCommand(o => DoOnLoad(), o => true);
                }
                return _loadCommand;
            }
            set { _loadCommand = value; }
        }

        private void DoOnLoad()
        {
            MetroAPI result = new MetroAPI();
            List<TransportLine> tag = result.GetLines(Latitude, Longitude, Radius);
            
            foreach (TransportLine line in tag)
            {
                _transportLines.Add(line);
            }

            //Console.WriteLine("To do call api..." + result.GetLines(Latitude, Longitude, Radius)[0].Name);
        }


        private ObservableCollection<TransportLine> _transportLines = new ObservableCollection<TransportLine>();
        public ObservableCollection<TransportLine> TransportLines
        {
            get
            {
                return _transportLines;
            }
            set
            {
                if (_transportLines != value)
                {
                    _transportLines = value;
                    NotifyPropertyChanged("TransportLines");
                }
            }
        }

    }

}

