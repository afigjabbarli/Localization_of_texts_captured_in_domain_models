using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common.Commands;
using TaskManagement.Infrastructure;

namespace TaskManagement.Admin.BlogManagement
{
    public class BlogManagement:ICommandHandler
    {
        public void Handle()
        {
            Console.WriteLine();
            Console.WriteLine("Blog Management Panel");
            Console.WriteLine();
            Console.WriteLine(" <<1>> [Reject Blog Command]");
            Console.WriteLine(" <<2>> [Approve Blog Command]");
            Console.WriteLine(" <<3>> [Show Created Blogs Command]");
            Console.WriteLine(" <<4>> [Exit]");
            Console.WriteLine();
            Console.WriteLine("Please choose one of the commands shown on the screen.");
            Console.Write("Command:");string command = Console.ReadLine()!;
            switch (command)
            {
                case "Reject Blog Command":
                CommandRouter.Route<RejectBlogCommand>();
                break;
                case "Approve Blog Command":
                CommandRouter.Route<ApproveBlogCommand>();
                break;
                case "Show Created Blogs Command":
                CommandRouter.Route<ShowCreatedBlogsCommand>();
                break;
                case "Exit":
                return;
            }
            
        }
    }
}
