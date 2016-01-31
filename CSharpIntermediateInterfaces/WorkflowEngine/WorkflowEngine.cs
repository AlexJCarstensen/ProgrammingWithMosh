using System;
using System.Collections.Generic;

namespace WorkflowEngine
{
    public class WorkflowEngine
    {
        private readonly IList<IWorkflow> _workflowsList;

        public WorkflowEngine()
        {
            _workflowsList = new List<IWorkflow>();
        }

        public void Run()
        {
            foreach (var workflow1 in _workflowsList)
            {
                workflow1.Execute();
            }
        }

        public void AddWorkFlow(IWorkflow workflow)
        {
            _workflowsList.Add(workflow);
        }
    }
}