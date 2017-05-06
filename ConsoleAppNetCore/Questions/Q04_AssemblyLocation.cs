using System;

namespace ConsoleAppNetCore.Questions
{
    public class Q04_AssemblyLocation
    {
        public static void Run()
        {
            var assem = System.Reflection.Assembly.GetEntryAssembly().Location;
            var assemIo = System.IO.Path.GetDirectoryName(assem);

            Console.WriteLine("Assembly location");
            Console.WriteLine(assem);
            Console.WriteLine("Path Assembly location {assem}");
            Console.WriteLine(assemIo);
        }
    }
}