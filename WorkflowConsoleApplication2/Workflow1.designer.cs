using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Reflection;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace WorkflowConsoleApplication2
{
  partial class Workflow1
  {
    #region Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCode]
    [System.CodeDom.Compiler.GeneratedCode("", "")]
    private void InitializeComponent()
    {
      this.CanModifyActivities = true;
      this.codeActivity1 = new System.Workflow.Activities.CodeActivity();
      this.transactionScopeActivity1 = new System.Workflow.ComponentModel.TransactionScopeActivity();
      // 
      // codeActivity1
      // 
      this.codeActivity1.Name = "codeActivity1";
      this.codeActivity1.ExecuteCode += new System.EventHandler(this.codeActivity1_ExecuteCode);
      // 
      // transactionScopeActivity1
      // 
      this.transactionScopeActivity1.Activities.Add(this.codeActivity1);
      this.transactionScopeActivity1.Name = "transactionScopeActivity1";
      this.transactionScopeActivity1.TransactionOptions.IsolationLevel = System.Transactions.IsolationLevel.Serializable;
      this.transactionScopeActivity1.TransactionOptions.TimeoutDuration = System.TimeSpan.Parse("00:00:05");
      // 
      // Workflow1
      // 
      this.Activities.Add(this.transactionScopeActivity1);
      this.Name = "Workflow1";
      this.CanModifyActivities = false;

    }

    #endregion

    private CodeActivity codeActivity1;

    private TransactionScopeActivity transactionScopeActivity1;

















  }
}
