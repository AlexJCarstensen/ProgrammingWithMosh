using System;

namespace WorkflowEngine
{
    public class VideoWorkflow : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("this is video workflow");
        }
    }
}