using System;

namespace Kata8
{
    class Program
    {
        public static void Main()
        {
            string test = "UUUU";
            Console.WriteLine($"{dnaToRna(test)}");
        }

        public static string SentanceSmash(string[] words)
        {
            //------------------------- Ex. 1 -------------------------\\
            string sentance = "";
            foreach (var item in words)
            {
                sentance += item + ".";
            }
            sentance = sentance.Remove(sentance.Length - 1);
            return sentance;
        }

        public static int CountSheep(bool[] sheeps)
        {
            //------------------------- Ex. 2 -------------------------\\
            int counter = 0;
            for (int i = 0; i < sheeps.Length; i++)
            {
                if (sheeps[i] == true)
                {
                    counter++;
                }
            }

            return counter;
        }
        public static double basicOp(char operation, double value1, double value2)
        //------------------------- Ex. 3 -------------------------\\
        {
            switch (operation)
            {
                case '+': return value1 + value2;
                case '-': return value1 - value2;
                case '*': return value1 * value2;
                case '/': return value1 / value2;
            }
            return 0;
        }

        public static int Min(int[] list)
        {
        //------------------------- Ex. 4 -------------------------\\

            int min = list[0];
            for (int i = 0; i < list.Length; i++)
            {
                if(min > list[i])
                {
                    min = list[i];
                }                
            }
            return min;
        }

        public static int Max(int[] list)
        {
        //------------------------- Ex. 5 -------------------------\\

            int max = list[0];
            for (int i = 0; i < list.Length; i++)
            {
                if(max < list[i])
                {
                    max = list[i];
                }                
            }
            return max;
        }

        public static string AreYouPlayingBanjo(string name)
        {
        //------------------------- Ex. 6 -------------------------\\

            if(name[0] == 'R' || name[0] == 'r')
                return name + "plays banjo";
            else
                return name + "does not play banjo";
        }

        public static double SumArray(double[] arr)
        {
        //------------------------- Ex. 7 -------------------------\\

            double sum = 0;

            if(arr.Length <= 0)
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
            }

            return sum;

        }

        public static string DoubleChar(string s)
        {
        //------------------------- Ex. 8 -------------------------\\
            string doubleString = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                doubleString += s[i]+s[i].ToString();
            }
            return doubleString;
        }
        public static string dnaToRna(string dna)
        {
        //------------------------- Ex. 8 -------------------------\\
            // string newString = dna.Replace('T', 'U');
            // return newString;

            char[] charArray = dna.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if(charArray[i] == 'T')
                {
                    charArray[i] = 'U';
                }
            }

            string rna = new string(charArray);
            return rna;
        
        }
    }
}