using DotNetCoreTraversalAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreTraversalAPI.DAL.Context
{
    public class VisitorContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-5R58FNM\\SQLEXPRESS; database = seyahatliDB; integrated security = true;");
        }

        public DbSet<Visitor> Visitors { get; set; }
    }
}
