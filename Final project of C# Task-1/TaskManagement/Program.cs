using System.Collections;
using TaskManagement.Admin.BlogManagement;
using TaskManagement.Common.Commands;
using TaskManagement.Contants;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Infrastructure;
using TaskManagement.Services;

namespace TaskManagement
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.shownCommand));
            Console.WriteLine();
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.registerCommand));
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.loginCommand));
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.languageCommand));
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Exit));
            Console.WriteLine();

          if (LocalizationService.CurrentCulture.Equals(SupportedCulture.Eng))
          {

            while (true)
            {
                Console.Write("Command:"); string command = Console.ReadLine()!;
                switch (command)
                {
                    case "Register":
                        CommandRouter.Route<RegisterCommand>();
                        break;
                    case "Login":
                        CommandRouter.Route<LoginCommand>();
                        break;
                    case "Update language":
                        CommandRouter.Route<UpdateLanguageCommand>();
                        break;
                    case "Exit":
                        Console.WriteLine("Bye-bye");
                        return;
                    default:
                        Console.WriteLine("Invalid command, pls try again");
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
                        case "Регистр":
                            CommandRouter.Route<RegisterCommand>();
                            break;
                        case "Авторизоваться":
                            CommandRouter.Route<LoginCommand>();
                            break;
                        case "языковые опции":
                            CommandRouter.Route<UpdateLanguageCommand>();
                            break;
                        case "Выход":
                            Console.WriteLine("Пока-пока");
                            return;
                        default:
                            Console.WriteLine("Неверная команда, пожалуйста, попробуйте еще раз");
                            break;
                    }

                }

            }

            if(LocalizationService.CurrentCulture.Equals(SupportedCulture.Aze))
            {
                while (true)
                {
                    Console.Write("Emr:"); string command = Console.ReadLine()!;
                    switch (command)
                    {
                        case "Qeydiyyat":
                            CommandRouter.Route<RegisterCommand>();
                            break;
                        case "Girish":
                            CommandRouter.Route<LoginCommand>();
                            break;
                        case "Dil sechimleri":
                            CommandRouter.Route<UpdateLanguageCommand>();
                            break;
                        case "Chıxish":
                            Console.WriteLine("Sagh ol");
                            return;
                        default:
                            Console.WriteLine("Yanlısh emr, xahish edirem yeniden cehd edin");
                            break;
                    }

                }
            }
        }
    }
}
