using Microsoft.AspNetCore.Mvc;

namespace Zamay.Controllers
{
    [ApiController]
    [Route("/commandant")]
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