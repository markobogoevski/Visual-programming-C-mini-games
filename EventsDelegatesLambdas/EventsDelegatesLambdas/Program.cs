using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegatesLambdas
{

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }

    public delegate int OperationDelegate(int x, int y);
    class Program
    {
        public static event EventHandler<WorkerEventArgs> WorkerIsWorking;
        public static event EventHandler<WorkerEventArgs> WorkerFinishedWorking;

        public static void WorkingMessage(object sender,EventArgs e)
        {
            WorkerEventArgs args = e as WorkerEventArgs;
            if (args != null)
            {
                Console.WriteLine($"I am working {args.WorkingHours}hours...{args.Complaint}\n)");
            }
           
        }

        public static void WorkingFinishMessage(object sender, EventArgs e)
        {
            WorkerEventArgs args = e as WorkerEventArgs;
            if (args != null)
            {
                Console.WriteLine($"I finished working {args.WorkingHours} for hours...{args.Complaint}\n)");
            }

        }

        public static void Main(string[] args)
        {
            WorkerIsWorking += (s, e) => Console.WriteLine($"Working for {e.WorkingHours} hours..\n");
            WorkerIsWorking += WantMessage;
            WorkerFinishedWorking += WorkingFinishMessage;
            DoWork(5,"No complaint!");
            unchecked
            {

            }
            Action<int, int> add = (x, y) => Console.WriteLine(x+y);
            var processor = new ProcessData();
            processor.Process(5, 3, add);


            Console.ReadKey();
        }

        private static void WantMessage(object sender, WorkerEventArgs e)
        {
            WorkerEventArgs args = e as WorkerEventArgs;
            if (args != null)
            {
                Console.WriteLine($"I want working nothing\n");
            }
        }

        public static void DoWork(int workingHours,string complaint)
        {
            for (int i = 0; i < workingHours; i++)
            {
                Console.WriteLine("Working hour: "+(i+1));
                OnWorkerIsWorking(workingHours, complaint);
            }
            OnWorkerFinishedWorking(workingHours,complaint);
        }

        private static void OnWorkerFinishedWorking(int workingHours,string complaint)
        {
            WorkerFinishedWorking?.Invoke(null, new WorkerEventArgs(workingHours,complaint));
        }

        private static void OnWorkerIsWorking(int workingHours, string complaint)
        {
            WorkerIsWorking?.Invoke(null, new WorkerEventArgs(workingHours,complaint));
        }
    }
}
