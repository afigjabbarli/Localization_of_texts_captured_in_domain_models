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
            Console.WriteLine("Update settings command");
            Console.WriteLine("Close Account Command");
            Console.WriteLine("Message Management Panel");
            Console.WriteLine("Blog Management Panel");
            Console.WriteLine("Add Blog Command");
            Console.WriteLine("Display of Created Blogs");
            Console.WriteLine("Exit");
            Console.WriteLine();
            while ( true )
            {
                Console.Write("Command:"); string command = Console.ReadLine()!;
                switch( command )
                {
                    case "Update settings command":
                    CommandRouter.Route<UpdateSettingsCommand>();
                    break;
                    case "Close Account Command":
                    CommandRouter.Route<CloseAccountCommand>();
                    break;
                    case "Message Management Panel":
                    CommandRouter.Route<MessageManagementPanel>();
                    break;
                    case "Blog Management Panel":
                    CommandRouter.Route<BlogManagementPanel>();
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
