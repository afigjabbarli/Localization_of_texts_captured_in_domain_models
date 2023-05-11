using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common.Commands;
using TaskManagement.Infrastructure;

namespace TaskManagement.Client.Commands
{
    public class BlogManagementPanel:ICommandHandler
    {
        public void Handle()
        {
            Console.WriteLine("Blog Management Panel");
            Console.WriteLine();
            Console.WriteLine("Add Blog Command");
            Console.WriteLine("Display of Created Blogs");
            Console.WriteLine("Exit");
            Console.WriteLine();
            while (true)
            {
                Console.Write("Command"); string command = Console.ReadLine()!;
                Console.WriteLine();
                switch (command)
                {
                    case "Add Blog Command":
                        CommandRouter.Route<AddBlogCommand>();
                        break;
                    case "Display of Created Blogs":
                        CommandRouter.Route<DisplayOfCreatedBlogs>();
                        break;
                    case "Exit":
                        return;
                }
            }
        }
    }


}
