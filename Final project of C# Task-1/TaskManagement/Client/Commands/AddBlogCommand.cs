using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Blogs));
            string title_Aze = ComposingOfBlogs.AcceptAndConfirmBlogTitleAze();
            string content_Aze = ComposingOfBlogs.AcceptAndConfirmBlogContentAze();
            string title_Rus = ComposingOfBlogs.AcceptAndConfirmBlogTitleRus();
            string content_Rus = ComposingOfBlogs.AcceptAndConfirmBlogContentRus();
            string title_Eng = ComposingOfBlogs.AcceptAndConfirmBlogTitleEng();
            string content_Eng = ComposingOfBlogs.AcceptAndConfirmBlogContentEng();
            string blogCode = ComposingOfBlogs.GeneratingBlogCode();

            Blog blog = new Blog(title_Aze, title_Rus, title_Eng, content_Aze, content_Rus, content_Eng, blogCode, UserService.CurrentUser, BlogStatus.Created );
            blogRepository.Insert(blog);
            

        }
    }
}




        
   
            

           
