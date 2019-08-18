using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        const int COUNT = 3;

        static void Main(string[] args)
        {
            // true - (, false - )            
            var bracers = new BitArray(COUNT * 2);
            for (int i = 0; i < COUNT * 2; i++)
            {
                bracers[i] = i < COUNT;
            }

            ProcessBracers(bracers);
        }

        private static void ProcessBracers(BitArray bracers)
        {
            ResortBracers(bracers, COUNT, 0, 0, 0);
        }

        private static void ResortBracers(BitArray bracers, int count, int pos, int opened, int closed)
        {
            if (closed == count)
            {
                PrintoutBracersBitArray(bracers);
                return;
            }
            else
            {
                if (opened > closed)
                {
                    bracers[pos] = false;
                    ResortBracers(bracers, count, pos + 1, opened, closed + 1);
                }

                if (opened < count)
                {
                    bracers[pos] = true;
                    ResortBracers(bracers, count, pos + 1, opened + 1, closed);
                }
            }
        }

        static void PrintoutBracersBitArray(BitArray bracersBitArray)
        {
            foreach (var bit in bracersBitArray)
            {
                Console.Write((bool)bit ? "(" : ")");
            }

            Console.WriteLine();
        }
    }
}
