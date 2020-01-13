using System;

namespace codeName
{
    class Program
    {
        public static string getName()
        {
            string name;
            bool isOnlyLetter;
            do
            {
                Console.WriteLine("Enter your name : ");
                name = Console.ReadLine().Trim().ToLower();
                isOnlyLetter = true;
                foreach (char c in name)
                {
                    if (c < 97 || c > 122)
                    {
                        isOnlyLetter = false;
                        Console.WriteLine("Letter '" + c + "' forbidden");
                    }

                }
            } while(!isOnlyLetter) ;
           
            return name;
        }

        public static int codeName(string name)
        {
            int sumOfLetter = 0;
            foreach(char c in name)
            {
                sumOfLetter = sumOfLetter + (((int)c - 97) % 9)+1;
            }
            return sumOfLetter;
        }

        public static void displayCodedName(String name, int number)
        {
            Console.WriteLine(name + " will be coded as " + Convert.ToString(number));
        }

        static void Main(string[] args)
        {
            string stringName;
            int numberName;
            stringName = getName();
            numberName = codeName(stringName);
            displayCodedName(stringName, numberName);

        }
    }
}
