using Zamay.Domain;
using System.Collections.Generic;


namespace Zamay.Domain
{
    public class LeavingTimeStorage
    {
        private Dictionary<int, LeavingTime> LeavingTimes { get; } = new Dictionary<int, LeavingTime>();

        public void Create(LeavingTime leavingTime)
        {
            LeavingTimes.Add(leavingTime.LeavingTimeNumber, leavingTime);
        }

        public LeavingTime Read(int leavingTimeNumber)
        {
            return LeavingTimes[leavingTimeNumber];
        }

        public LeavingTime Update(int leavingTimeNumber, LeavingTime newLeavingTime)
        {
            LeavingTimes[leavingTimeNumber] = new LeavingTime();
            return LeavingTimes[leavingTimeNumber];
        }

        public bool Delete(int leavingTimeNumber)
        {
            return LeavingTimes.Remove(leavingTimeNumber);
        }
    }
}