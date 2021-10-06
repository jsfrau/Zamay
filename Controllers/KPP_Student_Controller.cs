using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Zamay.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Student : ControllerBase
    {
        [HttpGet("EnterOrExit")]
        public string EnterOrExit(string str)
        {
            return str; // Метод для входа выхода
        }
        [HttpGet("PassChange")]
        public string PassChange(string str)
        {
            return str; // Метод для замены пропуска
        }
        [HttpGet("Register")]
        public string Register(string str)
        {
            return str; // Метод для регистрации в общежитии
        }
    }
}
