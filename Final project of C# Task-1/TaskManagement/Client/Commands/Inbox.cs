using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common.Commands;
using TaskManagement.Contants;
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
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.List_Rec_Messages));
            Console.WriteLine();
            int currentRowNumber = 0;
            foreach(Message message in DataContext.Messages)
            {
                if(UserService.CurrentUser.Email.Equals(message.Receiver.Email))
                {
                    Console.WriteLine($" {LocalizationService.GetTranslation(TranslationKey.Mes_Sen_FullName)} <<{message.Sender.LastName} {message.Sender.Name}>>");
                    Console.WriteLine($" {LocalizationService.GetTranslation(TranslationKey.Mes_Sen_Email)} {message.Sender.Email}");
                    Console.WriteLine($" {LocalizationService.GetTranslation(TranslationKey.Mes_Subject)} {message.Subject_Aze}");
                    Console.WriteLine($" {LocalizationService.GetTranslation(TranslationKey.Mes_Crt_Dt)} {message.CreatedAt}");
                    Console.WriteLine($" {LocalizationService.GetTranslation(TranslationKey.Mes_Cur_Row_Nmb)} {currentRowNumber}");
                    currentRowNumber++;
                    if (DataContext.Messages.Count == currentRowNumber)
                    {
                        Console.WriteLine();
                        Console.Write("Please enter the message`s ID:");
                        int MessageId = int.Parse(Console.ReadLine()!);
                        Console.WriteLine();
                        Console.WriteLine($" Message`s subject:{LocalizationService.DisplayingMessagesSubjectCurrentLanguage(TranslationKey.Subject, MessageId)}");
                        Console.WriteLine($" Message`s content:{LocalizationService.DisplayingMessagesContentCurrentLanguage(TranslationKey.Content, MessageId)}");



                    }
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
