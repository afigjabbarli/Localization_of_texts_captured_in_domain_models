using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common.Commands;
using TaskManagement.Contants;
using TaskManagement.Infrastructure;
using TaskManagement.Services;

namespace TaskManagement.Client.Commands
{
    public class MessageManagementPanel: ICommandHandler
    {
        public void Handle()
        {
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Message_Management));
            Console.WriteLine();
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Inbox));
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Sent));
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Compose));
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Exit));
            Console.WriteLine();
            if (LocalizationService.CurrentCulture.Equals(SupportedCulture.Eng))
            {
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

            if (LocalizationService.CurrentCulture.Equals(SupportedCulture.Aze))
            {
                while (true)
                {
                    Console.Write("Emr"); string command = Console.ReadLine()!;
                    Console.WriteLine();
                    switch (command)
                    {
                        case "Gelenler qutusu":
                            CommandRouter.Route<Inbox>();
                            break;
                        case "Gonderildi":
                            CommandRouter.Route<Sent>();
                            break;
                        case "Yaz":
                            CommandRouter.Route<Compose>();
                            break;
                        case "Chıxish":
                            return;
                    }
                }
            }

            if (LocalizationService.CurrentCulture.Equals(SupportedCulture.Rus))
            {
                while (true)
                {
                    Console.Write("команда"); string command = Console.ReadLine()!;
                    Console.WriteLine();
                    switch (command)
                    {
                        case "Входящие":
                            CommandRouter.Route<Inbox>();
                            break;
                        case "Отправил":
                            CommandRouter.Route<Sent>();
                            break;
                        case "Написать":
                            CommandRouter.Route<Compose>();
                            break;
                        case "Выход":
                            return;
                    }
                }
            }








   


        }
    }
}
