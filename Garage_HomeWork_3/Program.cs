using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_HomeWork_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(17));


            if (CalcAvg(60,70,80,30) >= 60)
            {
                Console.WriteLine("Mezun oldunuz");
            }
            else
            {
                Console.WriteLine("Mezun ola bilmediniz");
            }

        }

        static bool IsPrime(int value)
        {
            if (value < 2) return false;
            for (int i = 2; i < value; i++)
            {
                if (value%i == 0) return false;
            }
            return true;
        }

        static double CalcAvg (params int[] arr)
        {

            if (arr.Length == 0)
            {
                return 0; 
            }

            int sum = 0;

            foreach (int i in arr)
            {
                sum += i;
            }

            return sum / arr.Length;
        }


    }
}