using ChainOfResponsibilityExamlpe.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLLContracts
{
    public interface ILogic<T>
    {
        Response<T> Add(T item);
        Response<T> Remove(T item);
        Response<T> Get(int index);
        Response<T> Update(T targetItem, T newItem);
    }
}
