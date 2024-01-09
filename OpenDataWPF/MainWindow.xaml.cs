using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OpenDataLibrary;
using OpenDataWPF.ViewModel;

namespace OpenDataWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MetroViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new MetroViewModel();
            // Le DataContext sert comme point de départ pour les chemins de Binding
            DataContext = _viewModel;
        }


        //    private void buttonGO_Click(object sender, RoutedEventArgs e)
        //    {
        //        MesageBox.Show($"Hello You {GetLines}");
        //    }
        //}

    }
}
