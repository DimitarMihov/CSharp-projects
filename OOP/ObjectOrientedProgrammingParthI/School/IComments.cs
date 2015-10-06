using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public interface IComments
    {
        string SetComment { get;  set; }

        void PrintComment(string comment = null);
    }
}
