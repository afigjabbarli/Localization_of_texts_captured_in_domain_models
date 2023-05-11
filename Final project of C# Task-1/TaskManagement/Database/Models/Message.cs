using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TaskManagement.Database.Models.Common;
using TaskManagement.Services;

namespace TaskManagement.Database.Models
{
    public class Message : BaseEntity<int>
    {
        

        public static int IdCounter { get; private set; }
        public string Subject_Aze { get; set; }
        public string Subject_Rus { get; set; } 
        public string Subject_Eng { get; set; } 
        public string Content_Aze { get; set; }
        public string Content_Rus { get; set; } 
        public string Content_Eng { get; set; }
        public User Sender { get; set; }
        public User Receiver { get; set; }
        

        public Message(string subject_Aze, string subject_Rus, string subject_Eng, string content_Aze, string content_Rus, string content_Eng, User sender, User receiver)
        {
            Id = ++IdCounter;
            Subject_Aze = subject_Aze;
            Subject_Rus = subject_Rus;
            Subject_Eng = subject_Eng;
            Content_Aze = content_Aze;
            Content_Rus = content_Rus;
            Content_Eng = content_Eng;
            Sender = sender;
            Receiver = receiver;
            CreatedAt = DateTime.Now;
            
        }

       
    }
}
