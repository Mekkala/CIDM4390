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
    }
}