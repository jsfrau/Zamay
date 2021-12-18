using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamay.Domain;

namespace Zamay.Repository
{
    public class Storage
    {
        public static VisitorStorage VisitorStorage { get; } = new VisitorStorage();
        public static ArrivalTimeStorage ArrivalTimeStorage { get; } = new ArrivalTimeStorage();
        public static LeavingTimeStorage LeavingTimeStorage { get; } = new LeavingTimeStorage();
        public static DocumentStorage DocumentStorage { get; } = new DocumentStorage();
        public static PassportStorage PassportStorage { get; } = new PassportStorage();
        public static PassStorage PassStorage { get; } = new PassStorage();
        public static PeriodOfStayStorage PeriodOfStayStorage { get; } = new PeriodOfStayStorage();
        public static ResidentStorage ResidentStorage { get; } = new ResidentStorage();
        public static RoomStorage RoomStorage { get; } = new RoomStorage();
        public static SettlingInStorage SettlingInStorage { get; } = new SettlingInStorage();
    };
}
