using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CodingClub.Data;
using System;
using System.Linq;

namespace CodingClub.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcCodingClubContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcCodingClubContext>>()))
            {
                // Look for any movies.
                if (context.Members.Any())
                {
                    return;   // DB has been seeded
                }

                context.Members.AddRange(
                    new Member
                    {
                        Name = "Tommy Smith",
                        PhoneNumber = "205-985-3486",
                        Email = "tsmith@buffs.wtamu.edu",
                        Classification = "Freshman"
                    },
                    new Member
                    {
                        Name = "Derek Williams",
                        PhoneNumber = "806-126-0943",
                        Email = "dwilliams@buffs.wtmau.edu",
                        Classification = "Junior"
                    },
                    new Member
                    {
                        Name = "Susan Baker",
                        PhoneNumber = "503-984-6392",
                        Email = "sbaker@buffs.wtmau.edu",
                        Classification = "Senior"
                    }
                    
                );
                context.SaveChanges();
        }
    }
}

}