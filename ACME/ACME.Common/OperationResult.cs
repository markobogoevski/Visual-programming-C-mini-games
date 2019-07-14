using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.Common
{
    public class OperationResult
    {
        public bool Success { get; set; }
        public List<string> Report { get; private set; }

        public OperationResult()
        {
            Success = true;
            Report = new List<string>();
        }

        public void AddErrorMessage(string v)
        {
            Report.Add(v);
        }

        public string PrintTrace()
        {
            StringBuilder stringBuilder = new StringBuilder();
            Report.ForEach(report => stringBuilder.Append(report).Append("\n"));
            return stringBuilder.ToString();
        }
    }
}
