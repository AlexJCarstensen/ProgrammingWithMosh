using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new WorkflowEngine();

            engine.AddWorkFlow(new DbWorkflow());
            engine.Run();
            engine.AddWorkFlow(new VideoWorkflow());
            engine.Run();
        }
    }
}
