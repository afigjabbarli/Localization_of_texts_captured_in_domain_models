using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Contants;
using TaskManagement.Services;

namespace TaskManagement.Common.Commands
{
    public class UpdateLanguageCommand : ICommandHandler
    {
        public void Handle()
        {
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.ChooseLanguageCommand));
            Console.WriteLine($"<1> [{LocalizationService.GetTranslation(TranslationKey.AzeLanguage)}]");
            Console.WriteLine($"<2> [{LocalizationService.GetTranslation(TranslationKey.RusLanguage)}]");
            Console.WriteLine($"<3> [{LocalizationService.GetTranslation(TranslationKey.EngLanguage)}]");
            Console.WriteLine($"<4> [{LocalizationService.GetTranslation(TranslationKey.Exit)}]");
            Console.WriteLine();

            if(LocalizationService.CurrentCulture.Equals(SupportedCulture.Eng))
            while (true)
            {
                Console.Write("Language:" + " "); string language = Console.ReadLine()!;
                switch (language)
                {
                   case "English Language":
                   LocalizationService.CurrentCulture = SupportedCulture.Eng;
                   return;

                   case "Russian Language":
                   LocalizationService.CurrentCulture = SupportedCulture.Rus;
                   return;

                   case "Azerbaijani Language":
                   LocalizationService.CurrentCulture = SupportedCulture.Aze;
                   return;

                   case "Exit":
                   return;

                   default: Console.WriteLine("Invalid command, pls try again");
                   break;

                }

            }
                if (LocalizationService.CurrentCulture.Equals(SupportedCulture.Aze))
                while (true)
                {
                    Console.Write("Dil:" + " "); string language = Console.ReadLine()!;
                    switch (language)
                    {
                        case "Ingilis dili":
                            LocalizationService.CurrentCulture = SupportedCulture.Eng;
                            return;

                        case "Rus dili":
                            LocalizationService.CurrentCulture = SupportedCulture.Rus;
                            return;

                        case "Azərbaycan dili":
                            LocalizationService.CurrentCulture = SupportedCulture.Aze;
                            return;

                        case "Chixish":
                            return;

                        default:
                            Console.WriteLine("Yanlısh emr, xahish edirem yeniden cehd edin");
                            break;

                    }

                }
            if (LocalizationService.CurrentCulture.Equals(SupportedCulture.Rus))
                while (true)
                {
                    Console.Write("Язык:" + " "); string language = Console.ReadLine()!;
                    switch (language)
                    {
                        case "Английский язык":
                            LocalizationService.CurrentCulture = SupportedCulture.Eng;
                            return;

                        case "Русский язык":
                            LocalizationService.CurrentCulture = SupportedCulture.Rus;
                            return;

                        case "азербайджанский язык":
                            LocalizationService.CurrentCulture = SupportedCulture.Aze;
                            return;

                        case "Выйти":
                            return;

                        default:
                            Console.WriteLine("Неверная команда, пожалуйста, попробуйте еще раз");
                            break;

                    }

                }




        }
    }
}
