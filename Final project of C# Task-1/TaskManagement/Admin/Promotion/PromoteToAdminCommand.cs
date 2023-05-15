using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common.Commands;
using TaskManagement.Contants;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Services;
using TaskManagement.Services.JsonService;

namespace TaskManagement.Admin.DePromoteFromAdmin
{
    public class PromoteToAdminCommand : ICommandHandler
    {
        public void Handle()
        {
            UserRepository userRepository = new UserRepository();

            Console.Write(LocalizationService.GetTranslation(TranslationKey.Enter_Email)); string email = Console.ReadLine()!;
            User user = userRepository.GetUserOrDefaultByEmail(email);

            if (user == null)
            {
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.User_Not));
                return;
            }

            if (user.Role == UserRole.Admin)
            {
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Already_Admin));
                return;
            }

            user.Role = UserRole.Admin;
            DataOfSerializationAndDeserialization.UsersDataFromRamToFolder();

            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.From_User_To_Admin));
        }
    }
}
