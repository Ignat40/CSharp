using System.Dynamic;

namespace LeetCode
{
    public class ClimbingStairs
    {
        public static int Stairs(int x)
        {
            if (x == 0 || x == 1)
                return 1;
            return Stairs(x - 1) + Stairs(x - 2);
        }
    }
}

//Exceeds time complexity though...