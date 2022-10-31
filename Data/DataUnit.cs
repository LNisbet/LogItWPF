using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WpfLogIt.Data
{
    public class DataUnit : IDataUnit, INotifyPropertyChanged
    {
        private int id;
        private string date = "";
        private string unit = "";
        private string data = "";
        private string comments = "";

        public DataUnit(int id, string date, string unit, string data, string comments)
        {
            ID = id;
            Date = date;
            Unit = unit;
            Data = data;
            Comments = comments;
        }

        public int ID
        {
            get { return id; }
            set { id = value; OnPropertyChanged(); }
        }
        public string Date
        {
            get { return date; }
            set { if (value == null) { date = ""; } else { date = value; } OnPropertyChanged(); }
        }
        public string Unit
        {
            get { return unit; }
            set { if (value == null) { unit = ""; } else { unit = value; } OnPropertyChanged(); }
        }
        public string Data
        {
            get { return data; }
            set { if (value == null) { data = ""; } else { data = value; } OnPropertyChanged(); }
        }
        public string Comments
        {
            get { return comments; }
            set { if (value == null) { comments = ""; } else { comments = value; } OnPropertyChanged(); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
