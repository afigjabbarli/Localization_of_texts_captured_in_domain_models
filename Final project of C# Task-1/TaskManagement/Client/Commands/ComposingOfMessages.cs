using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Services;

namespace TaskManagement.Client.Commands
{
    public  class ComposingOfMessages
    {
        
        public static User AcceptAndConfirmReceiverEmail()
        {
            
            Console.Write("Please enter eMail of receiver:" + " ");string receiverEmail = Console.ReadLine()!;
            foreach(User user in DataContext.Users)
            {
                if (user.Email == receiverEmail)
                {
                    if(user.IsBanned)
                    {
                       Console.WriteLine($"This <<{user.LastName}>> <<{user.Name}>>user is already blocked and you cannot send him a message...");
                       
                    }
                    return user;
                }
            }
            return null!;
        }

        public static string AcceptAndConfirmMessageSubjectAze()
        {
            Console.Write("Subject:" + " "); string subject_Aze = Console.ReadLine()!;
            Regex regex = new Regex(@"^[A-Za-z0-9!()"":?.,'`\s]{5,60}$");
            Match match = regex.Match(subject_Aze);
            if (match.Success) return subject_Aze;
            else return ComposingOfBlogs.message;
        }
        public static string AcceptAndConfirmMessageContentAze()
        {
            Console.Write("Subject:" + " "); string content_Aze = Console.ReadLine()!;
            Regex regex = new Regex(@"^[A-Za-z0-9!()"":?.,'`\s]{50,600}$");
            Match match = regex.Match(content_Aze);
            if (match.Success) return content_Aze;
            else return ComposingOfBlogs.message;
        }    
        public static string AcceptAndConfirmMessageSubjectRus()
        {
            Console.Write("Subject:" + " "); string subject_Rus = Console.ReadLine()!;
            Regex regex = new Regex(@"^[А-Яа-я0-9!()"":?.,`'\s]{5,60}$");
            Match match = regex.Match(subject_Rus);
            if (match.Success) return subject_Rus;
            else return ComposingOfBlogs.message;
        }
        public static string AcceptAndConfirmMessageContentRus()
        {
            Console.Write("Subject:" + " "); string content_Rus = Console.ReadLine()!;
            Regex regex = new Regex(@"^[А-Яа-я0-9!()"":?.,`'\s]{50,600}$");
            Match match = regex.Match(content_Rus);
            if (match.Success) return content_Rus;
            else return ComposingOfBlogs.message;
        }
        public static string AcceptAndConfirmMessageSubjectEng()
        {
            Console.Write("Subject:" + " "); string subject_Eng = Console.ReadLine()!;
            Regex regex = new Regex(@"^[A-Za-z0-9!()"":?.,'`\s]{5,60}$");
            Match match = regex.Match(subject_Eng);
            if (match.Success) return subject_Eng;
            else return ComposingOfBlogs.message;
        }
        public static string AcceptAndConfirmMessageContentEng()
        {
            Console.Write("Subject:" + " "); string content_Eng = Console.ReadLine()!;
            Regex regex = new Regex(@"^[A-Za-z0-9!()"":?.,'`\s]{50,600}$");
            Match match = regex.Match(content_Eng);
            if (match.Success) return content_Eng;
            else return ComposingOfBlogs.message;
        }
                
            

            
            
    }
            
}
