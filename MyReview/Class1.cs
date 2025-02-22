using System;
using System.Collections.Generic;

public class Program
{
    static void RemoveDuplicate(string str)
    {
        List<string> newList = new List<string>();
        string res = "";
        bool flag = false;
        for (int i = 0; i < str.Length; i++)
        {
            flag = true;
            for (int j = 0; j < res.Length; j++)
            {
                if (str[i] == res[j])
                {
                    flag = false;
                    break;
                }
            }
            if (flag) res += str[i];
            newList.Add(res);
            res = "";
        }
        LetsCount(newList);
    }

    public static void LetsSort(List<string> list, List<int> count)
    {
        for (int i = 0; i < count.Count; i++)
        {
            if (count[i] == 2)
            {

            }
        }
    }
    public static void LetsCount(List<string> list)
    {
        List<int> count = new List<int>();
        foreach (string s in list)
        {
            count.Add(s.Length);
        }
        LetsSort(list, count);
    }
    public static void Main()
    {
        List<string> list = new List<string> { "maa", "madam", "mam", "were", "we" };
        foreach (string s in list) RemoveDuplicate(s);

    }
}


// ma mad ma wer we
// 2  3   2   3  2
