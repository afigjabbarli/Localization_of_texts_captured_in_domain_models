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
    public class Inbox : ICommandHandler
    {
        public void Handle()
        {
            Console.WriteLine();
            Console.WriteLine("List of received messages");
            Console.WriteLine();
            int currentRowNumber = 1;
            foreach(Message message in DataContext.Messages)
            {
                if(UserService.CurrentUser.Email.Equals(message.Receiver.Email))
                {
                    Console.WriteLine($"Message receiver fullname: <<{message.Sender.LastName} {message.Sender.Name}>>");
                    Console.WriteLine($"Message receiver email: {message.Sender.Email}");
                    Console.WriteLine($"Message subject: {message.Subject_Aze}");
                    Console.WriteLine($"Message created date: {message.CreatedAt}");
                    Console.WriteLine($"Message current row number: {currentRowNumber}");
                    currentRowNumber++;
                }
            }
            
            
            //MessageRepository messageRepository = new MessageRepository();
            //List<Message> messages = messageRepository.GetAll(m => m.Receiver == UserService.CurrentUser);

            //int currentRowNumber = 1;

            //foreach (Message message in messages)
            //{
            //    Console.WriteLine(
            //        $"{currentRowNumber}.{message.Sender.GetFullName()} {message.Sender.Email} | {message.Content_Aze} | {message.CreatedAt}");

            //    currentRowNumber++;
            //}


        }
    }
}
