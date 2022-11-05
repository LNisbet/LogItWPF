using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfLogIt.Data.Generic;

namespace WpfLogIt.Data
{
    internal class List_DataUnit : GenericList_IObject
    {

        private List<DataUnit> objects = new();
        public List_DataUnit(int id, string name, string discription, string colour) : base(id, name, discription, colour)
        {
        }
        public new List<DataUnit> Objects
        {
            get { return objects; }
            set { objects = value; OnPropertyChanged(); }
        }
    }
}
