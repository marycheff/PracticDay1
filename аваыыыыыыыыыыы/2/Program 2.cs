using System;
using System.Collections.Generic;
namespace task2
{
    class Program
    {
        static void Main()
        {
            const string LINE = "\n==========\n";
            Console.WriteLine("Введите шаблон: ");
            var list = new List<string>();
            var str = Console.ReadLine();
            while (str != "")
            {
                list.Add(str);
                str = Console.ReadLine();
            }

            Console.WriteLine("Введите кол-во писем: ");
            int numOfLetters = int.Parse(Console.ReadLine());
            var lastnames = new string[numOfLetters];
            var coupons = new string[numOfLetters];

            for (int i = 0; i < numOfLetters; i++)
            {
                Console.WriteLine("LASTNAME " + (i + 1) + ":");
                string inputLastname = Console.ReadLine();
                lastnames[i] = inputLastname;
                Console.WriteLine("COUPON " + (i + 1) + ":");
                string inputCoupon = Console.ReadLine();
                coupons[i] = inputCoupon;
            }
            
            Console.WriteLine("ВАШИ ПИСЬМА" + '\n' + "_________" + '\n');
            for (int i = 0; i < numOfLetters; i++)
            {
                var resultList = new List<string>();
                foreach (var item in list)
                {
                    var resultItem = item.Replace("%LASTNAME%", lastnames[i]).Replace("%COUPON%", coupons[i]).Replace("%LINE%", LINE);

                    resultList.Add(resultItem);
                }
                Console.WriteLine("ПИСЬМО " + (i + 1));
                foreach (var item in resultList)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
