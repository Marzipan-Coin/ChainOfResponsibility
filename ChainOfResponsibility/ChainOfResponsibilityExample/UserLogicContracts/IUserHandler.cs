using ChainOfResponsibilityExamlpe.Entities;

namespace UserLogicContracts
{
    public interface IUserHandler
    {
        IUserHandler HandleUser(Request request);
    }
}
