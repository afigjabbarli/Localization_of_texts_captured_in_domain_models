using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common.Commands;
using TaskManagement.Infrastructure;

namespace TaskManagement.Client.Commands
{
    public class MessageManagementPanel: ICommandHandler
    {
        public void Handle()
        {
            Console.WriteLine("Message Management Panel");
            Console.WriteLine();
            Console.WriteLine("Inbox");
            Console.WriteLine("Sent");
            Console.WriteLine("Compose");
            Console.WriteLine("Exit");
            Console.WriteLine();
            while (true)
            {
                Console.Write("Command"); string command = Console.ReadLine()!;
                Console.WriteLine();
                switch (command)
                {
                    case "Inbox":
                        CommandRouter.Route<Inbox>();
                        break;
                    case "Sent":
                        CommandRouter.Route<Sent>();
                        break;
                    case "Compose":
                        CommandRouter.Route<Compose>();
                    break;
                    case "Exit":
                        return;
                }
            }

        }
    }
}
