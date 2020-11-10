using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PlayerAPI.Exceptions;
using PlayerAPI.Services;



namespace PlayerAPI.Controllers
{
    /*[Authorize]*/
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService service;

        public PlayerController(IPlayerService _service)
        {
            service = _service;
        }
        [HttpGet]
        [Route("id/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(service.GetPlayerByIdAsync(id));
            }
            catch (Exception e)
            {

                return StatusCode(401, JsonConvert.SerializeObject(e.Message));
            }
            
        }

        [HttpGet]
        [Route("name/{name}")]
        public IActionResult GetByName(string name)
        {
            try
            {
                return Ok(service.GetPlayerByNameAsync(name));
            }
            catch (Exception e)
            {

                return StatusCode(401, JsonConvert.SerializeObject(e.Message));
            }

        }






    }
}
