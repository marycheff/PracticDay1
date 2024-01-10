namespace task1
{
    class Program
    {
        static void Main()
        {
            var arr = Console.ReadLine().Split(' ');
            string stringNum = arr[0];
            stringNum = stringNum.Replace('.', ',');
            double doubleNum = double.Parse(stringNum);
            string value = arr[1];
   
            if (value == "ha")
            {
                Console.WriteLine( "Результат: " + doubleNum / 100  + " km2");
            }
            else if (value == "km2")
            {
                Console.WriteLine("Результат: " + doubleNum * 100 + " ha");
            }
        }
    }
}
