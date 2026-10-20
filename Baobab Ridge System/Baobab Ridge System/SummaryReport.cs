using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baobab_Ridge_System
{
    // Calculates the animal summary and saves it to summary.txt
    internal class SummaryReport
    {
        // holds the txt file
        private const string SummaryFileName = "summary.txt";
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
        // calculates the avg of the age and recovery score and sets the totals
        public void Calculate(List <Animal> animals)
        { 
            ResetStatusCounts();
            TotalAnimals = animals.Count;
            //it checks that there is actualy animals
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
                if (StatusCounts.ContainsKey(animal.Status))
                {
                    StatusCounts[animal.Status]++;
                }
               
            }
            AvgAge = (double)ageSum / TotalAnimals;
            AvgRecoveryScore = (double)ageRecoveryScore / TotalAnimals;
        }
        //builds reports text
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
        // formats avg to 2 decimal places
        public string FormatAverage(double? value)
        {
            return value.HasValue? value.Value.ToString("F2",CultureInfo.InvariantCulture):"N/A";
        }
        

        // saves the summery on summary.txt
        public string SaveSummary()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,SummaryFileName);
                File.WriteAllText(path,BuildReportText());
                return "";
            }
            catch (UnauthorizedAccessException)
            {
                return "the summary.txt file is a read only file";
            }
            catch (IOException)
            {
                return "the summary file is open in a different program";
            }
        }
    }
}
