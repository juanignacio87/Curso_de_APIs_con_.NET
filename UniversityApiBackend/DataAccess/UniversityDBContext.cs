using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.DataAccess
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options) 
        {
        
        }

        // To Do: Add DbSets (Table of our Data Base)
        public DbSet<User>? Users { get; set; }

    }
}
