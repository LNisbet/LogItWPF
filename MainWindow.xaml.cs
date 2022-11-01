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
        public string IdUI { get; set; }

        private DateOnly dateUI;

        public string DateUI
        {
            get { return Convert.ToString(dateUI); }
            set { dateUI = DateOnly.Parse(value); }
        }
        public string UnitUI { get; set; }
        public string DataUI { get; set; }
        public string CommentsUI { get; set; }
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
            DataUnit dU = new(ID, dateUI, UnitUI, DataUI, CommentsUI);
            dataList1.AddDataUnit(dU);
        }

        private void TEST_Click(object sender, RoutedEventArgs e)
        {
            DataUnit dU = new(0, DateOnly.MinValue, "", "", "");
            foreach (DataUnit dU_ in dataList1.DataUnits)
            {
                if (dU_.ID == Convert.ToInt32(IdUI)) { dU = dU_; break; }
            }

            string text = Convert.ToString(dU.ID) + " ," + Convert.ToString(dU.Date) + " ," + dU.Unit + " ," + dU.Data + " ," + dU.Comments; ;

            MessageBox.Show(text);
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            dataList1.UpdateDataUnit(new DataUnit(Convert.ToInt32(IdUI), dateUI, UnitUI, DataUI, CommentsUI));
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            dataList1.DeleteDataUnit(Convert.ToInt32(IdUI));
        }
    }
}
