using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppNetCore.Questions
{
    public static class Extensions
    {
        public static void ToConsole(this string msg)
        {
            Console.WriteLine(msg);
        }

        public static void ToConsole(this int msg)
        {
            msg.ToString().ToConsole();
        }

        public static void ToConsole(this decimal msg)
        {
            msg.ToString().ToConsole();
        }

        public static void ToConsole(this List<string> list)
        {
            list.ForEach(x => x.ToConsole());
        }

        public static void ToConsole(this string[] list)
        {
            list.ToList().ToConsole();
        }

        public static void ToConsole(this IOrderedEnumerable<KeyValuePair<string,string>> list)
        {
            foreach (var item in list)
            {
                item.Key.ToConsole();
                item.Value.ToConsole();
            }
        }
    }
}
