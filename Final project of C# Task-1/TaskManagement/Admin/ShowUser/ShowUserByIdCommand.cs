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

namespace TaskManagement.Admin.ShowUser
{
    public class ShowUserByIdCommand : ICommandHandler
    {
        public void Handle()
        {
            UserRepository userRepository = new UserRepository();

            while (true)
            {
                try
                {
                    Console.Write(LocalizationService.GetTranslation(TranslationKey.Input_User_Id));
                    int id = int.Parse(Console.ReadLine()!);

                    User user = userRepository.GetById(id)!;
                    if (user == null)
                    {
                        Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.User_Not));
                        continue;
                    }

                    Console.WriteLine(user.GetShortInfo());
                }
                catch
                {
                    Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Invalid_Input));
                }
            }

        }
    }
}
