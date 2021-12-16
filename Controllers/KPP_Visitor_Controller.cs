using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Zamay;
using Zamay.Repository;
using Zamay.Domain;

namespace Zamay.Controllers
{
    [ApiController]
    [Route("/visitor")]
    public class VisitorController : ControllerBase
    {
        [HttpPut("Enter")]
        //public Visitor Create(Visitor visitor)
        //{
        //    return visitor;
        //}
        [HttpGet("Exit")]
        public Visitor Read(int VisitorNumber)
        {
            return Storage.VisitorStorage.Read(VisitorNumber); // Метод для выхода
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
