using Zamay.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Zamay.Repository
{
    public class VisitorStorage
    {
        private Dictionary<int, Visitor> Visitors { get; } = new Dictionary<int, Visitor>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Visitor visitor)
        {
            Visitors.Add(visitor.VisitorNumber, visitor);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Visitor Read(int VisitorNumber)
        {
            return Visitors[VisitorNumber];
        }

        public Visitor Update(int VisitorNumber, Visitor newVisitor)
        {
            Visitors[VisitorNumber] = newVisitor;
            return Visitors[VisitorNumber];
        }

        public bool Delete(int VisitorNumber)
        {
            return Visitors.Remove(VisitorNumber);
        }
    }
}