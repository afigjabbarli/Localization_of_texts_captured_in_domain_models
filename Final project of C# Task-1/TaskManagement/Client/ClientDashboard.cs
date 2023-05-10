using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Client.Commands;
using TaskManagement.Common;
using TaskManagement.Database.Models;
using TaskManagement.Infrastructure;
using TaskManagement.Services;

namespace TaskManagement.Client
{
    public class ClientDashboard : IDashboard
    {
        public void Introduction()
        {
            Console.WriteLine($"Hello! dear user : <<{UserService.CurrentUser.LastName} {UserService.CurrentUser.Name}>> welcome to the user menu...");
            Console.WriteLine();
            Console.WriteLine("Add Blog Command");
            Console.WriteLine("Close Account Command");
            Console.WriteLine("Show Messages Command");
            Console.WriteLine("Exit");
            Console.WriteLine();
            while ( true )
            {
                Console.Write("Command:"); string command = Console.ReadLine()!;
                switch( command )
                {
                    case "Add Blog Command":
                    CommandRouter.Route<AddBlogCommand>();
                    break;
                    case "Close Account Command":
                    CommandRouter.Route<CloseAccountCommand>();
                    break;
                    case "Show Messages Command":
                    CommandRouter.Route<ShowMessagesCommand>();
                    break;
                    case "Display of Created Blogs":
                    CommandRouter.Route<DisplayOfCreatedBlogs>();
                    break;
                    case "Exit":
                    return;
                    default: Console.WriteLine("This command is not in the menu! Please re-enter...");
                    break;












                }












            }

        }
    }
}
