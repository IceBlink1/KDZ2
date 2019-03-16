using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispensaryLibrary
{

    [Serializable]
    public class IllegalDistrictException : IllegalLocationInfoException
    {
        public IllegalDistrictException() { }
        public IllegalDistrictException(string message) : base(message) { }
        public IllegalDistrictException(string message, Exception inner) : base(message, inner) { }
        protected IllegalDistrictException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
