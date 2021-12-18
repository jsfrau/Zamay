using Zamay.Domain;
using System.Collections.Generic;


namespace Zamay.Domain
{
    public class ArrivalTimeStorage
    {
        private Dictionary<int, ArrivalTime> ArrivalTimes { get; } = new Dictionary<int, ArrivalTime>();

        public void Create(ArrivalTime arrivalTime)
        {
            ArrivalTimes.Add(arrivalTime.ArrivalTimeNumber, arrivalTime);
        }

        public ArrivalTime Read(int arrivalTimeNumber)
        {
            return ArrivalTimes[arrivalTimeNumber];
        }

        public ArrivalTime Update(int arrivalTimeNumber, ArrivalTime newArrivalTime)
        {
            ArrivalTimes[arrivalTimeNumber] = newArrivalTime;
            return ArrivalTimes[arrivalTimeNumber];
        }

        public bool Delete(int arrivalTimeNumber)
        {
            return ArrivalTimes.Remove(arrivalTimeNumber);
        }
    }
}