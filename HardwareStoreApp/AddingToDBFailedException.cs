using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreApp
{
    class AddingToDBFailedException:Exception
    {
        public AddingToDBFailedException(Employee u) : base($"Something went wront in the DB, user {u} could not be added, try again")
        { }
    }
}
