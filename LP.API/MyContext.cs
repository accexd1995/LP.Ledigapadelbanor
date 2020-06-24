using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LP.API
{
    public class MyContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<PadelCourt> PadelCourts { get; set; }
    }
}
