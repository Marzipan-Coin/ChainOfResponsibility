using System;
using System.Collections.Generic;

namespace DaoContracts
{
    public interface IDao<T>
    {
        WorkDataResult<T> Add(T item);
        WorkDataResult<T> Remove(T item);
        WorkDataResult<T> Get(int index);
        WorkDataResult<T> Update(T targetItem, T newItem);
    }
}
