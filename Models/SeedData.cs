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

                // Look for any movies.
                if (context.Projects.Any())
                {
                    return;   // DB has been seeded
                }

                context.Projects.AddRange(
                    new Project
                    {
                        Name = "Go Green",
                        Details = "Developing App"

                    },

                    new Project
                    {
                        Name = "Baking Website",
                        Details = "Developing website for local bank"

                    }

                );

                context.SaveChanges();
                // Look for any movies.
                if (context.Clients.Any())
                {
                    return;   // DB has been seeded
                }

                context.Clients.AddRange(
                    new Client
                    {
                        Name = "John Lively",
                        PhoneNumber = "9862345432",
                        Email = "john@gmail.com",
                        Organization = "Save Environtal Group"

                    },

                    new Client
                    {
                        Name = "Linda Holly",
                        PhoneNumber = "9045673459",
                        Email = "Hlinda@yahoo.com",
                        Organization = "Canyon first bank"

                    }

                );
                context.SaveChanges();
            }
        }
    }


}
    
     