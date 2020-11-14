using NUnit.Framework;
using Recommendations.Models;
using Recommendations.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace test.Repository
{
    public class RecommendationRepositoryTest
    {
        private readonly IRecommendationRepository repo;
        public RecommendationRepositoryTest()
        {
            //DatabaseFixture fixture = new DatabaseFixture();
            repo = new RecommendationRepository();
        }
        [Test]
        public void GetRecommendShouldSuccess()
        {
            var res = repo.GetRecommendations();
            Assert.IsAssignableFrom<Task<List<Data>>>(res);
        }
        [Test]
        public void GetRecommendShouldfail()
        {
            var res = repo.GetRecommendations();
            Assert.IsNotAssignableFrom<List<Data>>(res);
        }
    }
}
