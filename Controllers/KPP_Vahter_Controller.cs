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
    public class Vahter : ControllerBase
    {
        [HttpGet("ExitOrEnterTimeRegister")]
        public string ExitOrEnterTimeRegister(string str)
        {
            return str; // Метод для регистрации времени прибытия или отбытия
        }
        [HttpGet("IssuingApass")]
        public string IssuingApass(string str)
        {
            return str; // Метод для выдачи пропуска
        }
        
    }
}
