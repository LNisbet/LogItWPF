using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfLogIt.Data
{
    public interface IData<T>
    {
        Task<bool> AddDataListAsync(string name, string discription, string colour);
        Task<bool> UpdateDataListAsync(T item);
        Task<bool> DeleteDataListAsync(int ID);
        Task<T> GetDataListAsync(int ID);
        Task<IEnumerable<T>> GetDataAsync(bool forceRefresh = false);
    }
    public interface IDataStore<T>
    {
        Task<bool> AddItemAsync(T DataList);
        Task<bool> UpdateItemAsync(T DataList);
        Task<bool> DeleteItemAsync(int ID);
        Task<T> GetItemAsync(int ID);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}
