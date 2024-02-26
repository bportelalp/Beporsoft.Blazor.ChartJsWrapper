﻿namespace Beporsoft.Blazor.Charts.SampleData
{
    public class RandomDataGen
    {

        public static IEnumerable<int> GetNumberSeries(int start, int end)
        {
            return Enumerable.Range(start, end);
        }

        public static IEnumerable<double> GetNumberSerie(double start, double end, double step)
        {
            for (double i = start; i <= end; i += step)
            {
                yield return i;
            }
        }


        public static IEnumerable<int> GetIntegerSamples(int min, int max, int amount)
        {
            var rnd = new Random();
            for (int i = 0; i < amount; i++)
            {
                yield return rnd.Next(min, max);
            }
        }

        public static IEnumerable<double> GetDoubleSamples(double min, double max, int amount)
        {
            var rnd = new Random();
            for (int i = 0; i < amount; i++)
            {
                yield return ((max + min) / 2.0) + (max - min) * (0.5 - rnd.NextDouble());
            }
        }

        public static IEnumerable<double> GetDoubleLinearSamples(double min, double max, int amount)
        {
            double slope = (max - min) / amount;

            double fx(double x) => slope * x + min;

            for(int i = 0; i <= amount; i++)
            {
                yield return fx(i);
            }
        }

        public static IEnumerable<string> GetMonths(int amount)
        {
            var year = DateTime.Now.Year;
            DateTime start = new DateTime(year, 1, 1);
            List<DateTime> dates = new List<DateTime>();
            foreach (var number in Enumerable.Range(0, amount))
            {
                DateTime nextMonth = start.AddMonths(number);
                dates.Add(nextMonth);
            }
            return dates.Select(d => d.ToString(System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.YearMonthPattern)).ToList();
        }


    }
}