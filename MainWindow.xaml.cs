using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using WpfLogIt.Data;

namespace WpfLogIt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataUnit dataUnit = new(0, "0", "kg", "1234", "");
        DataList dataList1 = new(1, "test", "for testing", "blue");
        public MainWindow()
        {
            InitializeComponent();
            DataListBox.ItemsSource = dataList1.DataUnits;
        }

        private void AddClickedAsync(object sender, RoutedEventArgs e)
        {
            dataUnit.ID++;
            dataList1.AddDataUnit(dataUnit);
        }
    }
}
