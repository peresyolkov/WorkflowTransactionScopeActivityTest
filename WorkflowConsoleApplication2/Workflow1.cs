using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;

using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace WorkflowConsoleApplication2
{
  public sealed partial class Workflow1 : SequentialWorkflowActivity
  {
    public Workflow1()
    {
      InitializeComponent();
    }

    private void codeActivity1_ExecuteCode(object sender, EventArgs e)
    {
      Console.WriteLine("Workflow: going to start Transaction Scope Activity");
    }

    private void codeActivity2_ExecuteCode(object sender, EventArgs e)
    {
      Console.WriteLine("Inside Transaction Scope Activity");
    }

  }

}
