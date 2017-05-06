using System;

namespace ConsoleAppNetCore.Questions
{
    public class Q17_RoundDecimal
    {
        public static void Run()
        {
            decimal val = 65476452342.123123123M;

            "Raw Value".ToConsole();
            val.ToConsole();

            "".ToConsole();
            var f = "#.##";
            f.ToConsole();
            val.ToString(f).ToConsole();

            "".ToConsole();
            "{0:0.00}".ToConsole();
            Console.WriteLine(string.Format("{0:0.00}", val));

            "".ToConsole();
            f = "n2";
            f.ToConsole();
            val.ToString(f).ToConsole();

            "".ToConsole();
            "{0:c}".ToConsole();
            Console.WriteLine(string.Format("{0:c}", val));

        }
    }
}