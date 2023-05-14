using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Contants;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Services;

namespace TaskManagement.Common.Commands
{
    public class ShowBlogsWithComments:ICommandHandler
    {
        public void Handle()
        {
            foreach(Blog blog in DataContext.Blogs)
            {
                if (blog != null && blog.Status.Equals(BlogStatus.Approved))
                {
                    Console.WriteLine($"[{blog.CreatedAt}]  [{blog.BlogCode}]  [{blog.Owner.Name} {blog.Owner.LastName}]");
                    Console.WriteLine($"=========={LocalizationService.DisplayingBlogsTitleCurrentLanguage(TranslationKey.Title, blog.BlogCode)}==========");
                    Console.WriteLine(LocalizationService.DisplayingBlogsContentCurrentLanguage(TranslationKey.Content, blog.BlogCode));
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Comments:");
                    foreach (Comment comment in DataContext.Comments)
                    {
                        int CommentRowNumber = 1;
                        if(comment != null && blog.BlogCode.Equals(comment.Blog.BlogCode))
                        {
                            Console.WriteLine($"<<{CommentRowNumber}>> [{comment.CreatedAt}]  [{comment.Comment_Author.Name} {comment.Comment_Author.LastName}] {LocalizationService.DisplayingCommentContentCurrentLanguage(TranslationKey.Comment_Content, comment.Blog.BlogCode)}");

                            CommentRowNumber++;
                        }
                    }
                }
            }
            Console.WriteLine("The blog box is currently empty...");
                
                
                

        }
    }
}
