using StackExchange.Redis;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace tasksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IConnectionMultiplexer _redis;

        public MainController(IConnectionMultiplexer redis)
        {
            _redis = redis;
        }
        
        [HttpGet]
        public ActionResult<string> GetAllTasks()
        {
            IDatabase db = _redis.GetDatabase();
            string value = db.StringGet("Hola");
            return Ok(value);
        }
    }
}