using PlayerAPI.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using PlayerAPI.Model;
using NUnit.Framework;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace test.Repositories
{
   public class PlayerRepositoryTest
    {
        private readonly IPlayerRepository play;
        public PlayerRepositoryTest()
        {
            //DatabaseFixture fixture = new DatabaseFixture();
            play = new PlayerRepository();
        }
        [Test]
        public void GetByIdShouldSuccess()
        {
            int a = 28081;
            var res = play.GetPlayerByIdAsync(a);
            var res2 = play.GetPlayerByIdAsync(a).IsCompleted;
            Assert.IsTrue(res2);
            Assert.IsAssignableFrom<Task<Player>>(res);
        }
        [Test]
        public void GetByNameShouldSuccess()
       {
            string b = "Suresh Raina";
            
            var res = play.GetPlayerByNameAsync(b);
            Assert.IsAssignableFrom<Task<List<Data2>>>(res);
        }
        [Test]
        public void GetByIdShouldFail()
        {
            int a = 21;
            var res = play.GetPlayerByIdAsync(a).IsFaulted;
            Assert.IsTrue(res);

        }
        [Test]
        public void GetByNameShouldFail()
            
        {
            string b = "kkkkkkkk";

            var res = play.GetPlayerByNameAsync(b).IsFaulted;
            Assert.IsTrue(res);
        }
    }

}
