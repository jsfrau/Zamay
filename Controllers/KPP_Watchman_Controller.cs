using Microsoft.AspNetCore.Mvc;
using Zamay.Domain;
using Zamay.Repository;
using static System.DateTime;

namespace Zamay.Controllers
{
    [ApiController]
    [Route("/watchman")]
    public class Vahter : ControllerBase
    {
        [HttpGet("RestorePass")]
        public string RestorePass(string str)
        {
            return str; // Метод для восстановления пропуска
        }

        [HttpPut("LeavingTimeRegister")]
        public string Create(LeavingTime leavingTime, int visitorNumber)
        {
            if (!Storage.VisitorStorage.Check(visitorNumber)) return "Scam";
            leavingTime.LeaveTime = Now;
            Storage.LeavingTimeStorage.Create(leavingTime);
            return leavingTime + " " + "Добавлено!";
        }

        [HttpPut("ArrivalTimeRegister")]
        public string Create(ArrivalTime arrivalTime, int visitorNumber)
        {
            if (!Storage.VisitorStorage.Check(visitorNumber)) return "Scam";
            arrivalTime.EnterTime = Now;
            Storage.ArrivalTimeStorage.Create(arrivalTime);
            return arrivalTime + " " + "Добавлено!";
        }
    }
}