using Zamay.Domain;

namespace Zamay.Repository
{
    public class Storage
    {
        public static VisitorStorage VisitorStorage { get; } = new();
        public static ArrivalTimeStorage ArrivalTimeStorage { get; } = new();
        public static LeavingTimeStorage LeavingTimeStorage { get; } = new();
        public static DocumentStorage DocumentStorage { get; } = new();
        public static PassportStorage PassportStorage { get; } = new();
        public static PassStorage PassStorage { get; } = new();
        public static PeriodOfStayStorage PeriodOfStayStorage { get; } = new();
        public static ResidentStorage ResidentStorage { get; } = new();
        public static RoomStorage RoomStorage { get; } = new();
        public static SettlingInStorage SettlingInStorage { get; } = new();
    }
}