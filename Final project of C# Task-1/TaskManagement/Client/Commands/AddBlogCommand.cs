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
            string title_Aze = ComposingOfBlogs.AcceptAndConfirmBlogTitleAze();
            string title_Rus = ComposingOfBlogs.AcceptAndConfirmBlogTitleRus();
            string title_Eng = ComposingOfBlogs.AcceptAndConfirmBlogTitleEng();
            string content_Aze = ComposingOfBlogs.AcceptAndConfirmBlogContentAze();
            string content_Rus = ComposingOfBlogs.AcceptAndConfirmBlogContentRus();
            string content_Eng = ComposingOfBlogs.AcceptAndConfirmBlogContentEng();

            Blog blog = new Blog(title_Aze, title_Rus, title_Eng, content_Aze, content_Rus, content_Eng, UserService.CurrentUser, BlogStatus.Created );
            blogRepository.Insert( blog );

        }
    }
}




        
   
            

           
