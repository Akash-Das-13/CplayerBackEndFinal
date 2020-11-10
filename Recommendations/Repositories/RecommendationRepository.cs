using Recommendations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recommendations.Repositories
{
    public class RecommendationRepository : IRecommendationRepository
    {
        private readonly DataContext db;
        public RecommendationRepository(DataContext dbcontext)
        {
            db = dbcontext;
        }
        public int AddRecommendation(Recommendation recommendation)
        {
            db.Recommendations.Add(recommendation);
            return db.SaveChanges();
            
        }

        public List<Recommendation> GetRecommendations()
        {
            return db.Recommendations.ToList();
        }
    }
}
