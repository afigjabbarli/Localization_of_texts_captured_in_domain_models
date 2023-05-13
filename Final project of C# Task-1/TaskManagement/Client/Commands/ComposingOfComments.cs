using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Client.Commands
{
    public class ComposingOfComments
    {
        public static Blog AcceptAndConfirmBlogCode()
        {
            while (true)
            {
                Console.WriteLine("Please enter the blog code:" + " "); string codeOfBlog = Console.ReadLine()!;
                string codeFormat = "{Letters(2)/Digits(5)} = total(7 characters)";
                Regex codeOfBlogDesign = new Regex(@"^BL(?=[^\s]{0,5}$)\d{0,5}$");
                Match match = codeOfBlogDesign.Match(codeOfBlog);
                if (match.Success)
                {
                    foreach(Blog blog in DataContext.Blogs)
                    {
                        if (blog.BlogCode.Equals(codeOfBlog))
                            return blog;
                        else
                        {
                            Console.WriteLine("The blog was not found in the code you entered!Pls re-enter...");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Your input does not fit this <<{codeFormat}>> format");
                }
            }
        }
        public static string AcceptAndConfirmCommentContentAze()
        {
            Console.WriteLine("Please enter the text of the comment in Azerbaijani language...");
            while (true)
            {
                Console.Write("Comment:" + " "); string commentContentAze = Console.ReadLine()!;
                Regex regex = new Regex(@"^[A-Za-z0-9!()"":?.,'`\s]{30,300}$");
                Match match = regex.Match(commentContentAze);
                if (match.Success) return commentContentAze;
                else Console.WriteLine(ComposingOfBlogs.message);
            }
        }

        public static string AcceptAndConfirmCommentContentRus()
        {
            Console.WriteLine("Please enter the text of the comment in Russian language...");
            while (true)
            {
                Console.Write("Comment:" + " "); string commentContentRus = Console.ReadLine()!;
                Regex regex = new Regex(@"^[А-Яа-я0-9!()"":?.,`'\s]{30,300}$");
                Match match = regex.Match(commentContentRus);
                if (match.Success) return commentContentRus;
                else Console.WriteLine(ComposingOfBlogs.message);
            }
        }

        public static string AcceptAndConfirmCommentContentEng()
        {
            Console.WriteLine("Please enter the text of the comment in English language...");
            while (true)
            {
                Console.Write("Comment:" + " "); string commentContentEng = Console.ReadLine()!;
                Regex regex = new Regex(@"^[A-Za-z0-9!()"":?.,'`\s]{30,300}$");
                Match match = regex.Match(commentContentEng);
                if (match.Success) return commentContentEng;
                else Console.WriteLine(ComposingOfBlogs.message);
            }
        }












    }
}
