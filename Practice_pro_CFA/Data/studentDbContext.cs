using Microsoft.EntityFrameworkCore;
using Practice_pro_CFA.Models;

namespace Practice_pro_CFA.Data
{
    public class studentDbContext:DbContext
    {
        public studentDbContext(DbContextOptions<studentDbContext> options) : base(options)
        {

        }

        public DbSet<student> students { get; set; }

    }
}
