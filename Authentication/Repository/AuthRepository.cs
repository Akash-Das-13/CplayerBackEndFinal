using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationService.Models;


namespace AuthenticationService.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly AuthDbContext authDbContext;

        public AuthRepository(AuthDbContext authDbContext)
        {
            this.authDbContext = authDbContext;
        }
        public bool CreateUser(User user)
        {
            if (user != null)
            {
                this.authDbContext.Users.Add(user);
                this.authDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool IsUserExists(string userId)
        {
            User user1 = this.authDbContext.Users.FirstOrDefault(o => o.UserId == userId);
            if (user1 != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool LoginUser(User user)
        {
            
            User user1 = this.authDbContext.Users.FirstOrDefault(o => o.UserId == user.UserId && o.Password == user.Password);
            if (user1 != null)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
