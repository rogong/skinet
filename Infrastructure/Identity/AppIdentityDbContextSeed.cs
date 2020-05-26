using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if(!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "bob",
                    Email = "bob@test.com",
                    UserName = "bob",
                    Address =  new Address
                    {
                        FirstName = "Oluseyi",
                        LastName = "Ayinde",
                        Street = "112, Pwerline",
                        City = "Agege",
                        State = "Lagos",
                        Zipcode = "234",
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}