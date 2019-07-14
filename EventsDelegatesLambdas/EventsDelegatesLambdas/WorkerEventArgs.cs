using System;

namespace EventsDelegatesLambdas
{
    public class WorkerEventArgs : EventArgs
    {
        public int WorkingHours { get; set; }
        public string Complaint { get; set; }

        public WorkerEventArgs(int workingHours, string complaint)
        {
            WorkingHours = workingHours;
            Complaint = complaint;
        }
    }
}