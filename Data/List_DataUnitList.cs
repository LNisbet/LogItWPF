using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfLogIt.Data.Generic;

namespace WpfLogIt.Data
{
    internal class List_DataUnitList : GenericList_IObject
    {
        private List<List_DataUnit> objects = new();
        public List_DataUnitList(int id, string name, string discription, string colour) : base(id, name, discription, colour)
        {
        }
        public new List<List_DataUnit> Objects
        {
            get { return objects; }
            set { objects = value; OnPropertyChanged(); }
        }
    }
}
