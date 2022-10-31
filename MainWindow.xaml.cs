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
        int ID = 0;
        string idUI = "0";
        DataList dataList1 = new(1, "test", "for testing", "blue");

        public MainWindow()
        {
            InitializeComponent();
            DataListBox.ItemsSource = dataList1.DataUnits;
        }

        private void ADD_Click(object sender, RoutedEventArgs e)
        {
            ID++;
            DataUnit dU = new(ID, "0", "kg", "1234", "");
            dataList1.AddDataUnit(dU);
        }

        private void TEST_Click(object sender, RoutedEventArgs e)
        {
            string text = "";
            foreach (DataUnit dU in dataList1.DataUnits)
            {
                text = text + " ," + Convert.ToString(dU.ID);
            }
            MessageBox.Show(text);
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            dataList1.DeleteDataUnit(Convert.ToInt32(idUI));
        }
    }
}
