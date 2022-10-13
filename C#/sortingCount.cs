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
     * Complete the 'countingSort' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> countingSort(List<int> arr)
    {
        // given an array with 100 ints, find out how many times a number is in the list
        // ex. how may 0s? 1s? 2s? 3s? 4s? etc.
        //create a new list called frequencies with numbers 0-99
        List<int> frequencies = new List<int>(new int[100]);
        // search the given array arr for elements that equal i
        arr.ForEach(i => frequencies[i]++);
        // return the new list
        return frequencies;
    }

}