using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static int GasStationIndex(int[] gas, int[] cost)
        {
            int index = 0;
            
            int tGas = 0;
            int tCost = 0;
            int diff = 0;

            for (int i = 0; i < gas.Length; ++i)
            {
                tGas += gas[i];
                tCost += cost[i];

                if (tGas < tCost)
                {
                    tGas = tCost = 0;
                    index = i + 1;
                }

                diff += gas[i] - cost[i];
            }

            return diff >= 0 ? index : -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GasStationIndex(new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5, 1, 2 }));
        }
    }
}
