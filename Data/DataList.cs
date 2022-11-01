using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WpfLogIt.Data
{
    public class DataList : IDataList<DataUnit>
    {
        private int id;
        private string name = "";
        private string description = "";
        private string colour = "";
        private List<DataUnit> dataUnits = new();
        public DataList(int id, string name, string discription, string colour)
        {
            ID = id;
            Name = name;
            Description = discription;
            Colour = colour;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public List<DataUnit> DataUnits
        {
            get { return dataUnits; }
            set { dataUnits = value; }
        }

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
        }

        public DataUnit GetDataUnit(int id)
        {
            DataUnit dU = new(id,"","","","");
            if (dataUnits.Where((arg) => arg.ID == id).FirstOrDefault() != null)
            {
                dU = dataUnits.Where((arg) => arg.ID == id).FirstOrDefault();
            }
            return dU; 
        }
    }
}
