using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WpfLogIt.Data
{
    public class DataStore : IDataStore<DataUnit>
    {
        readonly List<DataUnit> DataList;

        public async Task<bool> AddItemAsync(DataUnit dataUnit)
        {
            DataList.Add(dataUnit);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(DataUnit item)
        {
            var oldItem = DataList.Where((arg) => arg.ID == item.ID).FirstOrDefault();
            DataList.Remove(oldItem);
            DataList.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            var oldItem = DataList.Where((arg) => arg.ID == id).FirstOrDefault();
            DataList.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<DataUnit> GetItemAsync(int id)
        {
            return await Task.FromResult(DataList.FirstOrDefault(s => s.ID == id));
        }

        public async Task<IEnumerable<DataUnit>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(DataList);
        }
    }
}