using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityExamlpe.Entities
{
    public class Request
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Command { get; set; }
        public User User { get; set; }
    }
}
