using System;

namespace Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();

            diary.NameChengaed += new NameChangedDelegate(OnNameChanged);
            diary.NameChengaed += new NameChangedDelegate(OnNameChanged2);
            diary.NameChengaed += new NameChangedDelegate(OnNameChanged3);
            diary.NameChengaed += new NameChangedDelegate(OnNameChanged4);
            diary.NameChengaed += new NameChangedDelegate(OnNameChanged4);
            diary.NameChengaed += new NameChangedDelegate(OnNameChanged4);


            diary.Name = "Dzienniczek Marcina";
            diary.Name = "Jacek Hej";

            Console.WriteLine(diary.Name);
        }

        private static void OnNameChanged(string existingName, string newName)
        {
            Console.WriteLine($"Zmiana nazwy z {existingName} na {newName}");
        }

        private static void OnNameChanged2(string existingName, string newName)
        {
            Console.WriteLine("***************");
        }

        private static void OnNameChanged3(string existingName, string newName)
        {
            Console.WriteLine("Hello");
        }

        private static void OnNameChanged4(string existingName, string newName)
        {
            Console.WriteLine("+++++++++++++++++++");
        }
    }
}
