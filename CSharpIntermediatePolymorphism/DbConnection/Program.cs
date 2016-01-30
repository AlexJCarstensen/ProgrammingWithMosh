using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = new DbCommand(new OracleConnection("oracle"), "SaveChanges()" );
            command.Execute();

            var command1 = new DbCommand(new SqlConnection("SQL"), "Clear()" );
            command1.Execute();
            
        }
    }
}
