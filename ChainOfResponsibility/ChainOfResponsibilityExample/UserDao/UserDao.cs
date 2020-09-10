using ChainOfResponsibilityExamlpe.Entities;
using DaoContracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace UserDao
{
    public class UserDao : IDao<User>
    {
        private List<User> _users = null;

        public UserDao()
        {
            StartUp();
        }

        public void StartUp()
        {
            _users = new List<User>();
        }

        public WorkDataResult<User> Add(User user)
        {
            var result = new WorkDataResult<User>();

            try
            {
                _users.Add(user);

                result.IsSucces = true;
                result.Data = user;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                result.IsSucces = false;
                result.Data = null;
            }

            return result;
        }

        public WorkDataResult<User> Get(int index)
        {
            var result = new WorkDataResult<User>();

            try
            {
                var user = _users[index];

                result.IsSucces = true;
                result.Data = user;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                result.IsSucces = false;
                result.Data = null;
            }

            return result;
        }

        public WorkDataResult<User> Remove(User item)
        {
            var result = new WorkDataResult<User>();

            try
            {
                _users.Remove(item);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                result.IsSucces = false;
                result.Data = null;
            }

            return result;
        }

        public WorkDataResult<User> Update(User targetItem, User newItem)
        {
            var result = new WorkDataResult<User>();

            try
            {
                _users[_users.IndexOf(targetItem)] = newItem;

                result.Data = newItem;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                result.IsSucces = false;
                result.Data = null;
            }

            return result;
        }
    }
}
