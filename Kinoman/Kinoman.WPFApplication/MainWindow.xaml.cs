using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Kinoman.Entities.Common;
using Kinoman.Enums;
using Kinoman.Services;
using Kinoman.Services.Impl;
using Unity;

namespace Kinoman.WPFApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cmbCities.ItemsSource = Enum.GetValues(typeof(Cities));
        }
        private ObservableCollection<Showing> show;
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var container = new UnityContainer();
            if (cmbCities.SelectedValue != null)
            {
                var city = (Cities)cmbCities?.SelectedValue;
                container.RegisterType<IDownloadService, DownloadService>();
                container.RegisterType<IDeserializer, Deserializer>();
                container.RegisterType<IUrlProviderService, MultiKinoUrlProviderService>();
                container.RegisterType<IDataProviderService, DataProviderService>();
                container.RegisterType<ICommonDataService, MultiKinoToCommonDataService>();

                var commonTypeShowing = container.Resolve<ICommonDataService>();
                var result = await commonTypeShowing.GetCommonData(city);
                show = new ObservableCollection<Showing>();
                foreach (var item in result)
                {
                    show.Add(item);
                }
                ListView.ItemsSource = show;
            }
            else
            {
                MessageBox.Show("Please select a city","Error");

            }

            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         

        }
    }
}
