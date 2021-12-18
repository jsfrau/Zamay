using System;
using Zamay.Domain;

namespace Zamay.Domain
{
    public class ArrivalTime
    {
        public int ArrivalTimeNumber { get; set; }
        public DateTime EnterTime { get; set; }
        public Pass Pass { get; set; }
    }
}