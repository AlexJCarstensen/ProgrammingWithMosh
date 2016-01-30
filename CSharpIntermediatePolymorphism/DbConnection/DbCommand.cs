using System;

namespace DbConnection
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _instruction;

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            
            if (dbConnection == null)
                throw new InvalidOperationException("No connection added");
            
            if(string.IsNullOrEmpty(instruction))
                throw new InvalidOperationException("no instruction added");

            _dbConnection = dbConnection;
            _instruction = instruction;

        }

        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine(_instruction);
            _dbConnection.Close();
        }
    }
}