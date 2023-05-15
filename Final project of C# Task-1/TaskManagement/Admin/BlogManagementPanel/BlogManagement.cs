using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common.Commands;
using TaskManagement.Contants;
using TaskManagement.Infrastructure;
using TaskManagement.Services;

namespace TaskManagement.Admin.BlogManagement
{
    public class BlogManagement:ICommandHandler
    {
        public void Handle()
        {
            Console.WriteLine();
            Console.WriteLine(LocalizationService.GetTranslation(Contants.TranslationKey.Blog_Management_Panel));
            Console.WriteLine();
            Console.WriteLine($" <<1>> [{LocalizationService.GetTranslation(Contants.TranslationKey.Rej_Blog_Com)}]");
            Console.WriteLine($" <<2>> [{LocalizationService.GetTranslation(Contants.TranslationKey.App_Blog_Com)}]");
            Console.WriteLine($" <<3>> [{LocalizationService.GetTranslation(Contants.TranslationKey.Show_Crt_Blog_Com)}]");
            Console.WriteLine($" <<4>> [{LocalizationService.GetTranslation(Contants.TranslationKey.Exit)}]");
            Console.WriteLine();
            if(LocalizationService.CurrentCulture.Equals(SupportedCulture.Aze))
            while (true)
            {
            Console.WriteLine(LocalizationService.GetTranslation(Contants.TranslationKey.shownCommand));
            Console.Write(LocalizationService.GetTranslation(Contants.TranslationKey.InputCommand));string command = Console.ReadLine()!;
            switch (command)
            {
                case "Bloqlarin Tesdiq Edilmemesi":
                CommandRouter.Route<RejectBlogCommand>();
                break;
                case "Bloglarin Tesdiq Olunmasi":
                CommandRouter.Route<ApproveBlogCommand>();
                break;
                case "Yaradılmış Bloqlarin Gosterilmesi Komandasi":
                CommandRouter.Route<ShowCreatedBlogsCommand>();
                break;
                case "Chixish":
                return;
            }

            }

            if (LocalizationService.CurrentCulture.Equals(SupportedCulture.Rus))
                while (true)
                {
                    Console.WriteLine(LocalizationService.GetTranslation(Contants.TranslationKey.shownCommand));
                    Console.Write(LocalizationService.GetTranslation(Contants.TranslationKey.InputCommand)); string command = Console.ReadLine()!;
                    switch (command)
                    {
                        case "Отказ от блогов":
                            CommandRouter.Route<RejectBlogCommand>();
                            break;
                        case "Одобрение блогов":
                            CommandRouter.Route<ApproveBlogCommand>();
                            break;
                        case "Команда Показать созданные блоги":
                            CommandRouter.Route<ShowCreatedBlogsCommand>();
                            break;
                        case "Выход":
                            return;
                    }

                }

            if (LocalizationService.CurrentCulture.Equals(SupportedCulture.Eng))
                while (true)
                {
                    Console.WriteLine(LocalizationService.GetTranslation(Contants.TranslationKey.shownCommand));
                    Console.Write(LocalizationService.GetTranslation(Contants.TranslationKey.InputCommand)); string command = Console.ReadLine()!;
                    switch (command)
                    {
                        case "Reject Blog Command":
                            CommandRouter.Route<RejectBlogCommand>();
                            break;
                        case "Approve Blog Command":
                            CommandRouter.Route<ApproveBlogCommand>();
                            break;
                        case "Show Created Blogs Command":
                            CommandRouter.Route<ShowCreatedBlogsCommand>();
                            break;
                        case "Exit":
                            return;
                    }

                }

        }
    }
}
