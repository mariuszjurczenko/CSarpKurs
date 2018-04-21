using System;

namespace FlowControl
{
    class Program
    {
        private static int age;
        private static string name;

        static void Main(string[] args)
        {
            //instructionIf();
            //instructionSwitch();

            //instructionFor();
            //instructionDoWhileDo();
            //instructionForeach();

            int[] ages = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int age in ages)
            {
                if (age == 2)
                {
                    Console.WriteLine("Wiek wynosi : {0}", age);
                    continue;
                    Console.WriteLine("Hello");
                }

                if (age == 4)
                {
                    Console.WriteLine("Wiek wynosi : {0}", age);
                    break;
                    Console.WriteLine("Hello");
                }
            }

            foreach (int age in ages)
            {
                if (age == 2)
                {
                    Console.WriteLine("Wiek wynosi : {0}", age);
                    goto skip;
                    Console.WriteLine("Hello");
                }
            }

            // jakis kod

            skip:
            Console.WriteLine("Hello");


            CheckAges(ages);


            Console.ReadKey();
        }


        #region metody prywatne
        private static void CheckAges(int[] ages)
        {
            foreach (var age in ages)
            {
                if (age  == 3)
                {
                    Console.WriteLine("Wiek wynosi : {0}", age);
                    return;
                }
            }
        }

        private static void instructionFor()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int a = 0; a < 2; a++)
                {
                    Console.WriteLine("wartość i : {0} oraz wartosc a : {1} ", i, a);
                }
            }

            for (; ; )
            {
                Console.WriteLine("Podaj Imie");
                string text = Console.ReadLine();

                Console.WriteLine("Masz na imie {0}", text);
            }
        }

        private static void instructionDoWhileDo()
        {
            int i = 1;

            while (i > 3)
            {
                Console.WriteLine("wartosc i {0}", i);
                i++;
            }

            do
            {
                Console.WriteLine("wartosc i {0}", i);
                i++;
            } while (i > 3);
        }

        private static void instructionForeach()
        {
            int[] tab = { 1, 2, 3, 5, 8, 12, 21 };

            foreach (var item in tab)
            {
                Console.WriteLine(item);
            }
        }



        private static void instructionSwitch()
        {
            Console.WriteLine("Podaj imie: ");
            name = Console.ReadLine();

            switch (name)
            {
                case "Marcin":
                    Method1();
                    break;
                case "Tomek":
                    Method2();
                    Method3();
                    break;
                case "Ania":
                    Method1();
                    Method2();
                    Method3();
                    Method4();
                    break;
                default:
                    Method4();
                    break;
            }
        }

        private static void instructionIf()
        {
            Console.WriteLine("Podaj swój wiek: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj swoje imie: ");
            name = Console.ReadLine();


            string test = age > 18 ? "Pełnoletni" : "Dziecko";
            Console.WriteLine(test);


            if (age <= 10)
            {
                if (name == "Marcin")
                {
                    Method1();
                }
            }
            else if (age < 20)
            {
                Method2();
            }
            else if (age < 30)
            {
                Method3();
            }
            else
            {
                Method4();
            }
        }






        private static void Method4()
        {
            Console.WriteLine("jestes w metodzie 4");
        }

        private static void Method3()
        {
            Console.WriteLine("jestes w metodzie 3");
        }

        private static void Method2()
        {
            Console.WriteLine("jestes w metodzie 2");
        }

        private static void Method1()
        {
            Console.WriteLine("jestes w metodzie 1");
        }
        #endregion
    }
}
