using ChainOfResponsibilityExamlpe.Entities;
using System;

namespace BLLContracts
{
    public interface IHandler<T>
    {
        Response<T> Handle(Request request);
    }
}
