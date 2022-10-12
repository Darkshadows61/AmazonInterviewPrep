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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        // start with the length of the array
        var length = arr.Count * 1.0;

        // sort the array into 3 lists; pos, neg, zero
        // return the ratio of each element type as a decimal to 6 decimel places, each on a new line
        // ex; {1,1,0,-1,-1} has 2 pos, 2 neg, 1 zero meaning 2/5 = 0.400000 for pos and neg and 0.20000 for zero
        Console.WriteLine(arr.Count(x=> x > 0) / length); 
        Console.WriteLine(arr.Count(x=> x < 0) / length); 
        Console.WriteLine(arr.Count(x=> x == 0) / length); 
    }

}