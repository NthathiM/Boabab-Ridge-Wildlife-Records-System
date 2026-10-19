using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
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
        string[] Statuses = { "Critical", "Serious", "Stable", "Recovering", "Release-Ready" };
        //resets status counts;
        private void ResetStatusCounts()
        {
            StatusCounts.Clear();
            
            
            foreach  ( string status in Statuses)
            {
                StatusCounts[status] = 0;
            }
        }
        // calculates the avg of the age and recovery score
        public void Calculate(List <Animal> animals)
        { 
            ResetStatusCounts();
            TotalAnimals = animals.Count;
            //it checks that there is actualy animals;
            if (TotalAnimals == 0)
            {
                AvgAge = null;
                AvgRecoveryScore = null;
                return;
            }
            int ageSum = 0;
            int ageRecoveryScore = 0;
            // calculates the avg 
            foreach (var animal in animals)
            {
                ageSum += animal.Age;
                ageRecoveryScore += animal.RecoveryScore;
                StatusCounts[animal.Status]++;
            }
            AvgAge = (double)ageSum / TotalAnimals;
            AvgRecoveryScore = (double)ageRecoveryScore / TotalAnimals;
        }
        
        private string BuildReportText ()
        {
            StringBuilder report = new StringBuilder ();
            report.AppendLine("BAOBAB RIDGE WILDLIFE REHABILITATION CENTRE");
            report.AppendLine("ANIMAL SUMMARY REPORT");
            report.AppendLine("Generated: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm" ));
            report.AppendLine(new string('-',40));
            report.AppendLine("Total animals:".PadRight(26) + TotalAnimals);
            report.AppendLine("Average age (years):".PadRight(26) + FormatAverage(AvgAge));
            report.AppendLine("Average recovery score:".PadRight(26) + FormatAverage(AvgRecoveryScore));
            report.AppendLine(new string('-',40));
            report.AppendLine("Animals per status:");

            foreach (string status in Statuses)
            {
                report.AppendLine(("  " + status + ":").PadRight(26) + StatusCounts[status] );
            }

            return report.ToString();
        }
        private string FormatAverage(double? value)
        {
            return value.HasValue? value.Value.ToString("F2",CultureInfo.InvariantCulture):"N/A";
        }
    }
}
