using System;
using ConsoleAppFw45.Questions;

namespace ConsoleAppFw45
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Q11_DesEncrypt.Run();
            Q13_IpAddress.RunPrivate();
            Q13_IpAddress.RunPublic();

            Console.ReadKey();
        }

    }
}
