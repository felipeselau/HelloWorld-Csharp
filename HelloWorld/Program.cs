using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            string a = "Hello";
            string b = "World!";
            Console.WriteLine(a+" "+b);

            Console.WriteLine("Type your name:");
            string nome = Console.ReadLine();
            Console.WriteLine("Type your age");
            string inputAge = Console.ReadLine();
            int age = Int32.Parse(inputAge);
            string msg;
            bool ageCheck = false;

            if (age < 30)
            {
                msg = "You still got a long way to go young boy...";
            }
            else
            {
                msg = "Ah I see... a experienced dev comes to visit my code, shall I know what brings you here?";
                ageCheck = true;
            }
                  
            Console.WriteLine("Your name is: " + nome +" and you have "+age+" years\n"+msg);


            if (ageCheck)
            {
                string motivation = Console.ReadLine();
                Console.WriteLine("Ah yes... "+motivation+" really explains your visit. have fun discovering the deep secrets of this code dear dev.");
            }


        }
    }
}