using System.Collections.Generic;
using System.Linq;

namespace Members
{
    public class Diary
    {
        // konstruktor
        public Diary()
        {
            ratings = new List<float>();
        }

        // Stan (zmienne - pola)
        private List<float> ratings;

        public string Name;

        // Zachowania
        public void AddRating(float rating)
        {
            if (rating >= 0 && rating <= 10)
            {
                ratings.Add(rating);
            }
        }

        public DiaryStatistics ComputeStatistics()
        {
            DiaryStatistics stats = new DiaryStatistics();
            float sum = 0f;

            foreach (var rating in ratings)
            {
                sum += rating;
            }

            stats.AverageGrade = sum / ratings.Count();
            stats.MaxGrade = ratings.Max();
            stats.MinGrade = ratings.Min();

            return stats;
        }
    }
}
