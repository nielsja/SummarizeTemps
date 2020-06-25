using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SummarizeTempsObjects
{
    public class TempCalculationEngine
    {
        List<int> _temperatures;
        public TempCalculationEngine(List<int> temperatures)
        {
            _temperatures = temperatures;
        }

        public int AverageTemperature()
        {
            // add logic to calculate the average
            int average = -1;

            if (_temperatures != null && _temperatures.Count > 0)
            {
                int sum = 0;
                int count = 0;

                for (int i = 0; i < _temperatures.Count; i++)
                {
                    sum += _temperatures[i];
                    count++;
                }

                if (count > 0)
                {
                    average = sum / count;
                }
            }

            return average; // <-- Replace this with the actual average
        }

        public int TempsAboveThreshold(int threshold)
        {
            // add logic to calculate temps above the threshold
            int countAboveThreshold = 0;

            if (_temperatures != null && _temperatures.Count > 0)
            {
                for (int i = 0; i < _temperatures.Count; i++)
                {
                    if (_temperatures[i] > threshold)
                    {
                        countAboveThreshold++;
                    }
                }
            }

            return countAboveThreshold; // <-- Replace this with the number
        }

        public int TempsBelowThreshold(int threshold)
        {
            // add logic to calculate and return temps below the threshold
            int countBelowThreshold = 0;

            if (_temperatures != null && _temperatures.Count > 0)
            {
                for (int i = 0; i < _temperatures.Count; i++)
                {
                    if (_temperatures[i] < threshold)
                    {
                        countBelowThreshold++;
                    }
                }
            }

            return countBelowThreshold; // <-- Replace this with the number
        }

        public int TempsAtThreshold(int threshold)
        {
            // add logic to calculate and return temps at the threshold
            int countAtThreshold = 0;

            if (_temperatures != null && _temperatures.Count > 0)
            {
                for (int i = 0; i < _temperatures.Count; i++)
                {
                    if (_temperatures[i] == threshold)
                    {
                        countAtThreshold++;
                    }
                }
            }

            return countAtThreshold; // <-- Replace this with the number
        }

        public int NumberOfTemperatures()
        {
            // add logic to return the number of temparature readings
            int count = 0;

            if (_temperatures != null && _temperatures.Count > 0)
            {
                count = _temperatures.Count;
            }

            return count; // <-- Replace this with the number
        }
    }
}
