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
            while (true)
            {

                Console.Write("Please enter eMail of receiver:" + " ");string receiverEmail = Console.ReadLine()!;//Regex ile validation aparmiram chunki yeqinki bu adda istifadechi sistemde varsa onun emaili artiq yoxlanishdan kechib...
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
                Console.WriteLine("No user found for this email! Please re-enter the email...");
                return null!;
            }
        }

        public static string AcceptAndConfirmMessageSubjectAze()
        {
            while(true)
            {
              Console.Write("Subject:" + " "); string subject_Aze = Console.ReadLine()!;
              Regex regex = new Regex(@"^[A-Za-z0-9!()"":?.,'`\s]{5,60}$");
              Match match = regex.Match(subject_Aze);
              if (match.Success) return subject_Aze;
              else Console.WriteLine(ComposingOfBlogs.message);

            }
        }
        public static string AcceptAndConfirmMessageContentAze()
        {
            while (true)
            {
            Console.Write("Content:" + " "); string content_Aze = Console.ReadLine()!;
            Regex regex = new Regex(@"^[A-Za-z0-9!()"":?.,'`\s]{50,600}$");
            Match match = regex.Match(content_Aze);
            if (match.Success) return content_Aze;
            else Console.WriteLine(ComposingOfBlogs.message);

            }
        }    
        public static string AcceptAndConfirmMessageSubjectRus()
        {
            while (true)
            {
            Console.Write("Subject:" + " "); string subject_Rus = Console.ReadLine()!;
            Regex regex = new Regex(@"^[А-Яа-я0-9!()"":?.,`'\s]{5,60}$");
            Match match = regex.Match(subject_Rus);
            if (match.Success) return subject_Rus;
            else Console.WriteLine(ComposingOfBlogs.message);

            }
        }
        public static string AcceptAndConfirmMessageContentRus()
        {
            while(true)
            {
            Console.Write("Content:" + " "); string content_Rus = Console.ReadLine()!;
            Regex regex = new Regex(@"^[А-Яа-я0-9!()"":?.,`'\s]{50,600}$");
            Match match = regex.Match(content_Rus);
            if (match.Success) return content_Rus;
            else Console.WriteLine(ComposingOfBlogs.message);

            }
        }
        public static string AcceptAndConfirmMessageSubjectEng()
        {
            while (true)
            {
            Console.Write("Subject:" + " "); string subject_Eng = Console.ReadLine()!;
            Regex regex = new Regex(@"^[A-Za-z0-9!()"":?.,'`\s]{5,60}$");
            Match match = regex.Match(subject_Eng);
            if (match.Success) return subject_Eng;
            else Console.WriteLine(ComposingOfBlogs.message);

            }
        }
        public static string AcceptAndConfirmMessageContentEng()
        {
            while (true)
            {
            Console.Write("Content:" + " "); string content_Eng = Console.ReadLine()!;
            Regex regex = new Regex(@"^[A-Za-z0-9!()"":?.,'`\s]{50,600}$");
            Match match = regex.Match(content_Eng);
            if (match.Success) return content_Eng;
            else Console.WriteLine(ComposingOfBlogs.message);

            }
        }
                
            

            
            
    }
            
}
