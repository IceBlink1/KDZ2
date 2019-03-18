using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispensaryLibrary
{

    [Serializable]
    public class IllegalCloseInfoException : DispensaryLibException
    {
        public IllegalCloseInfoException() { }
        public IllegalCloseInfoException(string message) : base(message) { }
        public IllegalCloseInfoException(string message, Exception inner) : base(message, inner) { }
        protected IllegalCloseInfoException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
