using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoContracts
{
    public class WorkDataResult<T>
    {
        public bool IsSucces { get; set; }
        public T Data { get; set; }
    }
}
