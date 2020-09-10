using BLLContracts;
using ChainOfResponsibilityExamlpe.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserLogic.Handlers
{
    public class ValidateHandler : IHandler<User>
    {
        private IHandler<User> _handler;

        public ValidateHandler(IHandler<User> handler)
        {
            _handler = handler;
        }

        public Response<User> Handle(Request request)
        {
            if (request.User.HasDocument)
            {
                if (request.User.DocNumber == 1234)
                {
                    if (request.User.DocName == "Pasport")
                    {
                        return _handler.Handle(request);
                    }
                }
            }

            throw new ArgumentException();
        }
    }
}
