using System;
using System.Linq;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        List<int> intList = Enumerable.Range(1, max - 1).ToList();

        var list = new List<int>();
        foreach (var m in multiples){
            var l = intList.Where(i => m != 0 && i % m == 0).ToList();
            list.AddRange(l);
        }
        return list.Distinct().Sum();
    }
}