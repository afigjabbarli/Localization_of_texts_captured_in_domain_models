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
            int RowNumber = 1;  
            foreach(Blog blog in DataContext.Blogs)
            {
                Console.WriteLine($"Blog`s ID: {blog.Id}");
                Console.WriteLine($"Blog`s author: {blog.Owner.LastName} {blog.Owner.Name}");
                Console.WriteLine($"Contact the author: {blog.Owner.Email}");    
                Console.WriteLine($"Blog`s creation date: {blog.CreatedAt}");
                Console.WriteLine($"Blog`s current row number: {RowNumber}Blog`s title: {LocalizationService.DisplayingAllBlogsTitleCurrentLanguage(TranslationKey.Title, blog.CreatedAt)}");
                RowNumber++;
                if(DataContext.Blogs.Count == RowNumber)
                {
                  Console.WriteLine();
                  Console.Write("Please enter the blog`s ID:");
                  int blogId = int.Parse(Console.ReadLine()!);
                  Console.WriteLine();
                  Console.WriteLine($"Blog`s title: {LocalizationService.DisplayingBlogsTitleCurrentLanguage(TranslationKey.Title, blogId)}");
                  Console.WriteLine($"Blog`s content: {LocalizationService.DisplayingBlogsContentCurrentLanguage(TranslationKey.Content, blogId)}");
                }
            }
        }
    }

}
                
