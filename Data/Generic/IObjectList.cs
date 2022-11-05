using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfLogIt.Data.Generic
{
    public interface IObjectList<T>
    {
        int ID { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string Colour { get; set; }
        void AddObject(T obj);
        void UpdateObject(T obj);
        void DeleteObject(int id);
        T GetObject(int id);
    }
}
