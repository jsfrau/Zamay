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
    public class Komendant : ControllerBase
    {
        [HttpGet("ListOfRooms")]
        public string ListOfRooms(string str)
        {
            return str; // Метод для ведения списка комнат
        }
        [HttpGet("ListOfStudents")]
        public string ListOfStudents(string str)
        {
            return str; // Метод для ведения списка проживающих
        }
        [HttpGet("RoomNumber")]
        public string RoomNumber(string str)
        {
            return str; // Метод для того чтобы узнать в какой комнате живет студент
        }
        [HttpGet("TimeControl")]
        public string TimeControl(string str)
        {
            return str; // Метод для контроля времени прибытия и отбытия
        }
        [HttpGet("PassDelete")]
        public string PassDelete(string str)
        {
            return str; // Метод для аннулирования пропуска
        }
    }
}
