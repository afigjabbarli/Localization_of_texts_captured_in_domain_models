using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common.Commands;
using TaskManagement.Contants;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Services;

namespace TaskManagement.Client.Commands
{
    public class DisplayOfCreatedBlogs:ICommandHandler
    {
        public void Handle()
        {
            Console.WriteLine("Different Blogs From All Over The World");
            Console.WriteLine();
            foreach(Blog blog in DataContext.Blogs)
            {
                Console.WriteLine($"Blog`s number: {blog.Id}");
                Console.WriteLine($"Blog`s author: {blog.Owner.LastName} {blog.Owner.Name}");
                Console.WriteLine($"Contact the author: {blog.Owner.Email}");    
                Console.WriteLine($"Blog`s creation date: {blog.CreatedAt}");
                while (true)
                {
                  Console.WriteLine();
                  Console.Write("Please enter the blog`s number:");
                  int blogId = int.Parse(Console.ReadLine()!);
                  Console.WriteLine();
                  Console.WriteLine($"Blog`s title: {LocalizationService.DisplayingBlogsTitleCurrentLanguage(TranslationKey.Title, blogId)}");
                  Console.WriteLine($"Blog`s content: {LocalizationService.DisplayingBlogsContentCurrentLanguage(TranslationKey.Content, blogId)}");
                }
            }
        }
    }

}
                
