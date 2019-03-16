using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispensaryLibrary
{

    [Serializable]
    public class IllegalDateException : DispensaryLibException
    {
        public IllegalDateException() { }
        public IllegalDateException(string message) : base(message) { }
        public IllegalDateException(string message, Exception inner) : base(message, inner) { }
        protected IllegalDateException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
