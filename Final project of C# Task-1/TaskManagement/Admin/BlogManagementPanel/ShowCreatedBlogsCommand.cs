using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common.Commands;
using TaskManagement.Contants;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Services;

namespace TaskManagement.Admin.BlogManagement
{
    public class ShowCreatedBlogsCommand : ICommandHandler
    {
        public void Handle()
        {
            BlogRepository.ShowCreatedBlogsCommand();
        }
    }
}
