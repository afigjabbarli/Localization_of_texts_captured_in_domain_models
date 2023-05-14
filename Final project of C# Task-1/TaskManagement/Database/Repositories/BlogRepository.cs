using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Admin.BlogManagement;
using TaskManagement.Contants;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories.Common;
using TaskManagement.Services;

namespace TaskManagement.Database.Repositories
{
    public class BlogRepository : BaseRepository<Blog, decimal>
    {
        public BlogRepository()
            : base(DataContext.Blogs)
        {
            
        }
        public static void DisplayOfCreatedBlogs()
        {
            Console.WriteLine();
            Console.WriteLine("Different Blogs From All Over The World");
            Console.WriteLine();
            int RowNumber = 1;
            foreach (Blog blog in DataContext.Blogs)
            {
                if (blog.Status.Equals(BlogStatus.Created))
                {
                    Console.WriteLine($"Blog`s code: {blog.BlogCode}");
                    Console.WriteLine($"Blog`s author: {blog.Owner.LastName} {blog.Owner.Name}");
                    Console.WriteLine($"Contact the author: {blog.Owner.Email}");
                    Console.WriteLine($"Blog`s creation date: {blog.CreatedAt}");
                    Console.WriteLine($"Blog`s current row number: <<{RowNumber}>> Blog`s title: {LocalizationService.DisplayingAllBlogsTitleCurrentLanguage(TranslationKey.Title, blog.CreatedAt)}");
                }
            }
            Console.WriteLine();
            Console.Write("Please enter the blog`s code:");
            string blogCode = Console.ReadLine()!;
            Console.WriteLine();
            Console.WriteLine($"Blog`s title: {LocalizationService.DisplayingBlogsTitleCurrentLanguage(TranslationKey.Title, blogCode)}");
            Console.WriteLine($"Blog`s content: {LocalizationService.DisplayingBlogsContentCurrentLanguage(TranslationKey.Content, blogCode)}");
        }

        public static void ShowBlogsForAddingComment()
        {
            Console.WriteLine();
            Console.WriteLine("Different Blogs From All Over The World");
            Console.WriteLine();
            int RowNumber = 1;
            foreach (Blog blog in DataContext.Blogs)
            {
                if (blog.Status.Equals(BlogStatus.Created))
                {
                    Console.WriteLine($"Blog`s code: {blog.BlogCode}");
                    Console.WriteLine($"Blog`s author: {blog.Owner.LastName} {blog.Owner.Name}");
                    Console.WriteLine($"Contact the author: {blog.Owner.Email}");
                    Console.WriteLine($"Blog`s creation date: {blog.CreatedAt}");
                    Console.WriteLine($"Blog`s current row number: <<{RowNumber}>> Blog`s title: {LocalizationService.DisplayingAllBlogsTitleCurrentLanguage(TranslationKey.Title, blog.CreatedAt)}");
                    Console.WriteLine($"Blog`s content: {LocalizationService.DisplayingBlogsContentCurrentLanguage(TranslationKey.Content, blog.BlogCode)}");
                }
            }
        }

        public static void ShowCreatedBlogsCommand()
        {
            BlogRepository blogRepository = new BlogRepository();

            List<Blog> createdBlogs = blogRepository.GetAll(b => b.Status == BlogStatus.Created);

            foreach (Blog blog in createdBlogs)
            {
                string blogCode = blog.BlogCode;
                Console.WriteLine($"{blog.Id} {LocalizationService.DisplayingBlogsTitleCurrentLanguage(TranslationKey.Title, blogCode)}{blog.Owner.GetFullName()} {blog.CreatedAt}");
            }
        }

        public static Blog GetByBlogCode(string blogCode)
        {
            foreach (Blog blog in DataContext.Blogs)
            {
                if(blog.BlogCode.Equals(blogCode))return blog;
            }
            return null!;
        }


    }
}
           








    
