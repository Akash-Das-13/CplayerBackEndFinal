using AuthenticationService.Exceptions;
using AuthenticationService.Models;
using AuthenticationService.Repository;

namespace AuthenticationService.Service
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository authRepository;

        public AuthService(IAuthRepository authRepository)
        {
            this.authRepository = authRepository;
        }
        public bool LoginUser(User user)
        {
            var user1 = this.authRepository.LoginUser(user);
            if (user1)
            {
                return true;
            }
            else
            {
                throw new System.Exception("Invalid user id or password");
            }
        }

        public bool RegisterUser(User user)
        {
            var us = this.authRepository.IsEmailExists(user.Email);
            var usv = this.authRepository.IsUserExists(user.UserId);
            if (us == false)
            {
                if (usv == false)
                {
                    return this.authRepository.CreateUser(user);
                }
                else
                {
                    throw new UserAlreadyExistsException($"This userId {user.UserId} is Already registerd. Please Try With SomeThing Different.");
                }
            }
            else
            {
                throw new UserAlreadyExistsException($"This Email Address {user.Email} is already regigtered. Please Login or Try with a different Email Address");
            }
        }
    }
}
