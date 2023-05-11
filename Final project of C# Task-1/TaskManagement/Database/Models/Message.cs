﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TaskManagement.Database.Models.Common;


namespace TaskManagement.Database.Models
{
    public class Message : BaseEntity<int>
    {
        public static int IdCounter { get; private set; }

        public string Content_Aze { get; set; }
        public string Content_Rus { get; set; } 
        public string Content_Eng { get; set; } 
        public User Sender { get; set; }
        public User Receiver { get; set; }

        public Message(string content_Aze, string content_Rus, string content_Eng, User sender, User receiver)
        {
            Id = ++IdCounter;
            Content_Aze = content_Aze;
            Content_Rus = content_Rus;
            Content_Eng = content_Eng;
            Sender = sender;
            Receiver = receiver;
            CreatedAt = DateTime.Now;
        }

    }
}
