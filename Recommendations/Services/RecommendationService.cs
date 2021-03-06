﻿using Recommendations.Models;
using Recommendations.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recommendations.Services
{
    public class RecommendationService : IRecommendationService
    {
        private readonly IRecommendationRepository repo;
        public RecommendationService(IRecommendationRepository _repo)
        {
            repo = _repo;
        }

        public Task<List<Data>> GetRecommendations()
        {
            return repo.GetRecommendations();
        }
    }
}
