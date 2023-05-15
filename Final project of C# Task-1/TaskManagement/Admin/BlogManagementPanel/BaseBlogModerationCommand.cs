using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Services;

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
            Console.Write(LocalizationService.GetTranslation(Contants.TranslationKey.Rej_And_App_By_Admin)); string blogCode = (Console.ReadLine()!);
            Blog blog = BlogRepository.GetByBlogCode(blogCode);

            if (blog is null)
            {
                Console.WriteLine(LocalizationService.GetTranslation(Contants.TranslationKey.Blg_Not_Found));
                return default!;
            }

            return blog;
        }
    }
}
