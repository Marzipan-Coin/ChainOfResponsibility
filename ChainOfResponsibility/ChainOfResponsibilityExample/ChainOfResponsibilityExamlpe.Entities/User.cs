using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExamlpe.Entities
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public bool HasDocument { get; set; }
        public int DocNumber { get; set; }
        public string DocName { get; set; }
    }
}
