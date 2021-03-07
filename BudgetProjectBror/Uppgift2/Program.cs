using System;

namespace Uppgift2
{
    class Program
    {
        static void Main(string[] args) //toplam fiyat, ne kadar indirim almış, son fiyat 
        {
            //Random random = new Random();
            //int sayi1 = random.Next(0, 20);
            //int sayi2 = random.Next(0, 20);
            //int result = sayi1 + sayi2;

            //Console.WriteLine("What becomes the answer? " + sayi1 + " + " + sayi2);
            //Console.Write("Answer : ");
            //int answer = Convert.ToInt32(Console.ReadLine());

            //if (answer == result)
            //{
            //    Console.WriteLine("Correct Answer");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong answer");
            //}

            Random random = new Random();
            int sayi1 = random.Next(0, 20);
            int sayi2 = random.Next(0, 20);
            int result = sayi1 + sayi2;

            Console.WriteLine("What becomes the answer " + sayi1 + " + " + sayi2);
            int answer = Convert.ToInt32(Console.ReadLine());  ///////////// BURAYI SOR int değerini neden görmüyor

            if (answer == result)
            {
                Console.WriteLine("Correct answer, congrulations!");
            }
            else
            {
                Console.WriteLine("Wrong answer, try again!");
            }
        }
    }
}
