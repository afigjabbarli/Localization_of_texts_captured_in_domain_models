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
            Console.WriteLine("Please choose the appropriate language:");
            Console.WriteLine("<1> [English Language]");
            Console.WriteLine("<2> [Russian Language]");
            Console.WriteLine("<3> [Azerbaijani Language]");
            Console.WriteLine("<4> [Exit]");
            Console.WriteLine();
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

            


        }
    }
}
