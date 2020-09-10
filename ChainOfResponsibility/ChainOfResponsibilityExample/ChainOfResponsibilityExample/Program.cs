using ChainOfResponsibilityExamlpe.Entities;
using DI;
using System;

namespace ChainOfResponsibilityExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var sLocator = new ServiceLocator();

            var handler = sLocator.GetHandler();

            handler.Handle(new Request
            {
                Command = "Add",
                Login = "Admin",
                Password = "Admin",
                User = new User
                {
                    HasDocument = false,
                    Name = "Admin",
                    SecondName = "Adminovich",
                    UserId = Guid.NewGuid()
                }
            });


            Console.WriteLine("Hello World!");
        }
    }
}
