using System;

namespace Zamay.Domain
{
    public class LeavingTime
    {
        public int LeavingTimeNumber { get; set; }
        public DateTime LeaveTime { get; set; }
        public Pass Pass { get; set; }
    }
}