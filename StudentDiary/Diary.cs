using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
        }

        // Stan (zmienne - pola)
        List<float> ratings;


        // Zachowania
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        internal DiaryStatistics ComputeStatistics()
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
