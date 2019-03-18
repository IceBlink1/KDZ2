using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispensaryLibrary
{

    [Serializable]
    public class IllegalCoordinateException : DispensaryLibException
    {
        public IllegalCoordinateException() { }
        public IllegalCoordinateException(string message) : base(message) { }
        public IllegalCoordinateException(string message, Exception inner) : base(message, inner) { }
        protected IllegalCoordinateException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
