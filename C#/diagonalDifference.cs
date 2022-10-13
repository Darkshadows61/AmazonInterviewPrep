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
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        // given an array, find the sum of two diagonals and then the absolute dif between them
        // first num in array is the size of the square
        // will always need arr[0] and arr[last] for first and last rows
        // unless n is 2, it should always be odd
        int primaryDiagonal = 0;
        int secondaryDiagonal = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            primaryDiagonal += arr[i][i];
            secondaryDiagonal += arr[i][arr.Count - 1 - i];
        }
        return Math.Abs(primaryDiagonal- secondaryDiagonal);
    }
}