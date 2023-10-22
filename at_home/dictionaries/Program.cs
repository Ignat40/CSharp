using System;

namespace Dictionaries
{

    //key - stores a value 
    //Auto - car
    class Program
    {
        public static void Main()
        {
            Dictionary<int, string> myDict = new Dictionary<int, string>()
            {
                {1, "Mustard"},
                {2, "Mayo"},
                {3, "Ketchup"},
            };
            
        }
    }
}