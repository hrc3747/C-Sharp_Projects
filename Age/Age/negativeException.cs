using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class negativeException : Exception
    {
        public negativeException() : base() { }
        public negativeException(string message) : base(message) { }
    }
}
