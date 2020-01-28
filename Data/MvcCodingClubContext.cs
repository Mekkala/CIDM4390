using Microsoft.EntityFrameworkCore;
using CodingClub.Models;

namespace CodingClub.Data
{
    public class MvcCodingClubContext : DbContext
    {
        public MvcCodingClubContext (DbContextOptions<MvcCodingClubContext> options)
            : base(options)
        {
        }

        public DbSet<Member> Members { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Client> Clients { get; set; }
    }
}