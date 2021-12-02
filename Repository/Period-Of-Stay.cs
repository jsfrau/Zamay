using System;
using Zamay.Domain;

namespace Zamay.Domain
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