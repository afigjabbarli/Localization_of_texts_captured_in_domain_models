using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database.Models.Common;

namespace TaskManagement.Database.Models
{
    public class Comment: BaseEntity<int>
    {
        public static int IdCounter { get; private set; }
        public string Comment_Content_Aze { get; set; }
        public string Comment_Content_Rus { get; set; }
        public string Comment_Content_Eng { get; set; }
        public User Comment_Author { get; set; }

        public Blog Blog { get; set; }

        public Comment(string comment_Content_Aze, string comment_Content_Rus, string comment_Content_Eng, User comment_Author, Blog blog)
        {
            Id = IdCounter++;    
            Comment_Content_Aze = comment_Content_Aze;
            Comment_Content_Rus = comment_Content_Rus;
            Comment_Content_Eng = comment_Content_Eng;
            Comment_Author = comment_Author;
            Blog = blog;
            CreatedAt = DateTime.Now;
        }
    }
}
