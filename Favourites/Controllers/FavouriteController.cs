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

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Favourites.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class FavouriteController : ControllerBase
    {
        public readonly IFavouriteService service;
        public FavouriteController(IFavouriteService _service)
        {
            service = _service;
        }
        // GET: api/<FavouriteController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(service.GetFavourites());
            }
            catch(Exception e)
            {
                return StatusCode(500, JsonConvert.SerializeObject(e.Message));
            }
        }

        // GET api/<FavouriteController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(service.GetFavourite(id));
            }
            catch(PlayerNotFoundException p)
            {
                return NotFound(JsonConvert.SerializeObject(p.Message));
            }
            
        }
        [HttpGet("{userId}")]
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

        }


        // POST api/<FavouriteController>
        [HttpPost]
        public IActionResult Post([FromBody] Favourite favourite)
        { 
            try
            {
                
                return Ok(service.AddFavourite(favourite));
            }
            catch(PlayerAlreadyExistsException p)
            {
                return StatusCode(403, JsonConvert.SerializeObject(p.Message));
            }
            catch(Exception e)
            {
                return StatusCode(500, JsonConvert.SerializeObject(e.Message));
            }
        }

        // PUT api/<FavouriteController>/5
        

        // DELETE api/<FavouriteController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok(service.DeleteFavourite(id));
            }
            catch (PlayerNotFoundException p)
            {
                return NotFound(JsonConvert.SerializeObject(p.Message));
            }
            
        }
    }
}
