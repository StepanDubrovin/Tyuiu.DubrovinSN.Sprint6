using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DubrovinSN.Sprint6.Task1.V16.Lib
{
    public class DataService : ISprint6Task1V16
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double F;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {

                F = Math.Round((Math.Sin((double)x)) / ((double)x + 1.2) + Math.Cos((double)x) * 7 * (double)x - 2, 2);
                valueArray[count] = F;
                count++;

            }
            return valueArray;
        }
    }
}
