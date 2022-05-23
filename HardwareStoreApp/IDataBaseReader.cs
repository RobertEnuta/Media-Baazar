using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreApp
{
    interface IDataBaseReader
    {
        void Insert(object obj);
        Object ReadAll();
        void Delete(int id);
    }
}
