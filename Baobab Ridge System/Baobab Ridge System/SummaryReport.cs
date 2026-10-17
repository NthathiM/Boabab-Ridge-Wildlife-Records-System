using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baobab_Ridge_System
{
    // Calculates the animal summary and saves it to summery.txt;
    internal class SummaryReport
    {
        public int TotalAnimals { get; set; }
        public double? AvgAge { get; set; }
        public double? AvgRecoveryScore { get; set; }
       public Dictionary<string, int> StatusCounts {  get; set; } = new Dictionary<string, int>();
        //resets status counts;
        private void ResetStatusCounts()
        {
            StatusCounts.Clear();
            string[] Statuses = {"Critical","Serious","Stable","Recovering","Release-Ready" };
            
            foreach  ( string status in Statuses)
            {
                StatusCounts[status] = 0;
            }
        }

    }
}
