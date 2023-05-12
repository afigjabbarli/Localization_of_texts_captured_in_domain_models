using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Client.Commands;
using TaskManagement.Common;
using TaskManagement.Contants;
using TaskManagement.Database.Models;
using TaskManagement.Infrastructure;
using TaskManagement.Services;

namespace TaskManagement.Client
{
    public class ClientDashboard : IDashboard
    {
        public void Introduction()
        {
            Console.WriteLine($"{LocalizationService.GetTranslation(TranslationKey.Hello_User)}  <<{UserService.CurrentUser.LastName} {UserService.CurrentUser.Name}>> {LocalizationService.GetTranslation(TranslationKey.Welcome_User_Menu)}");
            Console.WriteLine();
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Update_Settings_Command));
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Close_Account_Command));
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Message_Management));
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Blog_Management));
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Exit));
            Console.WriteLine();
            if (LocalizationService.CurrentCulture.Equals(SupportedCulture.Eng))
            {
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

            if (LocalizationService.CurrentCulture.Equals(SupportedCulture.Aze))
            {
                while (true)
                {
                    Console.Write("Emr:"); string command = Console.ReadLine()!;
                    switch (command)
                    {
                        case "Parametrleri yenilemek":
                            CommandRouter.Route<UpdateSettingsCommand>();
                            break;
                        case "Hesabi baghlamaq":
                            CommandRouter.Route<CloseAccountCommand>();
                            break;
                        case "Mesajlarin idare olunmasi paneli":
                            CommandRouter.Route<MessageManagementPanel>();
                            break;
                        case "Bloglarin idare olunmasi paneli":
                            CommandRouter.Route<BlogManagementPanel>();
                            break;
                        case "Chıxish":
                            return;
                        default:
                            Console.WriteLine("Bu emr menyuda yoxdur! Lutfen, yeniden daxil olun...");
                            break;
                    }
                }
            }

            if (LocalizationService.CurrentCulture.Equals(SupportedCulture.Rus))
            {
                while (true)
                {
                    Console.Write("команда:"); string command = Console.ReadLine()!;
                    switch (command)
                    {
                        case "Команда обновления настроек":
                            CommandRouter.Route<UpdateSettingsCommand>();
                            break;
                        case "Команда закрытия учетной записи":
                            CommandRouter.Route<CloseAccountCommand>();
                            break;
                        case "Панель управления сообщениями":
                            CommandRouter.Route<MessageManagementPanel>();
                            break;
                        case "Панель управления блогом":
                            CommandRouter.Route<BlogManagementPanel>();
                            break;
                        case "Выход":
                            return;
                        default:
                            Console.WriteLine("Этой команды нет в меню! Пожалуйста, введите еще раз...");
                            break;
                    }
                }


            }
                     
            

























        }
    }
}
