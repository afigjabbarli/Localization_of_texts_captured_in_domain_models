using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TaskManagement.Common.Commands;
using TaskManagement.Contants;
using TaskManagement.Database.Models;
using TaskManagement.Services;

namespace TaskManagement.Client.Commands
{
    public class ComposingOfBlogs
    {
        public static string message = LocalizationService.GetTranslation(TranslationKey.Incorrect_Information);
        public static string AcceptAndConfirmBlogTitleAze()
        {
            while (true)
            {

              Console.WriteLine();
              Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Blogs_TitleAz));
              Console.Write(LocalizationService.GetTranslation(TranslationKey.Titles) + " "); string title_Aze = Console.ReadLine()!;
              Console.WriteLine();
              Regex regex = new Regex(@"^[A-Za-z0-9!()"":?.,`\s]{5,60}$");
              Match match = regex.Match(title_Aze);
              if (match.Success)
                return title_Aze;
              else
                Console.WriteLine(message);
            }
        }
        public static string AcceptAndConfirmBlogTitleRus()
        {
            while(true)
            {
              Console.WriteLine();
              Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Blogs_TitleRu));
              Console.Write(LocalizationService.GetTranslation(TranslationKey.Titles) + " "); string title_Rus = Console.ReadLine()!;
              Console.WriteLine();
              Regex regex = new Regex(@"^[А-Яа-я0-9!()"":?.,`\s]{5,60}$");
              Match match = regex.Match(title_Rus);
              if (match.Success)
                return title_Rus;
              else
                Console.WriteLine(message);
            }
        }
        public static string AcceptAndConfirmBlogTitleEng()
        {
            while(true)
            {
              Console.WriteLine();
              Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.Blogs_TitleEn));
              Console.Write(LocalizationService.GetTranslation(TranslationKey.Titles) + " "); string title_Eng = Console.ReadLine()!;
              Console.WriteLine();
              Regex regex = new Regex(@"^[A-Za-z0-9!()"":?.,`\s]{5,60}$");
              Match match = regex.Match(title_Eng);
              if (match.Success)
                return title_Eng;
              else
                Console.WriteLine(message);
            }
        }
        public static string AcceptAndConfirmBlogContentAze()
        {
            while (true)
            {
              Console.WriteLine();
              Console.Write(LocalizationService.GetTranslation(TranslationKey.Blogs_ContentAz));
              string content_Aze = Console.ReadLine()!;
              Console.WriteLine();
              Regex regex = new Regex(@"^[A-Za-z0-9!()"":?.,`\s]{50,1000}$");
              Match match = regex.Match(content_Aze);
              if (match.Success)
                return content_Aze;
              else
                Console.WriteLine(message);
            }
        }
        public static string AcceptAndConfirmBlogContentRus()
        {
            while (true)
            {
              Console.WriteLine();
              Console.Write(LocalizationService.GetTranslation(TranslationKey.Blogs_ContentRu));
              string content_Rus = Console.ReadLine()!;
              Console.WriteLine();
              Regex regex = new Regex(@"^[А-Яа-я0-9!()"":?.,`\s]{50,1000}$");
              Match match = regex.Match(content_Rus);
              if(match.Success)
                return content_Rus;
              else
                Console.WriteLine(message);
            }
        }
        public static string AcceptAndConfirmBlogContentEng()
        {
            while(true)
            {
              Console.WriteLine();
              Console.Write(LocalizationService.GetTranslation(TranslationKey.Blogs_ContentEn));
              string content_Eng = Console.ReadLine()!;
              Console.WriteLine();
              Regex regex = new Regex(@"^[A-Za-z0-9!()"":?.,`\s]{50,1000}$");
              Match match = regex.Match(content_Eng);
              if (match.Success)
                return content_Eng;
              else
                Console.WriteLine(message);
            }
        }
        public static string GeneratingBlogCode()
        {
            Random randomCode = new Random();
            int endCode = randomCode.Next(10000, 100000);
            string blogPrefiks = "BL";
            string blogCode = $"{blogPrefiks}{endCode}";
            return blogCode;
        }

            


    }
              

}







            
            
            
            

            

            

            

                
            
            









