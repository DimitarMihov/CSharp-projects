using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidRangeException
{
    public class InvalidRangeException<T> : Exception
    {
        public T StartRange { get; private set; }
        public T EndRange { get; private set; }
        
        public InvalidRangeException(string msg, T start, T end) :
            base(msg)
        {
            this.StartRange = start;
            this.EndRange = end;
        }
    }
}
