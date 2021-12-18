using Microsoft.AspNetCore.Mvc;
using Zamay.Domain;
using Zamay.Repository;

namespace Zamay.Controllers
{
    [ApiController]
    [Route("/visitor")]
    public class VisitorController : ControllerBase
    {
        [HttpPut("Enter")]
        public ArrivalTime Create(ArrivalTime arrivalTime)
        {
            Storage.ArrivalTimeStorage.Create(arrivalTime);
            return arrivalTime;
        }

        [HttpPut("Exit")]
        public LeavingTime Read(LeavingTime leavingTime)
        {
            Storage.LeavingTimeStorage.Create(leavingTime);
            return leavingTime; // Метод для выхода
        }

        [HttpGet("Restoring-pass")]
        public string RestoringAPass(string str)
        {
            return str; // Метод для восстановления пропуска
        }

        [HttpPut("Register")]
        public Visitor Create(Visitor visitor)
        {
            Storage.VisitorStorage.Create(visitor);
            return visitor; // Метод для регистрации в общежитии
        }
    }
}