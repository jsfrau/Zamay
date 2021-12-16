using System;
using Zamay.Domain;

namespace Zamay.Domain
{
    public class PeriodOfStay
    {
        public int PeriodCode { get; set; }
        public Resident Resident { get; set; }
        public Room Room { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime LeavingDate { get; set; }
    }
}