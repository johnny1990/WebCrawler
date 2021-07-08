using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.ComponentModel;

namespace Library
{
    public class ThreadOperations
    {
        private AsyncOperation op; 
        private ReqObj ARec; 
        public event EventHandler<WorkItemCompletedEventArgs> Completed; 

  
        public ThreadOperations(ReqObj Rec)
        {
            ARec = Rec;
        }

        public void DoWork()
        {
            this.op = AsyncOperationManager.CreateOperation(null);
            ThreadPool.QueueUserWorkItem((o) => this.PerformWork(ARec));
        }

        private async void PerformWork(ReqObj rec)
        {

            ReqObj resultObj = await Web.SendWebRequest(rec);
            ARec.ResultCode = resultObj.ResultCode;
            ARec.XMLData = resultObj.XMLData;

            PostCompleted();
        }

        private void PostCompleted()
        {
            op.PostOperationCompleted((o) => this.OnCompleted(new WorkItemCompletedEventArgs(ARec)), ARec);
        }


        protected virtual void OnCompleted(WorkItemCompletedEventArgs Args)
        {
            EventHandler<WorkItemCompletedEventArgs> temp = Completed;
            if (temp != null)
            {
                temp.Invoke(this, Args);
            }
        }


    }


    public class WorkItemCompletedEventArgs : EventArgs
    {
        public ReqObj Result { get; set; }
        
        public WorkItemCompletedEventArgs(ReqObj result)
        {
            this.Result = result;
        }
    }
}

