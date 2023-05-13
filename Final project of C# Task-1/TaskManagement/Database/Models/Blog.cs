using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Contants;
using TaskManagement.Database.Models.Common;

namespace TaskManagement.Database.Models
{
    public class Blog : BaseEntity<decimal>
    {
        public static int IdCounter { get; private set; }

        public string Title_Aze { get; set; }
        public string Title_Rus { get; set; }
        public string Title_Eng { get; set; }
        public string Content_Aze { get; set; }
        public string Content_Rus { get; set; }
        public string Content_Eng { get; set; }
        public string BlogCode { get; set; }    
        public User Owner { get; set; }
        
        public BlogStatus Status { get; set; }
        public Blog(string title_Aze, string title_Rus, string title_Eng, string content_Aze, string content_Rus, string content_Eng, string blogCode, User owner, BlogStatus status)
        {
            Id = ++IdCounter;
            Title_Aze = title_Aze;
            Title_Rus = title_Rus;
            Title_Eng = title_Eng;
            Content_Aze = content_Aze;
            Content_Rus = content_Rus;
            Content_Eng = content_Eng;
            BlogCode = blogCode;

            Owner = owner;
            Status = status;
        }
    }

        
        
        
        
        
        
        
        
        
        
       

}
