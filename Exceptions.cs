using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfLogIt
{

    [Serializable]
    public class NullValueException : Exception
    {
        public NullValueException() { }
        public NullValueException(string message) : base(message) { MessageBox.Show(message + "can not be Null"); }
        public NullValueException(string message, Exception inner) : base(message, inner) { }
        protected NullValueException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
