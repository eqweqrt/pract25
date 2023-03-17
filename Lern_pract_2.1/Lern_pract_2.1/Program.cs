1)

using System;

namespace Lern_pract_2._1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string S = "Якудза";
            string J = "Фудзи";
            int count = 0;
            for (int i = 0; i < S.Length; i++)
            {
                for (int g = 0; g < J.Length; g++)
                {
                    if (J[g] == S[i])
                    {
                        count += 1;
                    }
                }
               
            }
            Console.WriteLine(count);
        }
    }
}
 

2) 

using System;
using System.Collections.Generic;

namespace Lern_pract_2._1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Нуууу хз наверно надо лучше что-то сделать, потому что это какашечка!!!!
            List<int> candidates = new List<int>() {1,2,3,4,5};
            int target = 7;
            //List<int> result;
            String result = "";
            for (int i = 0; i < candidates.Count; i++)
            {
                if (candidates[0] + candidates[i] == target)
                {
                    result = $"{candidates[0]} + {candidates[i]}";
                    Console.WriteLine(result);
                }

                if (candidates[0] + candidates[1] + candidates[i] == target)
                {
                    string resultS =  $"{candidates[0]} + {candidates[1]} + {candidates[i]}";
                    Console.WriteLine(resultS);
                }
                
                if (candidates[0] + candidates[1] + candidates[2] + candidates[i] == target)
                {
                    string resultS =  $"{candidates[0]} + {candidates[1]} + {candidates[2]} + {candidates[i]}";
                    Console.WriteLine(resultS);
                }
                
                if (candidates[0] + candidates[1] + candidates[2] + candidates[3] + candidates[i] == target)
                {
                    string resultS =  $"{candidates[0]} + {candidates[1]} + {candidates[2]} + {candidates[3]} + {candidates[i]}";
                    Console.WriteLine(resultS);
                }
            }
        }
    }
}

 
3) 
using System;
using System.Collections.Generic;

namespace Lern_pract_2._1
{
    public class Program
    {
        public static bool func(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        
        
        public static void Main()
        {
            int[] nums = new[] { 1, 2, 3, 4, 5, 6, 7, 2 };
            func(nums);
            Console.WriteLine(func(nums));
        }
    }
}

 
