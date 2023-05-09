using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TaskManagement.Client.Commands
{
    public class ComposingOfBlogs
    {
        public static string AcceptAndConfirmBlogTitleAze()
        {
            Console.WriteLine();
            Console.Write("Zehmet olmasa blogun bashlighini yazin(In Azerbaijani):");
            Console.Write("Title:" + " "); string title_Aze = Console.ReadLine()!;
            Console.WriteLine();
            Regex regex = new Regex(@"^[A-Za-z0-9!()"":?.,`]{1,1000}$");
            Match match = regex.Match(title_Aze);
            if (!match.Success)
            {
               Console.WriteLine("Daxil edilen melumat sehvdir! Xahish edirik yeniden daxil edin...");
            }
            return title_Aze;
        }
        public static string AcceptAndConfirmBlogTitleRus()
        {
            Console.WriteLine();
            Console.Write("Zehmet olmasa blogun bashlighini yazin(In Russian):");
            Console.Write("Title:" + " "); string title_Rus = Console.ReadLine()!;
            Console.WriteLine();
            Regex regex = new Regex(@"^[А-Яа-я0-9!()"":?.,`]{1,60}$");
            Match match = regex.Match(title_Rus);
            if (!match.Success)
            {
                Console.WriteLine("Daxil edilen melumat sehvdir! Xahish edirik yeniden daxil edin...");
            }
            return title_Rus;
        }
        public static string AcceptAndConfirmBlogTitleEng()
        {
            Console.WriteLine();
            Console.Write("Zehmet olmasa blogun bashlighini yazin(In English):");
            Console.Write("Title:" + " "); string title_Eng = Console.ReadLine()!;
            Console.WriteLine();
            Regex regex = new Regex(@"^[A-Za-z0-9!()"":?.,`]{1,60}$");
            Match match = regex.Match(title_Eng);
            if (!match.Success)
            {
                Console.WriteLine("Daxil edilen melumat sehvdir! Xahish edirik yeniden daxil edin...");
            }
            return title_Eng;
        }

        public static string AcceptAndConfirmBlogContentAze()
        {
            Console.WriteLine();
            Console.Write("Zehmet olmasa blogun mezmununu yazin(In Azerbaijani):");
            Console.Write("Title:" + " "); string content_Aze = Console.ReadLine()!;
            Console.WriteLine();
            Regex regex = new Regex(@"^[A-Za-z0-9!()"":?.,`]{1,1000}$");
            Match match = regex.Match(content_Aze);
            if (!match.Success)
            {
                Console.WriteLine("Daxil edilen melumat sehvdir! Xahish edirik yeniden daxil edin...");
            }
            return content_Aze;
        }

        public static string AcceptAndConfirmBlogContentRus()
        {
            Console.WriteLine();
            Console.Write("Zehmet olmasa blogun mezmununu yazin(In Russian):");
            Console.Write("Title:" + " "); string content_Rus = Console.ReadLine()!;
            Console.WriteLine();
            Regex regex = new Regex(@"^[А-Яа-я0-9!()"":?.,`]{1,1000}$");
            Match match = regex.Match(content_Rus);
            if (!match.Success)
            {
                Console.WriteLine("Daxil edilen melumat sehvdir! Xahish edirik yeniden daxil edin...");
            }
            return content_Rus;
        }

        public static string AcceptAndConfirmBlogContentEng()
        {
            Console.WriteLine();
            Console.Write("Zehmet olmasa blogun mezmununu yazin(In English):");
            Console.Write("Title:" + " "); string content_Eng = Console.ReadLine()!;
            Console.WriteLine();
            Regex regex = new Regex(@"^[A-Za-z0-9!()"":?.,`]{1,1000}$");
            Match match = regex.Match(content_Eng);
            if (!match.Success)
            {
                Console.WriteLine("Daxil edilen melumat sehvdir! Xahish edirik yeniden daxil edin...");
            }
            return content_Eng;
        }








    }
}
