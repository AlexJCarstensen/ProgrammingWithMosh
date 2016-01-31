using System;

namespace WorkflowEngine
{
    public class DbWorkflow : IWorkflow 
    {
        public void Execute()
        {
            Console.WriteLine("this is db workflow");
        }
    }
}