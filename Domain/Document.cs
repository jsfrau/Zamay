using System;
using Zamay.Domain;

namespace Zamay.Domain
{
    public class Document
    {
        public int DocumentNumber { get; set; }
        public Passport Passport { get; set; }
        public int INN { get; set; }
        public bool MedicalReport { get; set; }
    }
}