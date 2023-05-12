using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Admin.DePromoteFromAdmin;
using TaskManagement.Admin.MessageManagement;
using TaskManagement.Admin.ShowUser;
using TaskManagement.Admin.UserManagement;
using TaskManagement.Client.Commands;
using TaskManagement.Common;
using TaskManagement.Contants;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Infrastructure;
using TaskManagement.Services;

namespace TaskManagement.Admin
{
    public class AdminDashboard : IDashboard
    {
        public void Introduction()
        {
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Hello_Admin));
            Console.WriteLine();
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.shownCommand));
            Console.WriteLine();
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Show_Users));
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Show_Users_ByEmail));
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Show_Users_ById));
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Add_User));
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Promote_Admin));
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.DePromote_FromAdmin));
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Update_Settings));
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Remove_User));
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Block_User));
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Message_To));
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Logout));

            if (LocalizationService.CurrentCulture.Equals(SupportedCulture.Eng))
            {


            while (true)
            {
                Console.Write("Command:");
                string command = Console.ReadLine()!;

                switch (command)
                {
                    case "Show-users":
                        CommandRouter.Route<ShowUsersCommand>();
                        break;
                    case "Show-user-by-email":
                        CommandRouter.Route<ShowUserByEmailCommand>();
                        break;
                    case "Show-user-by-id":
                        CommandRouter.Route<ShowUserByIdCommand>();
                        break;
                    case "Add-user":
                        CommandRouter.Route<AddUserCommand>();
                        break;
                    case "Promote-to-admin":
                        CommandRouter.Route<PromoteToAdminCommand>();
                        break;
                    case "Depromote-from-admin":
                        CommandRouter.Route<DePromoteFromAdminCommand>();   
                        break;
                    case "Update-settings":
                        CommandRouter.Route<UpdateSettingsCommand>();
                        break;
                    case "Remove-user":
                        CommandRouter.Route<RemoveUserCommand>();
                        break;
                    case "Block-user":
                        CommandRouter.Route<BanUserCommand>();
                        break;
                    case "Message-to":
                        CommandRouter.Route<SendMessageCommand>();
                        break;
                    case "Logout":
                        Console.WriteLine("Bye-bye");
                        return;
                    default:
                        Console.WriteLine("Invalid command, pls try again");
                        break;
                }
            }

            }

            if (LocalizationService.CurrentCulture.Equals(SupportedCulture.Aze))
            {
                while (true)
                {
                    Console.Write("Emr:");
                    string command = Console.ReadLine()!;

                    switch (command)
                    {
                        case "Istifadechilerin gosterilmesi":
                            CommandRouter.Route<ShowUsersCommand>();
                            break;
                        case "Istifadechilerin emaile uyghun gosterilmesi":
                            CommandRouter.Route<ShowUserByEmailCommand>();
                            break;
                        case "Istifadechilerin identifikasiya koduna uyghun gosterilmesi":
                            CommandRouter.Route<ShowUserByIdCommand>();
                            break;
                        case "Istifadechi elave etmek":
                            CommandRouter.Route<AddUserCommand>();
                            break;
                        case "Istifadechinin admin olunmasi":
                            CommandRouter.Route<PromoteToAdminCommand>();
                            break;
                        case "Istifadechinin adminlikden chixarilmasi":
                            CommandRouter.Route<DePromoteFromAdminCommand>();
                            break;
                        case "Yeniləmə-parametrlər":
                            CommandRouter.Route<UpdateSettingsCommand>();
                            break;
                        case "Istifadechinin silinmesi":
                            CommandRouter.Route<RemoveUserCommand>();
                            break;
                        case "Istifadechinin bloklanmasi":
                            CommandRouter.Route<BanUserCommand>();
                            break;
                        case "Mesaj gonderilmesi":
                            CommandRouter.Route<SendMessageCommand>();
                            break;
                        case "Chıxısh":
                            Console.WriteLine("Sagh ol");
                            return;
                        default:
                            Console.WriteLine("Yanlış daxil edilmish melumat! Lütfen yeniden cehd edin");
                            break;
                    }
                }
            }

            if (LocalizationService.CurrentCulture.Equals(SupportedCulture.Rus))
            {

                while (true)
                {
                    Console.Write("команда:");
                    string command = Console.ReadLine()!;

                    switch (command)
                    {
                        case "показ пользователей":
                            CommandRouter.Route<ShowUsersCommand>();
                            break;
                        case "показ пользователей по электронной почте":
                            CommandRouter.Route<ShowUserByEmailCommand>();
                            break;
                        case "Отображение в соответствии с идентификационным кодом пользователя":
                            CommandRouter.Route<ShowUserByIdCommand>();
                            break;
                        case "Добавить пользователя":
                            CommandRouter.Route<AddUserCommand>();
                            break;
                        case "Делаем пользователя админом":
                            CommandRouter.Route<PromoteToAdminCommand>();
                            break;
                        case "Удаление пользователя из администрации":
                            CommandRouter.Route<DePromoteFromAdminCommand>();
                            break;
                        case "Обновить настройки":
                            CommandRouter.Route<UpdateSettingsCommand>();
                            break;
                        case "Удалить пользователя":
                            CommandRouter.Route<RemoveUserCommand>();
                            break;
                        case "Блокировать пользователя":
                            CommandRouter.Route<BanUserCommand>();
                            break;
                        case "Сообщение для":
                            CommandRouter.Route<SendMessageCommand>();
                            break;
                        case "Выйти":
                            Console.WriteLine("Пока-пока");
                            return;
                        default:
                            Console.WriteLine("Неверный ввод, пожалуйста, попробуйте еще раз");
                            break;
                    }
                }














            }
















        }
    }
}
