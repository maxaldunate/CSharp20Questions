using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleAppNetCore.Questions
{
    public class Q18_RemoveDuplicates
    {
        public static void Run()
        {
            string[] myArr = new string[] { "First", "First", "Second", "Third", "4th", "4th" };
            RemoveDups(myArr);
        }

        private static void RemoveDups(string[] arr)
        {
            "Recorriendo la lista".ToConsole();
            var myStrList = new List<string>();
            foreach (var s in arr)
                if (!myStrList.Contains(s))
                    myStrList.Add(s);
            myStrList.ForEach(x => x.ToConsole());

            "".ToConsole();

            "Using Linq".ToConsole();
            var strL = arr.Distinct().ToList();
            strL.ForEach(x => x.ToConsole());
        }
    }
}