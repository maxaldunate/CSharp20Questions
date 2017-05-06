using System;

namespace ConsoleAppNetCore.Questions
{
    public class Q12_GetIndex
    {
        public static void Run()
        {
            var curIdx = 0;
            var counter = 0;

            "Dictionary collection".ToConsole();
            var diction = new System.Collections.Generic.Dictionary<string, string>
            {
                {"one","one"},
                {"two","two"},
                {"three","three"},
                {"four","four"},
                {"five","five"},
                {"six","six"},
                {"seven","seven"},
            };

            foreach (var obj in diction)
            {
                counter.ToConsole();
                counter++;
            }

            "List collection".ToConsole();
            var strList = new System.Collections.Generic.List<string>
            {
                "one","two","three","four","five","six","seven"
            };

            foreach (var str in strList)
            {
                curIdx = strList.IndexOf(str);
                curIdx.ToConsole();
            }

            "Array collection".ToConsole();
            "Identical of list, looking by IndexOf".ToConsole();
        }
    }
}