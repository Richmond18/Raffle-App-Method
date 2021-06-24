using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        private static string questionOne = "Do you want to add another name?";
        private static string answerOne = "Y";
        //Program randomNumber = new Program();
        static int minNum = 1000;
        static int maxNum = 9999;
        static int raffleNumber;
        //static int randomNumber;
        static Random rnd = new Random();



        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            string message = "";
            //GetUserInput(message);
            GetUserInfo();
            int raffleNumber;
            raffleNumber = GenerateRandomNumber(0, 0);
            //string randomNumber;
            Console.WriteLine(PrintGuestsName());



        }
         

         static int GenerateRandomNumber(int min, int max )
        {
            int randomNum = rnd.Next(minNum, maxNum);


            return randomNum;
        }


        static string GetUserInput(string message)

        {

            Console.WriteLine("enter name");
            string name = Console.ReadLine();

            return name;
        }
        static  Dictionary<int, string> Guest = new Dictionary<int, string>();

        
        
            static void AddGuestsInRaffle(int raffleNumber, string guest)
            {
                //Dictionary<int, string> Guest = new Dictionary<int, string>();

                Guest.Add(raffleNumber, guest);

            }
        

      static void PrintGuestsName()
       {
            foreach (KeyValuePair<int, string>printing in Guest)
            {
                Console.WriteLine($" Number: {printing.Key} Guest: {printing.Value} ");
           }
       }



        static void GetUserInfo()
        {
            string userName;
            string otherGuest;
            GetUserInput("");
            string addNameQ;
           


            do

            {

               
                Console.WriteLine(questionOne);

                addNameQ = Console.ReadLine();
                //otherGuest = GetUserInput("Do you want to add another name?").ToLower();
               

                //string name = GetUserInput(Console.ReadLine());

                if (addNameQ == "y")

                {
                    otherGuest = GetUserInput("Do you want to add another name?").ToLower();
                    //otherGuest= GetUserInput(Console.ReadLine());
                    GenerateRandomNumber(0,0) ;
                    int newnum = GenerateRandomNumber(0, 0);
                    Console.WriteLine(GenerateRandomNumber(0,0));
                    AddGuestsInRaffle(newnum, otherGuest );


                    if (string.IsNullOrEmpty(otherGuest))
                       {
                        Console.WriteLine("Pleasw enter a valid Name");
                        }

                   

                }


            }
            while (addNameQ != "n");

            






            //Start writing your code here






            //static void MultiLineAnimation() // Credit: https://www.michalbialecki.com/2018/05/25/how-to-make-you-console-app-look-cool/
            //{
            //    var counter = 0;
            //    for (int i = 0; i < 30; i++)
            //    {
            //        Console.Clear();

            //        switch (counter % 4)
            //        {
            //            case 0:
            //                {
            //                    Console.WriteLine("         ╔════╤╤╤╤════╗");
            //                    Console.WriteLine("         ║    │││ \\   ║");
            //                    Console.WriteLine("         ║    │││  O  ║");
            //                    Console.WriteLine("         ║    OOO     ║");
            //                    break;
            //                };
            //            case 1:
            //                {
            //                    Console.WriteLine("         ╔════╤╤╤╤════╗");
            //                    Console.WriteLine("         ║    ││││    ║");
            //                    Console.WriteLine("         ║    ││││    ║");
            //                    Console.WriteLine("         ║    OOOO    ║");
            //                    break;
            //                };
            //            case 2:
            //                {
            //                    Console.WriteLine("         ╔════╤╤╤╤════╗");
            //                    Console.WriteLine("         ║   / │││    ║");
            //                    Console.WriteLine("         ║  O  │││    ║");
            //                    Console.WriteLine("         ║     OOO    ║");
            //                    break;
            //                };
            //            case 3:
            //                {
            //                    Console.WriteLine("         ╔════╤╤╤╤════╗");
            //                    Console.WriteLine("         ║    ││││    ║");
            //                    Console.WriteLine("         ║    ││││    ║");
            //                    Console.WriteLine("         ║    OOOO    ║");
            //                    break;
            //                };
            //        }

            //        counter++;
            //        Thread.Sleep(200);
            //    }
            //}
        }
    }
}
