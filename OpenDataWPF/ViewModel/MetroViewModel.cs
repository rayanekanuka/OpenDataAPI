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
        private ObservableCollection<TransportLine> LineData { get; set; }
        //public List<TransportLine> GetLines = new List<TransportLine>();


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
                    NotifyPropertyChanged("Longitude changée");
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
                    NotifyPropertyChanged("Latitude changée");
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
                    NotifyPropertyChanged("Rayon changé");
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
                    _loadCommand = new RelayCommand(o=>DoOnLoad(), o=>true);
                } 
                return _loadCommand;
            }
            set { _loadCommand = value; }
        }

        private void DoOnLoad()
        {
            Console.WriteLine("To do call api...");
        }

        //public string AccessData()
        //{
        //    ObservableCollection<TransportLine> ShowLines = new ObservableCollection<TransportLine>();

        //    return ShowLines;
        //}

        //ItemsSource="{Binding Source={StaticResource TransportLine}}"

    }
    
}
