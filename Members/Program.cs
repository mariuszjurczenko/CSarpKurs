using System;

namespace Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
                    
  
            diary.NameChengaed += OnNameChanged;
            diary.NameChengaed += OnNameChanged2;
            diary.NameChengaed += OnNameChanged3;
            diary.NameChengaed += OnNameChanged4;
            diary.NameChengaed += OnNameChanged4;
            diary.NameChengaed += OnNameChanged4;
            diary.NameChengaed += OnNameChanged4;
            diary.NameChengaed -= OnNameChanged4;
            diary.NameChengaed -= OnNameChanged4;
            diary.NameChengaed -= OnNameChanged4;

            try
            {
                Console.WriteLine("Proszę podaj imie");
                diary.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException)
            {

                Console.WriteLine("Coś poszło nie tak");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }



            diary.Name = "Dzienniczek Marcina";
            diary.Name = "Jacek Hej";

            Console.WriteLine(diary.Name);
        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Zmiana nazwy z {args.ExistingName} na {args.NewName}");
        }

        private static void OnNameChanged2(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("***************");
        }

        private static void OnNameChanged3(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("Hello");
        }

        private static void OnNameChanged4(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("+++++++++++++++++++");
        }
    }
}
