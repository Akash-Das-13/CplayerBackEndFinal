using Favourites.Models;
using Favourites.Repositories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace test.Repository
{
   public class FavouriteRepositoryTest
    {

        private readonly IFavouriteRepository repo;
        public FavouriteRepositoryTest()
        {
            DatabaseFixture fixture = new DatabaseFixture();
            repo = new FavouriteRepository(fixture.favcontext);

        }
        [Test]
        public void AddToFavouriteShouldSuccess()
        {
            var res = repo.AddFavourite(new Favourite() { Name = "Sachin Tendulkar", FullName = "Sachin Ramesh Tendulkar",PId=28770, UserId = "35320" });
            Assert.AreEqual("Sachin Tendulkar", res.Name);
        }
        [Test]
        public void AddToFavouriteShouldFail()
        {
            var res = repo.AddFavourite(new Favourite() {Name = "Sachin Tendulkar", FullName = "Sachin Ramesh Tendulkar",PId=900878, UserId = "35320" });
            Assert.AreNotEqual("MS Dhoni", res);
            
        }

        [Test]
        public void GetAllFavouritesByIdShouldSuccess()
        {
            var res = repo.AddFavourite(new Favourite() { Name = "Sachin Tendulkar", FullName = "Sachin Ramesh Tendulkar", PId = 900878, UserId = "2" });
            string b = "2";
            var result = repo.GetAllFavouritesByUserId(b);
            foreach (var item in result)
            {
                Assert.AreEqual(900878, item.PId);
            }
            Assert.IsAssignableFrom<List<Favourite>>(result);
        }
        [Test]
        public void GetAllFavouritesByIdShouldFail()
        {
            var res = repo.AddFavourite(new Favourite() { Name = "Sachin Tendulkar", FullName = "Sachin Ramesh Tendulkar", PId = 900878, UserId = "35320" });
            string b = "33";
            var result = repo.GetAllFavouritesByUserId(b);
            Assert.AreNotEqual(res,result);
        }

        [Test]
        public void GetRecommShouldSuccess()
        {
            var res1 = repo.AddFavourite(new Favourite() { Name = "Sachin Tendulkar", FullName = "Sachin Ramesh Tendulkar", PId = 90087, UserId = "1" });
            var res2= repo.AddFavourite(new Favourite() { Name = "Sachin Tendulkar", FullName = "Sachin Ramesh Tendulkar", PId = 90087, UserId = "5" });
            bool b = false;
            var result = repo.GetRecommend();
            foreach (var item in result)
            {
                if (item.PId==90087)
                {
                    b = true;
                }
            }
            Assert.IsTrue(b);
            Assert.IsAssignableFrom<List<Favourite>>(result);
        }
        [Test]
        public void GetRecommShouldFail()
        {
            var res = repo.GetRecommend();
            Assert.IsNotAssignableFrom<Favourite>(res);
        }
        [Test]
        public void AvailableFavShouldSuccess()
        {
            var res = repo.AddFavourite(new Favourite() { Name = "Sachin Tendulkar", FullName = "Sachin Ramesh Tendulkar", PId = 90087, UserId = "2870" });
            string c = "2870";
            var result = repo.AvailableFav(c);
            Assert.IsAssignableFrom<Favourite>(result);

        }
        [Test]
        public void AvailableFavShouldFail()
        {
            var res = repo.AddFavourite(new Favourite() { Name = "Sachin Tendulkar", FullName = "Sachin Ramesh Tendulkar", PId = 90087, UserId = "2870" });
            string c = "33335";
            var result = repo.AvailableFav(c);
            Assert.IsNotAssignableFrom<Favourite>(result);

        }
        [Test]
        public void NullFavouriteShouldsuccess()
        {
            var res= repo.AddFavourite(new Favourite() { Name = "Sachin Tendulkar", FullName = "Sachin Ramesh Tendulkar", PId = 90087, UserId = "35320" });
            var result=repo.NullFavourite(new Favourite() { Name = "Sachin Tendulkar", FullName = "Sachin Ramesh Tendulkar", PId =90087, UserId = "35320" });
            Assert.IsNotNull(result);
            //Assert.IsAssignableFrom<Favourite>(result);
        }
        [Test]
        public void NullFavouriteShouldNotsuccess()
        {

            var res = repo.AddFavourite(new Favourite() { Name = "Sachin Tendulkar", FullName = "Sachin Ramesh Tendulkar", PId = 90087, UserId = "35320" });
            var result = repo.NullFavourite(new Favourite() { Name = "Sachin Tendulkar", FullName = "Sachin Ramesh Tendulkar", PId = 100, UserId = "100" });
            Assert.IsNull(result);
        }
        [Test]
        public void  DeleteSuccess()
        {
            var res = repo.AddFavourite(new Favourite() { Name = "Sachin Tendulkar", FullName = "Sachin Ramesh Tendulkar", PId = 90087, UserId = "35320" });
            var s = repo.DeleteFavourite(90087,"35320");
            Assert.IsTrue(s);
        }
       /* [Test]
        public void DeleteFail()
        {
           // var res = repo.AddFavourite(new Favourite() { Name = "Sachin Tendulkar", FullName = "Sachin Ramesh Tendulkar", PId = 90080, UserId = "33335" });
          var result= new Favourite() { Name = "Sachin Tendulkar", FullName = "Sachin Ramesh Tendulkar", PId = 200, UserId = "200" };
            var s = repo.DeleteFavourite(result);
            Assert.Is(s);
        }*/
       }
}

