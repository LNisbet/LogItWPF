using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace WpfLogIt.Data.Generic
{
    public class GenericList_IObject : IObjectList<IObject>, IObject
    {
        private int id;
        private string name;
        private string description;
        private string colour;
        private List<IObject> objects = new();
        public GenericList_IObject(int id, string name, string discription, string colour)
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
        public List<IObject> Objects
        {
            get { return objects; }
            set { objects = value; OnPropertyChanged(); }
        }
        #endregion
        public void AddObject(IObject obj)
        {
            Objects.Add(obj);
        }

        public void UpdateObject(IObject obj)
        {
            var oldObj = objects.Where((arg) => arg.ID == obj.ID).FirstOrDefault();
            if (oldObj != null)
            {
                objects.Remove(oldObj);
            }
            objects.Add(obj);
        }

        public void DeleteObject(int id)
        {
            var oldObj = objects.Where((arg) => arg.ID == id).FirstOrDefault();
            if (oldObj != null)
            {
                objects.Remove(oldObj);
            }
            ReorderIDs();
        }

        public IObject GetObject(int id)
        {
            var obj = objects.Where((arg) => arg.ID == id).FirstOrDefault();
            if (obj == null)
            {
                throw new NullValueException("No object with ID: " + Convert.ToString(id) + " in " + Name);
            }
            return obj;
        }
        private void ReorderIDs()
        {
            int newID = 1;
            foreach (IObject obj in objects)
            {
                obj.ID = newID;
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
