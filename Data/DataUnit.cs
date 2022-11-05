using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WpfLogIt.Data.Generic;

namespace WpfLogIt.Data
{
    public class DataUnit : IObject, INotifyPropertyChanged
    {
        private int id;
        private DateOnly date;
        private string unit;
        private string data;
        private string comments;

        public DataUnit(int id, DateOnly date, string unit, string data, string comments)
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
        public DateOnly Date
        {
            get { return date; }
            set { date = value; OnPropertyChanged(); }
        }
        public string Unit
        {
            get { return unit; }
            set { if (value == null) { throw new NullValueException("Unit can't be Null"); } else { unit = value; } OnPropertyChanged(); }
        }
        public string Data
        {
            get { return data; }
            set { if (value == null) { throw new NullValueException("Data can't be Null"); } else { data = value; } OnPropertyChanged(); }
        }
        public string Comments
        {
            get { return comments; }
            set { if (value == null) { throw new NullValueException("Comments can't be Null"); } else { comments = value; } OnPropertyChanged(); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
