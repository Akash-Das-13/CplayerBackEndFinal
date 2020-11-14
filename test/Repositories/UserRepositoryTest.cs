using AuthenticationService.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using AuthenticationService.Models;
using NUnit.Framework;

namespace test.Repositories
{
   public class UserRepositoryTest
    {
        private readonly IAuthRepository repo;
        public UserRepositoryTest()
        {
            DatabaseFixture fixture = new DatabaseFixture();
            repo = new AuthRepository(fixture.context);
        }
        
        [Test]
        public void LoginShouldSuccess()
        {
           var res = repo.CreateUser(new User() { Name = "sai", Email = "sai@gmail.com", Mobile = "9003255129", UserId = "sai", Password = "sai1998" });
            var result = repo.LoginUser(new User() { UserId = "sai", Password = "sai1998" });
            Assert.IsTrue(result);
        }
        [Test]
        public void IsUserAlreadyExistsShouldSuccess()
        {
            var res = repo.CreateUser(new User() { Name = "sai", Email = "sai@gmail.com", Mobile = "9003255129", UserId = "sai123", Password = "sai1998" });
            string b = "sai123";
            var res1 = repo.IsUserExists(b);
            
            Assert.IsTrue(res1);
        }
        [Test]
        public void RegisterUserShouldSuccess()
        {
            var res = repo.CreateUser(new User() { Name = "sai", Email = "sai@gmail.com", Mobile = "9003255129", UserId = "sai1234", Password = "sai1998" });
            Assert.IsTrue(res);
        }
        [Test]
        public void LoginShouldNotSuccess()
        {
           // var res = repo.CreateUser(new User() { Name = "sai", Email = "sai@gmail.com", Mobile = "9003255129", UserId = "sai", Password = "sai1998" });
            var result = repo.LoginUser(new User() { UserId = "sai", Password = "sai1998" });
            Assert.IsFalse(result);
        }
        [Test]
        public void IsUserAlreadyExistsShouldNotSuccess()
        {
            //var res = repo.CreateUser(new User() { Name = "sai", Email = "sai@gmail.com", Mobile = "9003255129", UserId = "sai123", Password = "sai1998" });
            string b = "sai123";
            var res1 = repo.IsUserExists(b);

            Assert.IsFalse(res1);
        }
        [Test]
        public void RegisterUserShouldNotSuccess()
        {
            var res = repo.CreateUser(null);
            
            Assert.IsFalse(res);
        }





    }
}
