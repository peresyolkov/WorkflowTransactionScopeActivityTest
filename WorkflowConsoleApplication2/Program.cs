using System;
using System.Collections.Generic;

using System.Text;
using System.Threading;
using System.Workflow.Runtime;
using System.Workflow.Runtime.Hosting;

namespace WorkflowConsoleApplication2
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Starting Workflow");

      using (WorkflowRuntime workflowRuntime = new WorkflowRuntime())
      {
        // Run SQL scripts:
        // C:\Windows\Microsoft.NET\Framework\v3.0\Windows Workflow Foundation\SQL\en\SqlPersistenceService_Schema.sql
        // C:\Windows\Microsoft.NET\Framework\v3.0\Windows Workflow Foundation\SQL\en\SqlPersistenceService_Logic.sql

        SqlWorkflowPersistenceService sqlPersistenceService = new SqlWorkflowPersistenceService("Server=localhost;Database=NetMeter;User Id=sa;Password=MetraTech1;");
        workflowRuntime.AddService(sqlPersistenceService);
        workflowRuntime.AddService(new ConsoleTrackingService());

        AutoResetEvent waitHandle = new AutoResetEvent(false);
        workflowRuntime.WorkflowCompleted += delegate(object sender, WorkflowCompletedEventArgs e) { waitHandle.Set(); };
        workflowRuntime.WorkflowTerminated += delegate(object sender, WorkflowTerminatedEventArgs e)
        {
          Console.WriteLine(e.Exception.ToString());
          waitHandle.Set();
        };

        WorkflowInstance instance = workflowRuntime.CreateWorkflow(typeof(WorkflowConsoleApplication2.Workflow1));
        instance.Start();

        waitHandle.WaitOne();
      }

      Console.WriteLine("Workflow done");
      Console.ReadLine();
    }
  }
}
