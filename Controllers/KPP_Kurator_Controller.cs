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
    public class Kurator : ControllerBase
    {
        [HttpGet("LessonsVisitingControl")]
        public string LessonsVisitingControl(string str)
        {
            return str; // Метод для контроля посещения лекций
        }
        [HttpGet("residingplace")]
        public string residingplace(string str)
        {
            return str; // Метод для того чтобы узнать где проживает студент
        }
    }
}
