using System.Collections;
using TaskManagement.Admin.BlogManagement;
using TaskManagement.Common.Commands;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Infrastructure;
using TaskManagement.Services;

namespace TaskManagement
{
    public class Program
    {

        public void Main(string[] args)
        {
            Console.WriteLine("Please choose one of the commands shown on the screen.");
            Console.WriteLine();
            Console.WriteLine("Register");
            Console.WriteLine("Login");
            Console.WriteLine("Update-language");
            Console.WriteLine("Exit");
            
            while (true)
            {
                Console.Write("Command:"); string command = Console.ReadLine()!;
                switch (command)
                {
                    case "Register":
                        CommandRouter.Route<RegisterCommand>();
                        break;
                    case "Login":
                        CommandRouter.Route<LoginCommand>();
                        break;
                    case "Update-language":
                        CommandRouter.Route<UpdateLanguageCommand>();
                        break;
                    case "Exit":
                        Console.WriteLine("Bye-bye");
                        return;
                    default:
                        Console.WriteLine("Invalid command, pls try again");
                        break;
                }
                 
            }
        }
    }
}
