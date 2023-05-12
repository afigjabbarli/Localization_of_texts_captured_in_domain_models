using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common.Commands;
using TaskManagement.Contants;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Services;

namespace TaskManagement.Admin.ShowUser
{
    public class ShowUserByEmailCommand : ICommandHandler
    {
        public void Handle()
        {
            UserRepository userRepository = new UserRepository();

            while (true)
            {
                try
                {
                    Console.Write(LocalizationService.GetTranslation(TranslationKey.Enter_Email)); string emailForSearch = Console.ReadLine()!;
                    User user = userRepository.GetUserOrDefaultByEmail(emailForSearch);
                    if (user == null)
                    {
                        Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Email_Not));
                        continue;
                    }

                    Console.WriteLine(user.GetShortInfo());
                    return;
                }
                catch
                {
                    Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Invalid_Input));
                }
            }

        }
    }
}
