using ExcahangeControlWork.WPF.Serialize;
using ExchangeControlWork.WPF.DTO;
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

namespace ExchangeControlWork.WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GetExchanged();
        }

        public void GetExchanged()
        {
            DeserializeService deserialize = new DeserializeService();
            var result = deserialize.GetJson();

            kursGrid.ItemsSource = result;
        }

        private void UpdateButton(object sender, RoutedEventArgs e)
        {
            GetExchanged();
        }
    }
}
