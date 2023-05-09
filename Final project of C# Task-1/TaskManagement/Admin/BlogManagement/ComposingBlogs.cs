using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Contants;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Services;

namespace TaskManagement.Admin.BlogManagement
{
    public class ComposingBlogs
    {
        public static void CreatingBlogsInAzerbaijaniLanguage()
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();

            Blog blog = new Blog(title, content, UserService.CurrentUser, BlogStatus.Created);
            blogRepository.Insert(blog);




        }

        public static void CreatingBlogsInRussianLanguage()
        {





        }

        public static void CreatingBlogsInEnglishLanguage()
        {





        }
    }
}
