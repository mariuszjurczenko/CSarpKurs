namespace Odcinek13
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            diary.AddRating(3f);
            diary.AddRating(5f);
            diary.AddRating(11);



            DiaryStatistics stats = diary.ComputeStatistics();

        }
    }
}
