using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common.Commands;
using TaskManagement.Contants;
using TaskManagement.Database.Repositories;
using TaskManagement.Services;

namespace TaskManagement.Client.Commands
{
    public class CloseAccountCommand : ICommandHandler
    {
        public void Handle()
        {
            UserRepository userRepository = new UserRepository();

            Console.Write(LocalizationService.GetTranslation(Contants.TranslationKey.Enter_Email)); string password = Console.ReadLine()!;

            if (UserService.CurrentUser.Password != password)
            {
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Invalid_Password));
                return;
            }

            userRepository.Remove(UserService.CurrentUser);
        }
    }
}
