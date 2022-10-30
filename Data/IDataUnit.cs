using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfLogIt.Data
{
    public interface IDataUnit
    {
        int ID { get; set; }
        string Date { get; set; }
        string Unit { get; set; }
        string Data { get; set; }
        string Comments { get; set; }
    }
}
