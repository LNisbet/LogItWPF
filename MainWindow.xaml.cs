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
        public string idUI { get; set; }
        public string dateUI { get; set; }
        public string unitUI { get; set; }
        public string dataUI { get; set; }
        public string commentsUI { get; set; }
DataList dataList1 = new(1, "test", "for testing", "blue");

        public MainWindow()
        {
            InitializeComponent();
            DataListBox.ItemsSource = dataList1.DataUnits;
            idUITBox.DataContext = this;
            dataUITBox.DataContext = this;
            unitUITBox.DataContext = this;
            dateUITBox.DataContext = this;
            commentsUITBox.DataContext = this;
        }

        private void ADD_Click(object sender, RoutedEventArgs e)
        {
            ID++;
            DataUnit dU = new(ID, dateUI, unitUI, dataUI, commentsUI);
            dataList1.AddDataUnit(dU);
        }

        private void TEST_Click(object sender, RoutedEventArgs e)
        {
            DataUnit dU = new(0, "", "", "", "");
            foreach (DataUnit dU_ in dataList1.DataUnits)
            {
                if (dU_.ID == Convert.ToInt32(idUI)) { dU = dU_; break; }
            }

            string text = Convert.ToString(dU.ID) + " ," + dU.Date + " ," + dU.Unit + " ," + dU.Data + " ," + dU.Comments; ;

            MessageBox.Show(text);
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            dataList1.UpdateDataUnit(new DataUnit(Convert.ToInt32(idUI), dateUI, unitUI, dataUI, commentsUI));
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            dataList1.DeleteDataUnit(Convert.ToInt32(idUI));
        }
    }
}
