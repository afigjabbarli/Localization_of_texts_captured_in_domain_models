using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;

namespace TaskManagement.Admin.BlogManagement
{
    public abstract class BaseBlogModeration
    {
        protected readonly BlogRepository _blogRepository;

        public BaseBlogModeration(BlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public Blog ValidateAndGetBlog()
        {
            Console.WriteLine();
            BlogRepository.ShowCreatedBlogsCommand();
            Console.WriteLine();
            Console.Write("Dear admin, pls enter blogcode:" + " "); string blogCode = (Console.ReadLine()!);
            Blog blog = BlogRepository.GetByBlogCode(blogCode);

            if (blog is null)
            {
                Console.WriteLine("Blog not found");
                return default!;
            }

            return blog;
        }
    }
}
