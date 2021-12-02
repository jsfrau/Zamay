using System;
using Zamay.Domains;

namespace Zamay.Domains
{
    public class PeriodOfStay
    {
        public int PeriodCode;
        public Resident Resident;
        public Room Room;
        public DateTime ArrivalDate;
        public DateTime LeavingDate;
    }
}