using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Admin.BlogManagement;
using TaskManagement.Common.Commands;
using TaskManagement.Contants;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Services;

namespace TaskManagement.Client.Commands
{
    public class AddBlogCommand : ICommandHandler
    {
        public void Handle()
        {
            BlogRepository blogRepository = new BlogRepository();
            Console.WriteLine("Blogs Menu");
            Console.WriteLine();
            Console.WriteLine("Please choose the appropriate language:");
            Console.WriteLine("<1> [Aze]");
            Console.WriteLine("<1> [Rus]");
            Console.WriteLine("<1> [Eng]");
            Console.WriteLine();
            string language = Console.ReadLine()!;
            switch (language)
            {
                case "Aze":
                ComposingBlogs.CreatingBlogsInAzerbaijaniLanguage();
                break;
                case "Rus":
                ComposingBlogs.CreatingBlogsInRussianLanguage();
                break;
                case "Eng":
                ComposingBlogs.CreatingBlogsInEnglishLanguage();
                break;
            }
        }
    }
}

           
