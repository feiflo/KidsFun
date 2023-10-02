using KidsFun.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsFun.Repositories
{
    public class KidsFunContext : DbContext
    {
        public DbSet<KidDetail> Kids { get; set; }

        public DbSet<TaskType> TaskTypes { get; set; }

        public DbSet<TaskAssignment> TaskAssignments { get; set; }

        public KidsFunContext()
        {
        }
    }
}
