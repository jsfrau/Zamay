using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Zamay.Controllers
{
    [ApiController]
    [Route("controller/commandant")]
    public class Komendant : ControllerBase
    {
        [HttpGet("Settlement-of-students")]
        public string SettlementOfStudents(string str)
        {
            return str; // Метод для заселения студента
        }
        [HttpGet("Issue-a-pass")]
        public string IssueAPass(string str)
        {
            return str; // Метод для выписания пропуска
        }
    }
}
