﻿using Recommendations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recommendations.Repositories
{
   public interface IRecommendationRepository
    {
        Task<List<Data>> GetRecommendations();
        
    }
}
