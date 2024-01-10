using System;
using System.Collections.Generic;
namespace task3
{
    class Program
    {
        static void Main()
        {
            string numOfTask;
            string description;
            string IsComplited;

            /*Console.WriteLine("введите данные: ");
            var
            List<List<string>> list = new List<List<string>>();
            Console.Write("Номер заказа: ");
            numOfTask =  Console.ReadLine();
            while (numOfTask != null)
            {
                Console.Write("Описание: ");
                description = Console.ReadLine();
                Console.Write("Выпонен? ");
                IsComplited = Console.ReadLine();
                list.Add(new List<string> { numOfTask, description, IsComplited });






                Console.Write("Номер заказа: ");
                numOfTask = Console.ReadLine();
            }
           */

            var numOfTasksList = new List<string>();
            var descriptionList = new List<string>();
            var isComplitedList = new List<string>();

            Console.WriteLine("введите данные: ");
            Console.Write("Номер заказа: ");
            numOfTask = Console.ReadLine();
            while (numOfTask != "")
            {
                Console.Write("Описание: ");
                description = Console.ReadLine();
                Console.Write("Выпонен? ");
                IsComplited = Console.ReadLine();

                numOfTasksList.Add(numOfTask);
                descriptionList.Add(description);
                isComplitedList.Add(IsComplited);

                Console.Write("\nНомер заказа: ");
                numOfTask = Console.ReadLine();

            }
           
           var sortedList =numOfTasksList.Select(int.Parse).ToList();
            sortedList.Sort();
            foreach (var i in sortedList)
            {
                Console.WriteLine(i + " " + numOfTask.IndexOf(i.ToString()));
            }
            Console.WriteLine(numOfTask.IndexOf('1'));
            



        }
    }
}