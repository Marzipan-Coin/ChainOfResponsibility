using BLLContracts;
using ChainOfResponsibilityExamlpe.Entities;
using System;

namespace UserLogic.Handlers
{
    public class AuthenticationHandler : IHandler<User>
    {
        private IHandler<User> _handler;

        public AuthenticationHandler(IHandler<User> handler)
        {
            _handler = handler;
        }

        public Response<User> Handle(Request request)
        {
            if (request.Login == "Admin" && request.Password == "Admin")
            {
                return _handler.Handle(request);
            }

            throw new UnauthorizedAccessException();
        }
    }
}
