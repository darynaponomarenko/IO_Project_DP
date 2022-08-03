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

namespace IO_Project_DP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        DataBase dataBase = new();
        public MainWindow()
        {
            InitializeComponent();
            dataBase.ConectAndShowFlights();
            DG.ItemsSource = Flight.flightList;
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            var widow = new BookAFlight();
            var flight = new Flight();
            widow.DataContext = flight;
            widow.ShowDialog();
            if (widow.isPressSelecte)
            {
                dataBase.InsertNewFlight(flight.name, flight.surname, flight.from, flight.to, flight.date, flight.seat, flight.clas);
                Flight.flightList.Clear();
                dataBase.ConectAndShowFlights();
                DG.Items.Refresh();
            }
        }

        private void Button_Edit(object sender, RoutedEventArgs e)
        {
            if (DG.SelectedItem != null)
            {
                var window = new BookAFlight();
                var flight = new Flight((Flight)DG.SelectedItem);
                window.DataContext = flight;
                window.ShowDialog();
                if (window.isPressSelecte)
                {
                    int index = Flight.flightList.IndexOf(DG.SelectedItem as Flight);
                    dataBase.UpdateFlight(flight.id, flight.name, flight.surname, flight.from, flight.to, flight.date, flight.seat, flight.clas);
                    Flight.flightList[index] = flight;
                    DG.Items.Refresh();
                }
            }
        }     

        private void Button_Delete(object sender, RoutedEventArgs e)
        {
            int index = Flight.flightList.IndexOf(DG.SelectedItem as Flight);
            var flight = new Flight((Flight)DG.SelectedItem);
            dataBase.DEleteFlight(flight.id);
            Flight.flightList.RemoveAt(index);
            DG.Items.Refresh();
        }
    }
}
