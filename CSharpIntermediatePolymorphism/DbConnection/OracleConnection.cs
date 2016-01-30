using System;

namespace DbConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Open()
        {
            Console.WriteLine($"{this.GetType().Name} Database open with the connectionstring {ConnectionString}");
        }

        public override void Close()
        {
            Console.WriteLine($"{this.GetType().Name} Database closed with the connectionstring {ConnectionString}");
        }
    }
}