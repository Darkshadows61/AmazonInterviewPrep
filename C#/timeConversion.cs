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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        // given a time in PM or AM, return the time in military
        // thankfully, C# has a DateTime and system we can use
        string result = default;
        DateTime time = default;
        if(DateTime.TryParse(s, out time)) {
            result = time.ToString("HH:mm:ss"); 
        } 
        return result;
    }

}