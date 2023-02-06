using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This file is made by EmJey
// Project: ExponentFunction
// FileName: ExponentFunction
// Date: 2023/02/06
// Email: emjeydev@gmail.com
// Github: emjeydev

namespace ExponentFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseNum, powNum;
            Console.Write("Base number: ");
            baseNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Powwer number: ");
            powNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetPow(baseNum, powNum));

            Console.ReadLine();
        }

        static int GetPow(int baseNum, int powNum)
        {
            int resutl = 1;

            for (int i = 0; i < powNum; i++)
            {
                resutl *= baseNum;
            }

            return resutl;
        }
    }
}
