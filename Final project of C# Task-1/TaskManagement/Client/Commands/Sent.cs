using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common.Commands;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Services;

namespace TaskManagement.Client.Commands
{
    public class Sent:ICommandHandler
    {
        public void Handle()
        {
            Console.WriteLine();
            Console.WriteLine("List of sent messages");
            Console.WriteLine();
            int currentRowNumber = 1;
            foreach (Message message in DataContext.Messages)
            {
                if(UserService.CurrentUser.Email.Equals(message.Sender.Email))
                {
                     Console.WriteLine($"Message receiver fullname: <<{message.Receiver.LastName} {message.Receiver.Name}>>");
                     Console.WriteLine($"Message receiver email: {message.Receiver.Email}");
                     Console.WriteLine($"Message subject: {message.Subject_Aze}");
                     Console.WriteLine($"Message created date: {message.CreatedAt}");
                     Console.WriteLine($"Message current row number: {currentRowNumber}");
                     currentRowNumber++;
                }
            }
           
        }
    }
}
