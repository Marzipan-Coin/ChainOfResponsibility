using BLLContracts;
using ChainOfResponsibilityExamlpe.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserLogic.Handlers
{
    public class ExceptionLogger : IHandler<User>
    {
        private IHandler<User> _handler;

        public ExceptionLogger(IHandler<User> handler)
        {
            _handler = handler;
        }

        public Response<User> Handle(Request request)
        {
            Response<User> result = null;

            try
            {
                result = _handler.Handle(request);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }
    }
}
