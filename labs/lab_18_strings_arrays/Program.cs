using System;
using System.Collections.Generic;
using System.Text;

namespace lab_18_strings_arrays
{
    public class Array
    {
        static void Main(string[] args)
        {
            //char[] nish = new char[4];

            //nish[0] = 'n';
            //nish[1] = 'i';
            //nish[2] = 's';
            //nish[3] = 'h';

            //char[] sparta = { 's', 'p', 'a', 'r', 't', 'a' };

            //int[] newArray = { 2, 3, 4, 5, 6 };
            //var result = ArraySum(newArray);
            //Console.WriteLine(result);

            //int[,] grid = new int[2, 4]; 

            // dimensional array int[,,] grid2d = { { { 4, 7, 8, 9 }, { 6, 1, 7, 10 }, { 4, 4, 4, 4 } } };

            //jagged array
            //string[][] animalGrid = new string[2][];
            //animalGrid[0] = new string[4];
            //animalGrid[1] = new string[2];

            ////new
            //string[][] animalGrid2 = new string[][]
            //{
            //    new string[] {"llama", "puma", "horse", "kitten" },
            //    new string[] {"haddock", "tuna"}
            //};

            //var animal = animalGrid2[0][1];
            //Console.WriteLine(animal);

            //var names = new List<string>();
            //names.Add("Nish");

            //string name = "Phil Anderson";

            //var allChars = name.ToCharArray();
            //var initial = name.ToCharArray(1, 3);
            //Console.WriteLine(initial);

            //string firstName = "Harry";
            //string lastName = "Derbyshire";
            //int age = 19;

            //var string1 = firstName + " " + lastName;

            //double score = 0.4434;
            //score:f3 = 0.443
            //score:p2 = 44.34%

            //string a = "32";
            //int b = (int) a;

            StringBuilder sb = new StringBuilder("Hello");
            sb.AppendLine(" from Engineering66\nEspecially Nish");
            Console.WriteLine(sb.ToString());

        }

        public static int ArraySum(int[] practiceArray)
        {
            int arraySum = practiceArray[0] + practiceArray[1] + practiceArray[2];
            return arraySum;
        }

    }
}
