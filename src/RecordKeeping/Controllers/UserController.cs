using Microsoft.AspNetCore.Mvc;
using RecordKeeping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecordKeeping.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<User> Users()
        {
            return Enumerable.Range(1, 5).Select(index => new User
            {
                UserId = index,
                Username = "",
                Password = "",
                Firstname = "",
                Lastname = "",
                DateOfBirth = null,
                Email = "",
                Phone = "",
                Mobile = "",
            });
        }
    }
}
