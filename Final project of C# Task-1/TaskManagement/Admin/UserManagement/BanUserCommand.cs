using TaskManagement.Common.Commands;
using TaskManagement.Contants;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Services;

namespace TaskManagement.Admin.UserManagement
{
    public class BanUserCommand : ICommandHandler
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
                Console.WriteLine($"{LocalizationService.GetTranslation(TranslationKey.Cant_Ban_Admin)} {user.GetShortInfo()}");
                return;
            }

            user.IsBanned = true;
        }
    }
}
