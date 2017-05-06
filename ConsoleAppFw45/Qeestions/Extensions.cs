using System;

namespace ConsoleAppFw45.Questions
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
    }
}
