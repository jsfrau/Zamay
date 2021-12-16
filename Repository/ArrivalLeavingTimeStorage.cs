using Zamay.Domain;
using System.Collections.Generic;


namespace Zamay.Domain
{
    public class ArrivalLeavingTimeStorage
    {
        private Dictionary<int, ArrivalLeavingTime> ArrivalLeavingTimes { get; } = new Dictionary<int, ArrivalLeavingTime>();

        public void Create(ArrivalLeavingTime arrivalLeavingTime)
        {
            ArrivalLeavingTimes.Add(arrivalLeavingTime.ArrivalLeavingTimeNumber, arrivalLeavingTime);
        }

        public ArrivalLeavingTime Read(int ArrivalLeavingTimeNumber)
        {
            return ArrivalLeavingTimes[ArrivalLeavingTimeNumber];
        }

        public ArrivalLeavingTime Update(int ArrivalLeavingTimeNumber, ArrivalLeavingTime newArrivalLeavingTime)
        {
            ArrivalLeavingTimes[ArrivalLeavingTimeNumber] = newArrivalLeavingTime;
            return ArrivalLeavingTimes[ArrivalLeavingTimeNumber];
        }

        public bool Delete(int ArrivalLeavingTimeNumber)
        {
            return ArrivalLeavingTimes.Remove(ArrivalLeavingTimeNumber);
        }
    }