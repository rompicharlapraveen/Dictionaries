using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> num = new Dictionary<int, string>();
            num.Add(1, "one");
            num.Add(3, "Three");
            num.Add(2, "Two");
            foreach (KeyValuePair<int, string> kvp in num)
                Console.WriteLine("key:{0},Value:{1}",kvp.Key,kvp.Value);
        }
    }
}
