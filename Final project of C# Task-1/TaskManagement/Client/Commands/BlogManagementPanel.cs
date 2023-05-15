using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common.Commands;
using TaskManagement.Contants;
using TaskManagement.Infrastructure;
using TaskManagement.Services;

namespace TaskManagement.Client.Commands
{
    public class BlogManagementPanel:ICommandHandler
    {
        public void Handle()
        {
            Console.WriteLine(LocalizationService.GetTranslation(Contants.TranslationKey.Blog_Management_Panel));
            Console.WriteLine();
            Console.WriteLine("Add Blog Command");
            Console.WriteLine("Display of Created Blogs");
            Console.WriteLine("Add Comment");
            Console.WriteLine("Exit");
            Console.WriteLine();
            if(LocalizationService.CurrentCulture.Equals(SupportedCulture.Eng))
            while (true)
            {
                Console.Write("Command:" + " "); string command = Console.ReadLine()!;
                Console.WriteLine();
                switch (command)
                {
                    case "Add Blog Command":
                        CommandRouter.Route<AddBlogCommand>();
                        break;
                    case "Display of Created Blogs":
                        CommandRouter.Route<DisplayOfCreatedBlogs>();
                        break;
                    case "Add Comment":
                        CommandRouter.Route<AddComment>();
                        break;
                    case "Exit":
                        return;
                }
            }
            if (LocalizationService.CurrentCulture.Equals(SupportedCulture.Aze))
                while (true)
                {
                    Console.Write("Emr:" + " "); string command = Console.ReadLine()!;
                    Console.WriteLine();
                    switch (command)
                    {
                        case "Blog elave edin":
                            CommandRouter.Route<AddBlogCommand>();
                            break;
                        case "Yaradılmısh Bloqların Gosterilmesi":
                            CommandRouter.Route<DisplayOfCreatedBlogs>();
                            break;
                        case "Sherh elave et":
                            CommandRouter.Route<AddComment>();
                            break;
                        case "Chixish":
                            return;
                    }
                }

            if (LocalizationService.CurrentCulture.Equals(SupportedCulture.Rus))
                while (true)
                {
                    Console.Write("команда:" + " "); string command = Console.ReadLine()!;
                    Console.WriteLine();
                    switch (command)
                    {
                        case "Добавить блог":
                            CommandRouter.Route<AddBlogCommand>();
                            break;
                        case "Отображение созданных блогов":
                            CommandRouter.Route<DisplayOfCreatedBlogs>();
                            break;
                        case "Добавить комментарий":
                            CommandRouter.Route<AddComment>();
                            break;
                        case "Выход":
                            return;
                    }
                }
        }
    }


}
