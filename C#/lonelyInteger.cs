class Result
{

    /*
     * Complete the 'lonelyinteger' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int lonelyinteger(List<int> a)
    {
        var r = a.GroupBy(x => x).Select(x => x).FirstOrDefault(x => x.Count() == 1);
        return r.Key;
    }

}