using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recommendations.Models;
using Recommendations.Services;

namespace Recommendations.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RecommendationController : ControllerBase
    {
        private readonly IRecommendationService service;
        public RecommendationController(IRecommendationService _service)
        {
            service = _service;
        }
        [HttpGet]
        public Task<List<Data>> Get()
        {
            return service.GetRecommendations();
        }
        
    }
}
