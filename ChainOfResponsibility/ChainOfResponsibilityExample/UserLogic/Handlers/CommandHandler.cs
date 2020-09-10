using BLLContracts;
using ChainOfResponsibilityExamlpe.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserLogic.Handlers
{
    public class CommandHandler : IHandler<User>
    {
        private ILogic<User> _logic;

        public CommandHandler(ILogic<User> logic)
        {
            _logic = logic;
        }

        public Response<User> Handle(Request request)
        {
            switch (request.Command)
            {
                case "Add":
                    return _logic.Add(request.User);
                case "Delete":
                    return _logic.Remove(request.User);
                case "Update":
                    return _logic.Update(request.User, request.User);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
