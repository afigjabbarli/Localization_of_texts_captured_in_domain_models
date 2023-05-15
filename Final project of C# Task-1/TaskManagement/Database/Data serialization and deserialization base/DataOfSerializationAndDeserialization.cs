using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Services.JsonService
{
    public class DataOfSerializationAndDeserialization
    {
        public static void UsersDataFromRamToFolder()
        {
            string adress = @"C:\DataOfTaskManagement\Users.txt";
            File.WriteAllText(adress, System.Text.Json.JsonSerializer.Serialize(DataContext.Users));
        }

        public static void UsersDataFromFolderToRam()
        {
            string adress = @"C:\DataOfTaskManagement\Users.txt";
            string readData = File.ReadAllText(adress);
            var output = JsonConvert.DeserializeObject<List<User>>(readData);
            DataContext.Users = output!;
        }

        public static void BlogsDataFromRamToFolder()
        {
            string adress = @"C:\DataOfTaskManagement\Blogs.txt";
            File.WriteAllText(adress, System.Text.Json.JsonSerializer.Serialize(DataContext.Blogs));
        }

        public static void BlogsDataFromFolderToRam()
        {
            string adress = @"C:\DataOfTaskManagement\Blogs.txt";
            string readData = File.ReadAllText(adress);
            var output = JsonConvert.DeserializeObject<List<Blog>>(readData);
            DataContext.Blogs = output!;
        }
        public static void CommentsDataFromRamToFolder()
        {
            string adress = @"C:\DataOfTaskManagement\Comments.txt";
            File.WriteAllText(adress, System.Text.Json.JsonSerializer.Serialize(DataContext.Comments));
        }

        public static void CommentsDataFromFolderToRam()
        {
            string adress = @"C:\DataOfTaskManagement\Comments.txt";
            string readData = File.ReadAllText(adress);
            var output = JsonConvert.DeserializeObject<List<Comment>>(readData);
            DataContext.Comments = output!;
        }
        public static void MessagesDataFromRamToFolder()
        {
            string adress = @"C:\DataOfTaskManagement\Messages.txt";
            File.WriteAllText(adress, System.Text.Json.JsonSerializer.Serialize(DataContext.Messages));
        }

        public static void MessagesDataFromFolderToRam()
        {
            string adress = @"C:\DataOfTaskManagement\Messages.txt";
            string readData = File.ReadAllText(adress);
            var output = JsonConvert.DeserializeObject<List<Message>>(readData);
            DataContext.Messages = output!;
        }


    }
}
