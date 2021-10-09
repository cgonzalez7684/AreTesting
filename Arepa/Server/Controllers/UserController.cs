using Arepa.DAL.Interfaces;
using Arepa.Share.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arepa.Server.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IAdmSystem _admSystem;

        public UserController(IAdmSystem admSystem)
        {
            this._admSystem = admSystem;
        }

        [HttpGet]
        [ActionName("GetListUsers")]
        public IEnumerable<User> GetListUsers()
        {
            return _admSystem.GetUsers();
        }

        [HttpGet()]
        [ActionName("GetUserName")]
        public string GetUserName()
        {
            return _admSystem.GetUserName();
        }


    }
}
