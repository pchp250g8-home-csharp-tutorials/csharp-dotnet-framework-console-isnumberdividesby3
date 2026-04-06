using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsNumberDivideBy3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Input an Integer Number:");
            var strNum = Console.ReadLine();
            Int64.TryParse(strNum, out var iNum);
            var nSumDigits = 0L; var iVal = Math.Abs(iNum);
            while (iVal > 0)
            {
                nSumDigits += iVal % 10;
                iVal /= 10;
            }
            Console.WriteLine("The sum of digits of the number {0} is {1}", iNum, nSumDigits);
            if (nSumDigits % 3 == 0)
            {
                Console.WriteLine("The number {0} divides by 3", iNum);
            }
            else
            {
                Console.WriteLine("The number {0} does not divide by 3", iNum);
            }
            Console.Read();
        }
    }
}
