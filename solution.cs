Here is a full working console application in C# that solves the problem:

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = {1, 1, 1, 2, 2, 3};
        int k = 2;
        var result = TopKFrequent(arr, k);
        foreach (var num in result)
        {
            Console.WriteLine(num);
        }
    }

    public static IList<int> TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (frequency.ContainsKey(num))
            {
                frequency[num]++;
            }
            else
            {
                frequency[num] = 1;
            }
        }

        return frequency.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToList();
    }
}
```

This program first counts the frequency of each element in the array using a dictionary. Then it sorts the dictionary in descending order based on the frequency and takes the top K elements. The keys of these elements are the top K most frequent elements in the array.