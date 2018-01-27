using System;

namespace Typy
{
    class Program
    {
        static void GiveName(ref Diary diary)
        {
            diary = new Diary();
            diary.Name = " Nowy Dzienniczek Marcina";
        }

        static void IncrementNumber(out int number)
        {
            number = 42;
        }

        static void Main(string[] args)
        {
            Diary d1 = new Diary();
            Diary d2 = d1;

            GiveName(ref d2);

            Console.WriteLine(d2.Name);

            int x1;
            IncrementNumber(out x1);

            Console.WriteLine(x1);

            DateTime d;

            string name1 = "Marcin";
            string name2 = "marcin";

            bool areEqual = name1.Equals(name2, StringComparison.CurrentCulture);
            Console.WriteLine(areEqual);
        }
    }
}
