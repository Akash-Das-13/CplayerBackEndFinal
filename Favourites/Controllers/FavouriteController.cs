using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Favourites.Exceptions;
using Favourites.Models;
using Favourites.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;



namespace Favourites.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FavouriteController : ControllerBase
    {
        public readonly IFavouriteService service;
        public FavouriteController(IFavouriteService _service)
        {
            service = _service;
        }

        [HttpGet]
        [Route("recommend")]
        public IActionResult GetRec()
        {
            try
            {
                return Ok(service.GetRecommend());
            }
            catch (PlayerNotFoundException p)
            {
                return StatusCode(404, JsonConvert.SerializeObject("Nothing to Recommend"));
            }
        }


        [Authorize]
        [HttpGet]
        [Route("{userId}")]
        public IActionResult Get(string userId)
        {
            try
            {
                return Ok(service.GetAllFavouritesByUserId(userId));
            }
            catch (PlayerNotFoundException p)
            {
                return NotFound(JsonConvert.SerializeObject(p.Message));
            }
            catch (Exception e)
            {
                return StatusCode(500, JsonConvert.SerializeObject(e.Message));
            }

        }


        [Authorize]
        [HttpPost]
        public IActionResult Post([FromBody] Favourite favourite)
        {
            try
            {

                return Ok(service.AddFavourite(favourite));
            }
            catch (PlayerAlreadyExistsException p)
            {
                return StatusCode(403, JsonConvert.SerializeObject(p.Message));
            }
            catch (Exception e)
            {
                return StatusCode(500, JsonConvert.SerializeObject(e.Message));
            }
        }

        [Authorize]
        [HttpDelete]
        [Route("{pId}/{userId}")]
        public IActionResult Delete(string pId, string userId)
        {
            try
            {
                int id = Convert.ToInt32(pId);
                return Ok(service.DeleteFavourite( id,  userId));
            }
            catch ( Exception e)
            {
                return NotFound(JsonConvert.SerializeObject(e.Message));
            }
            
        }
    }
}
