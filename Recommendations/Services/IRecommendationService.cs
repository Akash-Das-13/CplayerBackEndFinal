using Recommendations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recommendations.Services
{
    public interface IRecommendationService
    {
        Task<List<Data>> GetRecommendations();
    }
}
