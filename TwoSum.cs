using System;

namespace LeetCode 
{
    class TwoSum
    {
        static void Main(string[] args)
        {
            int[] bucket;
            int   target;
            int[] result;

            Random rnd = new Random();
            bucket = new int[rnd.Next(1, 10)];
            target = rnd.Next(1, 10);
            for(int i = 0; i < bucket.Length; i++)
            {
                bucket[i]  = rnd.Next(1, 10);
            } 

            foreach( int i in bucket)
            {
                Console.WriteLine(i);
            }
            
            result = Solve(bucket, target);
            if(result != null)
                Console.WriteLine("Target:{0} \nResult:{1}, {2}\n", target, result[0], result[1]);
            else
            {
                Console.WriteLine("No Solution");
            }
        }

        static int[] Solve(int[] bucket, int target)
        {
            for(int i = 0; i < bucket.Length - 1; ++i)
            {
                for(int j = i + 1; j < bucket.Length; ++j)
                {
                    if(bucket[i] + bucket[j] == target) 
                    {
                        Console.WriteLine("i:{0}, j:{1}\nbucket[{0}]:{2}, bucket[{1}]:{3}",
                                                                 i, j, bucket[i], bucket[j]);
                        return new int[] {i, j};
                    }
                }
            }
            return null;
        }
    }
}