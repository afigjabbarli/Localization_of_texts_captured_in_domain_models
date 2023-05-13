using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common.Commands;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Services;

namespace TaskManagement.Client.Commands
{
    public class AddComment: ICommandHandler
    {
        public void Handle()
        {
            CommentRepository commentRepository = new CommentRepository();
            Console.WriteLine("Adding comments to blogs");
            Blog blog = ComposingOfComments.AcceptAndConfirmBlogCode();
            string comment_Content_Aze = ComposingOfComments.AcceptAndConfirmCommentContentAze();
            string comment_Content_Rus = ComposingOfComments.AcceptAndConfirmCommentContentRus();
            string comment_Content_Eng = ComposingOfComments.AcceptAndConfirmCommentContentEng();

            Comment comment = new Comment(comment_Content_Aze, comment_Content_Rus, comment_Content_Eng, UserService.CurrentUser, blog);
            commentRepository.Insert(comment);
        }
    }
}
