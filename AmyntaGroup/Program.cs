using System;
using System.Collections;

namespace AmyntaGroup
{
    public class AmyntaValueCheck
    {

        static void Main(string[] args)
        {
            AVCheck check = new AVCheck();
            
            // Welcome Banner and Value input.
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("|       Welcome To The AVC!           |");
            Console.WriteLine("|       (Amynta Value Check)          |");
            Console.WriteLine("---------------------------------------\n");

            int value;

            // Value input allowed as long as it falls withing perameters.
            do
            {
                Console.WriteLine("Please Enter a Whole Number between 1 and 100");
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out value)) break;
                    Console.WriteLine("Please Eneter a Whole Number.\n");
                }


                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Please enter a valid number\n");
                }
                else if (value == 0)
                {
                    check.SecretMessage();
                }

            } while (!(value > 0 && value < 101));


            Console.WriteLine();

            if (value > 0 && value < 101)
            {
                check.AVC(value);
            }
            Console.WriteLine("");
            Console.WriteLine("Thank you for using The AVC!");


        }






        


    }
    public class AVCheck
    {

        /*If the value can be evenly divided by 5 and 3 print "Amynta Group",
         *If the value can be evenly divided by 3 but not 5 print "Amynta",
         *If the value can be evenly divided by 5 but not 3 print "Group"
          * 
          */
        public string AVC(int value)
        {
            for (int i = value; i >= 1; i--)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("Amynta Group");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Group");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Amynta");
                }
                else if (i == 1)
                {
                    Console.WriteLine($"{i}\n");
                }
                else
                {
                    Console.WriteLine($"{i}");
                }

            }
            return "";
        }







        //Input of Zero messages
        public void SecretMessage()
        {
            int selection;
            Random rnd = new Random();
            selection = rnd.Next(1, 6);

            if (selection == 1)
            {
                Console.WriteLine("This was the !Correct Input.\n");
            }
            else if (selection == 2)
            {
                Console.WriteLine("Roll for Initiative!\n");
            }
            else if (selection == 3)
            {
                Console.WriteLine("The person who wrote this is a giant geek.\n");
            }
            else if (selection == 4)
            {
                Console.WriteLine("Your Lucky Number is 13!\n");
            }
            else if (selection == 5)
            {
                Console.WriteLine("7~7~7 JACKPOT!!!\n");
            }
        }


    }
}
