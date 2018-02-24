using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Typy.Tests
{
    [TestClass]
    public class DiaryTests 
    {
        [TestMethod]
        public void CalculateMaxGrade() 
        {
            Diary diary = new Diary();
            diary.AddRating(9f);
            diary.AddRating(8f);
            diary.AddRating(7f);
            diary.AddRating(5f);
            diary.AddRating(3f);
            diary.AddRating(11f);

            DiaryStatistics stats = diary.ComputeStatistics();

            Assert.AreEqual(9f, stats.MaxGrade);
        }

        [TestMethod]
        public void PassByValueClass()
        {
            Diary diary = new Diary();
            diary.Name = "Jacek";

            SetName(diary);

            Assert.AreEqual("Marcin", diary.Name);
        }

        [TestMethod]
        public void PassByValueInt()
        {
            int x1 = 5;
            IncrementNumber(x1);

            Assert.AreEqual(5, x1);
        }

        [TestMethod]
        public void PassByRefInt() 
        {
            int x1 = 5;
            IncrementNumber(ref x1);

            Assert.AreEqual(15, x1);
        }

        private void IncrementNumber(ref int number)
        {
            number = 15;
        }

        private void IncrementNumber(int number)
        {
            number = 15;
        }

        private void SetName(Diary diary)
        {
            diary.Name = "Marcin";
        }
    }
}
