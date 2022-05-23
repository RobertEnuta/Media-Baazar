using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreApp
{
    public class EmptyStringExcption : Exception
    {
        public EmptyStringExcption() : base("You need to provide some information in the textbox")
        { }
    }
}
