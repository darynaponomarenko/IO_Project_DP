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
using System.Windows.Shapes;

namespace IO_Project_DP
{
    /// <summary>
    /// Interaction logic for BookAFlight.xaml
    /// </summary>
    public partial class BookAFlight : Window
    {
        public bool isPressSelecte { get; set; }
        public BookAFlight()
        {
            InitializeComponent();
        }

        private void btnSubmitAFlight_Click(object sender, RoutedEventArgs e)
        {
            isPressSelecte = true;
            this.Close();
        }
    }
}
