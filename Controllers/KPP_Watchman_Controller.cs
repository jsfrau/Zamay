using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Zamay.Controllers
{
    [ApiController]
    [Route("/watchman")]
    public class Vahter : ControllerBase
    {
        [HttpGet("Exit-Or-Enter-Time-Register")]
        public string ExitOrEnterTimeRegister(string str)
        {
            return str; // Метод для регистрации времени прибытия или отбытия
        }
        [HttpGet("Issuing-pass")]
        public string IssuingPass(string str)
        {
            return str; // Метод для выдачи пропуска
        }
        
    }
}
