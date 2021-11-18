using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Zamay.Controllers
{
    [ApiController]
    [Route("/visitor")]
    public class Visitor : ControllerBase
    {
        [HttpGet("Enter")]
        public string Enter(string str)
        {
            return str; // Метод для входа выхода
        }
        [HttpGet("Exit")]
        public string Exit(string str)
        {
            return str; // Метод для выхода
        }
        [HttpGet("Restoring-pass")]
        public string RestoringAPass(string str)
        {
            return str; // Метод для восстановления пропуска
        }
        [HttpGet("Register")]
        public string Register(string str)
        {
            return str; // Метод для регистрации в общежитии
        }
    }
}
