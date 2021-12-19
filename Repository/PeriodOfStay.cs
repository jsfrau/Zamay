using System;

namespace Zamay.Domain
{
    public class PeriodOfStayStorage
    {
        public DateTime ArrivalDate;
        public DateTime LeavingDate;
        public int PeriodCode;
        public Resident Resident;
        public Room Room;
    }
}