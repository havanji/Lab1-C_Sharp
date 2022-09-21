using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        enum test1Status { Pass = 1, Fail = 2, Blocked = 3, WP = 4, Unexecuted= 5 }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");

            //int day, month;
            //day = Convert.ToInt32(Console.ReadLine());
            //month = Convert.ToInt32(Console.ReadLine());
            //string result = (day > 0) && (day < 31) && (month > 0) && (month < 12) ?
            //"Значення можуть представляти день і місяць" : "Значення не можуть представляти день і місяць";
            //Console.WriteLine(result);

            //int hour;
            //h = Convert.ToInt32(Console.ReadLine());
            //string result = (h >= 4) && (h <= 10) ? "Доброго ранку!" : (h >= 11) && (h <= 18) ?
            //"Доброго дня!" : (h >= 19) && (h <= 23) ? "Доброго вечора!" : "Доброї ночі!";
            //Console.WriteLine(result);

            //int a = 4;
            //int b = 5;
            //Console.WriteLine(a + b);

            Console.WriteLine((test1Status)1);
            Console.ReadKey();
            Console.ReadLine();
        
    }
    }
}

