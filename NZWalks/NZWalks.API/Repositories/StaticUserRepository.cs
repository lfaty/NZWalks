using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public class StaticUserRepository: IUserRepository
    {
        
       private List<User> Users = new List<User>()
       {
           /*
           new User()
           {
               Id = Guid.NewGuid(),
               FirstName = "Read Only",
               LastName = "User",
               EmailAddress = "readonly@user.com",
               Username = "readonly@user.com",
               Password = "Readonly@user",
               Roles = new List<string> { "reader"}
           },
           new User()
           {
               Id = Guid.NewGuid(),
               FirstName = "Read Write",
               LastName = "User",
               EmailAddress = "readwrite@user.com",
               Username = "readwrite@user.com",
               Password = "Readwrite@user",
               Roles = new List<string> { "reader", "writer"}
           }
           */
       };
           
        public async Task<User> AuthenticateAsync(string usernamne, string password)
        {
            var user = Users.Find(x => x.Username.Equals(usernamne, StringComparison.InvariantCultureIgnoreCase) &&
            x.Password == password);

            return user;
        }
    }
}
