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
            //PassByValueAndRef();

            Immutable();


        }

        private static void Immutable()
        {
            string name = " Marcin ";
            name = name.Trim();

            DateTime date = new DateTime(2015, 3, 10);
            date = date.AddHours(48);

            Console.WriteLine(name);
            Console.WriteLine(date);
        }

        private static void PassByValueAndRef()
        {
            Diary d1 = new Diary();
            Diary d2 = d1;

            GiveName(ref d2);

            Console.WriteLine(d2.Name);

            int x1;
            IncrementNumber(out x1);

            Console.WriteLine(x1);
        }
    }
}
