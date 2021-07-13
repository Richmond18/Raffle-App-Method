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
          static void Main(string[] args)
    {
           Console.WriteLine("Welcome to the Party");
     
            
            GetUserInfo();

            PrintGuestsName();
            


           


        }

       




        private static string questionOne = "Do you want to add a name?";
        //private static string answerOne = "Y";
        //Program randomNumber = new Program();

        //static int randomNumber;
        private static int raffleNumber;
        private static Dictionary<int, string> Guest = new Dictionary<int, string>();
        static int minNum = 1000; 
        static int maxNum = 9999;
        static Random rnd = new Random();


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
                    GenerateRandomNumber(0, 0);
                    int newnum = GenerateRandomNumber(0, 0);
                    Console.WriteLine(GenerateRandomNumber(0, 0));
                    AddGuestInRaffle(newnum, otherGuest);


                    if (string.IsNullOrEmpty(otherGuest))
                    {
                        Console.WriteLine("Please enter a valid Name");
                    }



                }


            }
            while (addNameQ != "n");




        }
        static int GenerateRandomNumber(int min, int max)
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


        


        static  void AddGuestInRaffle(int raffleNumber, string guest)
        {
         
       
            Guest.Add(raffleNumber, guest);

        }







        // static public void PrintGuestsNam<K, V>(Dictionary <K, V> Guest)
        static public void PrintGuestsName()
        {
            
            foreach (KeyValuePair<int, string> printing in Guest )
            {
                Console.WriteLine($" Number: {printing.Key} Guest: {printing.Value} ");
            }
            
        }







        public static void getrafflenumber(Dictionary<int, string> guest)
        {

            for (int i = 0; i < guest.Count; i++)
            {

                int index = rnd.Next(guest.Count);
                KeyValuePair<int, string> pair = guest.ElementAt(index);
                return guest.ElementAt(index);

            }

        }


        public static void GetWinner()
        {
            raffle();



        }

        //public object RandomDictionaryKeyValue<T1, T2>(object Guest)
        //{
        //    var Guest2 = (Dictionary<T1, T2>)Guest;
        //    List<T1> keyList = new List<T1>(Guest2.Keys);

        //    //Random rand = new Random();
        //    return keyList[rnd.Next(keyList.Count)];
        //}

        //public static Dictionary<int, string> raffle()
        //{
        //    int rNumber;
        //    for (int i = 0; i < Guest.count; i++)
        //    {
        //        int index = rnd.next(Guest.count);
        //        keyvaluepair<int, string> pair = Guest.elementat(index);

        //        rNumber = Guest.element(index);
        //        return Guest.element(index);
        //    }

        //    return new Dictionary<int, string>;
        //}



        // static public void PrintGuestsName()
        // {
        //  Program adding = new Program();
        // foreach (KeyValuePair<int, string> printing in )
        //  {
        //Console.WriteLine($" Number: {printing.Key} Guest: {printing.Value} ");

        //  Console.WriteLine($"Key = {0}, Value = {1}", printing.Key, printing.Value);

        //   }
        //   }




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
