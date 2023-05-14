using TaskManagement.Contants;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;

namespace TaskManagement.Database
{
    public class DataContext
    {
        public static List<User> Users { get; set; } = new List<User>();
        public static List<Message> Messages { get; set; } = new List<Message>();
        public static List<Blog> Blogs { get; set; } = new List<Blog>();
       
        public static List<Comment> Comments { get; set; } = new List<Comment>();

        static DataContext()
        {
            AddUserSeeedings();
           
        }

        public DataContext()
        {
            AddUserSeeedings();
           
        }

        private static void AddUserSeeedings()
        {
            Users.Add(new User("Super", "Admin", "123321", "admin@gmail.com", new DateTime(2022, 01, 01),  UserRole.Admin));
            Users.Add(new User("Afig", "Jabbarli", "salam123", "afigtj@code.edu.az", new DateTime(2023, 5, 11, 12, 52, 5), UserRole.Member));
            Users.Add(new User("Ixtiyar", "Jabbarzada", "salam321", "ixtiyarjabbarzada@code.edu.az", new DateTime(2023, 5, 11, 12, 52, 5), UserRole.Member));
            Users.Add(new User("Code", "Academy", "StudentOffice", "students@code.edu.az", new DateTime(2023, 5, 11, 12, 52, 5), UserRole.MainSystem));
        }
       

       
    }
}
