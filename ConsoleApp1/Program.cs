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
        enum HTTPError
        { 
            Bad_Request = 400,
            Unauthorized = 401,
            Payment_Required = 402,
            Forbidden= 403,
            Not_Found = 404
            
        }
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World");

            //Task 1.1

            int day, month;
            day = Convert.ToInt32(Console.ReadLine());
            month = Convert.ToInt32(Console.ReadLine());
            string result = (day > 0) && (day < 31) && (month > 0) && (month < 12) ?
            "Значення можуть представляти день і місяць" : "Значення не можуть представляти день і місяць";
            Console.WriteLine(result);

            //Task 1.2

            int number;
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number);

            //Task 1.3

            int hour;
            h = Convert.ToInt32(Console.ReadL ine());
            string result = (h >= 4) && (h <= 10) ? "Доброго ранку!" : (h >= 11) && (h <= 18) ?
            "Доброго дня!" : (h >= 19) && (h <= 23) ? "Доброго вечора!" : "Доброї ночі!";
            Console.WriteLine(result);

            //Task 1.4

            Console.WriteLine((test1Status)1);
            Console.ReadKey();
            Console.ReadLine();

            //Task 1.5



            //Task 2.1

            float n1, n2, n3;
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            string v_mezhax = (n1 >= -5) && (n1 <= 5) ? "Перше число в межах (-5:5)" : (n2 >= -5) && (n2 <= 5) ?
                "Друге число в межах (-5:5)" : (n2 >= -5) && (n2 <= 5) ? "Третє число в межах (-5:5)" :
                "Не одне з чисел не в межах (-5:5)";
            Console.WriteLine(v_mezhax);

            //Task 2.2

            int n1, n2, n3;
            Console.WriteLine("Введіть перше число");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть друге число");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть третє число");
            n3 = Convert.ToInt32(Console.ReadLine());

            int[] arr = { n1, n2, n3 };

            Console.WriteLine("Мінімальне число " + arr.Min());
            Console.WriteLine("Максимальне число " + arr.Max());

            //Task 2.3
            Console.WriteLine((HTTPError).404);
            Console.ReadKey();
            Console.ReadLine();*/

        }
    }
}

