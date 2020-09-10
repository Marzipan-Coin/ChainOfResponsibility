using BLLContracts;
using ChainOfResponsibilityExamlpe.Entities;
using DaoContracts;
using System;
using UserDao;
using UserLogic.Handlers;

namespace DI
{
    public class ServiceLocator
    {
        private IDao<User> _dao;
        private ILogic<User> _logic;
        private IHandler<User> _handler;

        public IDao<User> GetDao()
        {
            if (_dao == null)
            {
                _dao = new UserDao.UserDao();
            }

            return _dao;
        }

        public ILogic<User> GetLogic()
        {
            if (_logic == null)
            {
                _logic = new UserLogic.UserLogic(GetDao());
            }

            return _logic;
        }

        public IHandler<User> GetHandler()
        {
            if (_handler == null)
            {
                var commandHandler = new CommandHandler(GetLogic());
                var validateResponseHandler = new ValidateResponseHandler(commandHandler);
                var validateHandler = new ValidateHandler(validateResponseHandler);
                var authenticationHandler = new AuthenticationHandler(validateHandler);
                var exceptionLoggerHandler = new ExceptionLogger(authenticationHandler);

                _handler = exceptionLoggerHandler;
            }

            return _handler;
        }
    }
}
