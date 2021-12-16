using Zamay.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Zamay.Repository
{
    public class VisitorStorage
    {
        private Dictionary<int, Visitor> visitors { get; } = new Dictionary<int, Visitor>();

        public void Create(Visitor visitor)
        {
            visitors.Add(visitor.VisitorNumber, visitor);
        }

        public Visitor Read(int visitorNumber)
        {
            return visitors[visitorNumber];
        }

        public Visitor Update(int visitorNumber, Visitor newVisitor)
        {
            visitors[visitorNumber] = newVisitor;
            return visitors[visitorNumber];
        }

        public bool Delete(int visitorNumber)
        {
            return visitors.Remove(visitorNumber);
        }
    }
}