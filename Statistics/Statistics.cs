using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public float sum = 0F, min = Single.MaxValue, max = Single.MinValue, average;
    
        public Stats CalculateStatistics(List<float> numbers) {
            Stats obj = new Stats();

            if (numbers.Count==0)
            {
                obj.min = Double.NaN;
                obj.max = Double.NaN;
                obj.average = Double.NaN;

                return obj;
            }

            for(int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            average = sum/numbers.Count;
            obj.min = min;
            obj.max = max;
            obj.average = average;

            return obj;
        }
    }

    public class Stats
    {
        public double min, max, average;
    }
}
