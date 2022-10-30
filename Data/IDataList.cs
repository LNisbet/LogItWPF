using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfLogIt.Data
{
    public interface IDataList<T>
    {
        int ID { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string Colour { get; set; }
        void AddDataUnit(T dataUnit);
        void UpdateDataUnit(T dataUnit);
        void DeleteDataUnit(int id);
        T GetDataUnit(int id);
    }
}
