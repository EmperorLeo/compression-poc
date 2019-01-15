using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompressionApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CompressionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<LeoUser> GetLeoUsers(int? howMany)
        {
            if (!howMany.HasValue)
            {
                howMany = 10;
            }

            var users = new LeoUser[howMany.Value];
            for (var i = 0; i < howMany; i++)
            {
                users[i] = new LeoUser
                {
                    UserId = i + 1,
                    AnActualGuid = Guid.NewGuid(),
                    FunName = "",
                    CotangentJobTitleId = i % 30,
                    SuperAwesomeComments = "",
                    IsUserInGoodStandingWithLeo = i % 3 != 0,
                    DayOfReckoning = DateTime.Now.AddDays(i),
                    ItsASnowflake = (ulong)((i + 1) << 2)
                };
            }
            return users;
        }
    }
}
