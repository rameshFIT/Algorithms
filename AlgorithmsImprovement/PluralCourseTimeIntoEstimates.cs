using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsImprovement
{
    public static class PluralCourseTimeIntoEstimates
    {
        static double rapMT = 23.68;
        static double rap = 98.57;
        static double daysGoalHours = 6;
        static double totalSecHours = 3600;
        static double totalSecMins = 60;
        public static void PerformPluralEstimateOperation()
        {
            try
            {
                string timeHMS = Console.ReadLine();
                if(!timeHMS.Contains(','))
                {
                    var resultSeconds = CalculatepluralTimetoSeconds(timeHMS);
                    var rapMTSeconds = resultSeconds * rapMT;
                    var rapSeconds = resultSeconds * rap;
                    var resultRAPMT = CalculateTimeinHoursMinSec(rapMTSeconds);
                    var resultRAP = CalculateTimeinHoursMinSec(rapSeconds);
                    var rapMTDays = ConvertEstimateToDays(rapMTSeconds);
                    var rapDays = ConvertEstimateToDays(rapSeconds);
                    Console.WriteLine($"RAP(MT): Estimate is {resultRAPMT} or {rapMTDays} Day(s) and RAP: Estimate is {resultRAP} or {rapDays} Day(s).");
                }
                else
                {
                    var resultTotalTimeSeconds = AddAllTime(timeHMS);
                    var resultTotalTime = CalculateTimeinHoursMinSec(resultTotalTimeSeconds);
                    Console.WriteLine($"The Final Value of Total time entered is {resultTotalTime}");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }

        private static double AddAllTime(string timesHMS)
        {            
            var timesCollection = timesHMS.Split(',');
            var totalTime = 0.0;
            foreach (var item in timesCollection)
            {
                var resultSeconds = CalculatepluralTimetoSeconds(item);
                totalTime += resultSeconds;
            }
            return totalTime;
        }

        private static double ConvertEstimateToDays(double totalSecondsValue)
        {
            try
            {
                return totalSecondsValue / (daysGoalHours * totalSecHours);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            return 0;
        }

        private static string CalculateTimeinHoursMinSec(double totalSeconds)
        {
            try
            {
                var tDoubleHours = totalSeconds / totalSecHours;
                var tHours = (int)tDoubleHours;
                var tLeftSecInH = totalSeconds - (tHours * totalSecHours);
                var tDoublemins = tLeftSecInH / totalSecMins;
                var tMins = (int)tDoublemins;
                var tsecs = tLeftSecInH - (tMins * totalSecMins);
                return string.Concat(tHours, ':', tMins, ':', tsecs);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            return "";
        }

        private static double CalculatepluralTimetoSeconds(string pluralTime)
        {
            try
            {
                var timeArray = pluralTime.Split(':');
                double valueHoursTosec = 0;
                double valueMinTosec = 0;
                double valueTosec = 0;

                for (int i = 0; i < timeArray.Length; i++)
                {
                    ConvertToHoursMinSec(timeArray, ref valueHoursTosec, ref valueMinTosec, ref valueTosec, i);
                }
                return valueHoursTosec + valueMinTosec + valueTosec;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();

            }
            return 0;
        }

        private static void ConvertToHoursMinSec(string[] timeArray, ref double valueHoursTosec, ref double valueMinTosec, ref double valueTosec, int i)
        {
            try
            {
                if (i == 0)
                {
                    valueHoursTosec = Convert.ToDouble(timeArray[i]) * totalSecHours;
                }

                if (i == 1)
                {
                    valueMinTosec = Convert.ToDouble(timeArray[i]) * totalSecMins;
                }

                if (i == 2)
                {
                    valueTosec = Convert.ToDouble(timeArray[i]);
                }
            }

            catch (FormatException ex)
            {
                //We can add specif details on How to resolve this or in details. specifc
                //exception messages always good for easy understanding.
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}

