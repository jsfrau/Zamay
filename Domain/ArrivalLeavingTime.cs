using System;
using Zamay.Domain;

namespace Zamay.Domain
{
    public class ArrivalLeavingTime
    {
        public int ArrivalLeavingTimeNumber { get; set; }
        public DateTime EnterTime { get; set; }
        public DateTime LeaveTime { get; set; }
        public Pass Pass { get; set; }
    }
}