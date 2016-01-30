using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace DbConnection
{
    public abstract class DbConnection
    {
        protected string ConnectionString { get; set; }
        private TimeSpan TimeOut { get; set; }

        protected DbConnection(string connectionString)
        {
            if(string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("No connectionString added");
            ConnectionString = connectionString;
        }

        public abstract void Open();

        public abstract void Close();


    }
}