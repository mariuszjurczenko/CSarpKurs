using System;

namespace Typy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diary diary = new Diary();
            //diary.AddRating(3f);
            //diary.AddRating(5f);
            //diary.AddRating(11);

            //Diary diary2 = new Diary();
            //Diary diary3 = new Diary();
            //Diary diary4 = new Diary();
            //Diary diary5 = new Diary();
            //Diary diary6 = new Diary();

            //DiaryStatistics stats = diary.ComputeStatistics();

            Diary d1 = new Diary();
            Diary d2 = d1;

            d1 = new Diary();
            d1.Name = "Dzienniczek Marcina";
            Console.WriteLine(d2.Name);
            

            int x1 = 4;
            int x2 = x1;
            x1 = 100;
            Console.WriteLine(x2);

        }
    }
}
