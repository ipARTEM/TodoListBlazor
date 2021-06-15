using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListBlazor.Models;

namespace TodoListBlazor.Data
{
    public class DB:DbContext
    {
        public DB(DbContextOptions<DB>options):base(options)
        {

        }

        public DbSet<TodoItem> TodoItems { get; set; }

    }
}
