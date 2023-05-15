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
            string adress = @"C:\DatasOfFinalProject\User.txt";
            File.WriteAllText(adress, System.Text.Json.JsonSerializer.Serialize(DataContext.Users));
        }
        public static void UsersDataFromFolderToRam()
        {
            string adress = @"C:\DatasOfFinalProject\User.txt";
            string readText = File.ReadAllText(adress);
            var outPut = JsonConvert.DeserializeObject<List<User>>(readText);
            DataContext.Users = outPut!;

        }
        public static void BlogsDataFromRamToFolder()
        {
            string adress = @"C:\DatasOfFinalProject\Blog.txt";
            File.WriteAllText(adress, System.Text.Json.JsonSerializer.Serialize(DataContext.Blogs));
        }

        public static void BlogsDataFromFolderToRam()
        {
            string adress = @"C:\DatasOfFinalProject\Blog.txt";
            string readText = File.ReadAllText(adress);
            var outPut = JsonConvert.DeserializeObject<List<Blog>>(readText);
            DataContext.Blogs = outPut!;

        }

        public static void MessagesDataFromRamToFolder()
        {
            string adress = @"C:\DatasOfFinalProject\Message.txt";
            File.WriteAllText(adress, System.Text.Json.JsonSerializer.Serialize(DataContext.Messages));
        }

        public static void MessagesDataFromFolderToRam()
        {
            string adress = @"C:\DatasOfFinalProject\Message.txt";
            string readText = File.ReadAllText(adress);
            var outPut = JsonConvert.DeserializeObject<List<Message>>(readText);
            DataContext.Messages = outPut!;

        }

        public static void CommentsDataFromRamToFolder()
        {
            string adress = @"C:\DatasOfFinalProject\Comment.txt";
            File.WriteAllText(adress, System.Text.Json.JsonSerializer.Serialize(DataContext.Comments));
        }
        public static void CommentsDataFromFolderToRam()
        {
            string adress = @"C:\DatasOfFinalProject\Comment.txt";
            string readText = File.ReadAllText(adress);
            var outPut = JsonConvert.DeserializeObject<List<Comment>>(readText);
            DataContext.Comments = outPut!;

        }

    }
}
