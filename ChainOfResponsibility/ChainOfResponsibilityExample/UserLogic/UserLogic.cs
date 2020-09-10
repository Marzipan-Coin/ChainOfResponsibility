using BLLContracts;
using ChainOfResponsibilityExamlpe.Entities;
using DaoContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserLogic
{
    public class UserLogic : ILogic<User>
    {
        private IDao<User> _dao;

        public UserLogic(IDao<User> dao)
        {
            _dao = dao;
        }

        public Response<User> Add(User item)
        {
            var result = _dao.Add(item);

            return GetResponse(result);
        }

        public Response<User> Get(int index)
        {
            var result = _dao.Get(index);

            return GetResponse(result);
        }

        public Response<User> Remove(User item)
        {
            var result  = _dao.Remove(item);

            return GetResponse(result);
        }

        public Response<User> Update(User targetItem, User newItem)
        {
            var result = _dao.Update(targetItem, newItem);

            return GetResponse(result);
        }

        private static Response<User> GetResponse(WorkDataResult<User> result)
        {
            return new Response<User>
            {
                Data = result.Data,
                IsSuccess = result.IsSucces,
            };
        }
        
        private static Response<IEnumerable<User>> GetResponse(WorkDataResult<IEnumerable<User>> result)
        {
            return new Response<IEnumerable<User>>
            {
                Data = result.Data,
                IsSuccess = result.IsSucces,
            };
        }
    }
}
