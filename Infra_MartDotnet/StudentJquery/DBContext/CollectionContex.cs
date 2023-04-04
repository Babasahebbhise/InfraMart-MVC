using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.DependencyInjection;
using StudentJquery.Models;

namespace StudentJquery.DBContext
{
    public class CollectionContex : DbContext
    {


        public CollectionContex(DbContextOptions options) : base(options)
        {

        }
        public DbSet<StudentModel> Student { get; set; }
    }
}
