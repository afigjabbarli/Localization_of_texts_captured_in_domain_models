using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Admin.DePromoteFromAdmin;
using TaskManagement.Admin.MessageManagement;
using TaskManagement.Admin.ShowUser;
using TaskManagement.Admin.UserManagement;
using TaskManagement.Client.Commands;
using TaskManagement.Common;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Infrastructure;

namespace TaskManagement.Admin
{
    public class AdminDashboard : IDashboard
    {
        public void Introduction()
        {
            Console.WriteLine("Hello dear admin");
            Console.WriteLine();
            Console.WriteLine("Please choose one of the commands shown on the screen.");
            Console.WriteLine();
            Console.WriteLine("Show-users");
            Console.WriteLine("Show-user-by-email");
            Console.WriteLine("Show-user-by-id");
            Console.WriteLine("Add-user");
            Console.WriteLine("Promote-to-admin");
            Console.WriteLine("Depromote-from-admin");
            Console.WriteLine("Update-settings");
            Console.WriteLine("Remove-user");
            Console.WriteLine("Block-user");
            Console.WriteLine("Message-to");
            Console.WriteLine("Logout");
            while (true)
            {
                Console.Write("Command:" + " ");
                string command = Console.ReadLine()!;

                switch (command)
                {
                    case "Show-users":
                        CommandRouter.Route<ShowUsersCommand>();
                        break;
                    case "Show-user-by-email":
                        CommandRouter.Route<ShowUserByEmailCommand>();
                        break;
                    case "Show-user-by-id":
                        CommandRouter.Route<ShowUserByIdCommand>();
                        break;
                    case "Add-user":
                        CommandRouter.Route<AddUserCommand>();
                        break;
                    case "Promote-to-admin":
                        CommandRouter.Route<PromoteToAdminCommand>();
                        break;
                    case "Depromote-from-admin":
                        CommandRouter.Route<DePromoteFromAdminCommand>();   
                        break;
                    case "Update-settings":
                        CommandRouter.Route<UpdateSettingsCommand>();
                        break;
                    case "Remove-user":
                        CommandRouter.Route<RemoveUserCommand>();
                        break;
                    case "Block-user":
                        CommandRouter.Route<BanUserCommand>();
                        break;
                    case "Message-to":
                        CommandRouter.Route<SendMessageCommand>();
                        break;
                    case "Logout":
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
