namespace Zamay.Domain
{
    public class Resident
    {
        public int DocumentNumber { get; set; }
        public Passport Passport { get; set; }
        public int INN { get; set; }
        public bool MedicalReport { get; set; }
    }
}