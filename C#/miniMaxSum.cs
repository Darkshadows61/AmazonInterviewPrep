using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        // find min and max values of given array of ints found by adding 4 of the 5 numbers together
        // first sort the array from lowest to highest
        arr.Sort();
        // add first 4 values which would be lowest, then add last 4 values which would be the highest, then return sums
        var min = (arr[0] + arr[1] + arr[2] + arr[3]);
        var max = (arr[1] + arr[2] + arr[3] + arr[4]);
        Console.WriteLine(min + " " + max);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
