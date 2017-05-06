using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppNetCore.Questions
{
    public class Q19_DictSorting
    {
        public static void Run()
        {
            var dict = new Dictionary<string, string>();
            dict.Add("3", "tres");
            dict.Add("1", "uno");
            dict.Add("5", "cinco");
            dict.Add("2", "dos");

            var sortList = dict.ToList();

            "Sorted1".ToConsole();
            var sorted1 = from entry in dict
                          orderby entry.Value ascending
                          select entry;
            sorted1.ToConsole();

            "".ToConsole();

            "Sorted2".ToConsole();
            var sorted2 = dict.OrderBy(x => x.Value);
            sorted2.ToConsole();
        }
    }
}