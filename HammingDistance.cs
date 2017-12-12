using System;

namespace LeetCode
{
    class HammingDistance
    {       
        static void Main(string[] args)
        {
            int x;
            int y; 
            Random rnd = new Random();
            x = rnd.Next(0, 2^31);
            y = rnd.Next(0, 2^31);
            string fs = String.Format("x:{0} y:{1}\n", x,y);
            Console.WriteLine(fs);
            int res = Solve(x,y);
            Console.WriteLine(res);
        }
        static int Solve(int x, int y)
        {
            int sum = 0;
            int res = x ^ y;
            while(res > 0)
            {
                if( (res&1) == 1)
                {
                    sum++;
                }
                res = res >> 1;
            }
        return sum; 
        }
    }
}