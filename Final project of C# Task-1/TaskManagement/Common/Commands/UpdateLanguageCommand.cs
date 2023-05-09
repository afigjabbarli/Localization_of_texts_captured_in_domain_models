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
            string language = Console.ReadLine()!;

            if (language == "english")
            {
                LocalizationService.CurrentCulture = SupportedCulture.Eng;
            }
            else if (language == "russian")
            {
                LocalizationService.CurrentCulture = SupportedCulture.Rus;
            }
            else
            {
                LocalizationService.CurrentCulture = SupportedCulture.Aze;
            }


        }
    }
}
