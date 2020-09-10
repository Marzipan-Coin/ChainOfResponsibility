using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityExamlpe.Entities
{
    public class Response<T>
    {
        public T Data { get; set; }
        public bool IsSuccess { get; set; }
    }
}
