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
    public class DataList : IDataList<DataUnit>
    {
        private int id;
        private string name;
        private string description;
        private string colour;
        private List<DataUnit> dataUnits = new();
        public DataList(int id, string name, string discription, string colour)
        {
            ID = id;
            Name = name;
            Description = discription;
            Colour = colour;
        }
        #region Get Set
        public int ID
        {
            get { return id; }
            set { id = value; OnPropertyChanged(); }
        }
        public string Name
        {
            get { return name; }
            set { if (value == null) { throw new NullValueException("Name"); } else { name = value; } OnPropertyChanged(); }
        }
        public string Description
        {
            get { return description; }
            set { if (value == null) { throw new NullValueException("Description"); } else { description = value; } OnPropertyChanged(); }
        }
        public string Colour
        {
            get { return colour; }
            set { if (value == null) { throw new NullValueException("Colour"); } else { colour = value; } OnPropertyChanged(); }
        }
        public List<DataUnit> DataUnits
        {
            get { return dataUnits; }
            set { dataUnits = value; OnPropertyChanged(); }
        }
        #endregion
        public void AddDataUnit(DataUnit dataUnit)
        {
            DataUnits.Add(dataUnit);
        }

        public void UpdateDataUnit(DataUnit dataUnit)
        {
            var oldDataUnit = dataUnits.Where((arg) => arg.ID == dataUnit.ID).FirstOrDefault();
            if (oldDataUnit != null) 
            {
                dataUnits.Remove(oldDataUnit);
            }
            dataUnits.Add(dataUnit);
        }

        public void DeleteDataUnit(int id)
        {
            var oldDataUnit = dataUnits.Where((arg) => arg.ID == id).FirstOrDefault();
            if (oldDataUnit != null)
            { 
                dataUnits.Remove(oldDataUnit);
            }
            ReorderIDs();
        }

        public DataUnit GetDataUnit(int id)
        {
            var dU = dataUnits.Where((arg) => arg.ID == id).FirstOrDefault();
            if (dU == null)
            {
                throw new NotImplementedException();
            }
            return dU; 
        }
        private void ReorderIDs()
        {
            int newID = 1;
            foreach (DataUnit dU in dataUnits)
            {
                dU.ID = newID;
                newID++;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
