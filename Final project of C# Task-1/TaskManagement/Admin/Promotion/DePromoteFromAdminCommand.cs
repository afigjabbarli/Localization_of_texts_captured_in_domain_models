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
    public class DePromoteFromAdminCommand : ICommandHandler
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

            //if (email == UserService.CurrentUser.Email) 
            //{
            //    Console.WriteLine("You can't yourself");
            //    return;
            //}

            if (user == UserService.CurrentUser)
            {
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Cant_yourself));
                return;
            }

            if (user.Role == UserRole.Member)
            {
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Already_Standart));
                return;
            }

            user.Role = UserRole.Member;
            DataOfSerializationAndDeserialization.UsersDataFromRamToFolder();

            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.From_Admin_To_User));
        }
    }
}
