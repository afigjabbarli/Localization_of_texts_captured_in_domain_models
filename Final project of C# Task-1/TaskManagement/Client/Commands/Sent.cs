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
    public class Sent:ICommandHandler
    {
        public void Handle()
        {
            Console.WriteLine();
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.List_Sen_Messages));
            Console.WriteLine();
            int currentRowNumber = 1;
            foreach (Message message in DataContext.Messages)
            {
                if(UserService.CurrentUser.Email.Equals(message.Sender.Email))
                {
                     Console.WriteLine($"{LocalizationService.GetTranslation(TranslationKey.Mes_Rec_FullName)} <<{message.Receiver.LastName} {message.Receiver.Name}>>");
                     Console.WriteLine($"{LocalizationService.GetTranslation(TranslationKey.Mes_Rec_Email)} {message.Receiver.Email}");
                     Console.WriteLine($"{LocalizationService.GetTranslation(TranslationKey.Mes_Cur_Row_Nmb)} {currentRowNumber}{LocalizationService.GetTranslation(TranslationKey.Mes_Subject)} {LocalizationService.DisplayingAllMessagesSubjectCurrentLanguage(TranslationKey.Subject, message.CreatedAt)}");
                     Console.WriteLine($"{LocalizationService.GetTranslation(TranslationKey.Mes_Crt_Dt)} {message.CreatedAt}");
                     Console.WriteLine($"{LocalizationService.GetTranslation(TranslationKey.Message_Id)} {message.Id}");
                     currentRowNumber++;
                     if(DataContext.Messages.Count == currentRowNumber)
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
            
        }
    }
}
