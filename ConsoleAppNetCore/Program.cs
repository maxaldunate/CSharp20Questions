using System;
using ConsoleAppNetCore.Questions;

namespace ConsoleAppNetCore
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //GetIndexInForEachLoop();
            Q1Run.Run();
            Q1Run.RunByRef();
            //GetAssemblyLocation();
            //ModifyConstructorParameter();
            //Q15_Enumeration.Run();

            Console.ReadKey();
        }


        public static void GetIndexInForEachLoop()
        {
            var curIdx = 0;
            var counter = 0;

            Write("Dictionary collection");
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
                Write(counter);
                counter++;
            }

            Write("List collection");
            var strList = new System.Collections.Generic.List<string>
            {
                "one","two","three","four","five","six","seven"
            };

            foreach (var str in strList)
            {
                curIdx = strList.IndexOf(str);
                Write(curIdx);
            }

            Write("Array collection");
            Write("Identical of list, looking by IndexOf");

        }

        public static void GetAssemblyLocation()
        {
            var assem = System.Reflection.Assembly.GetEntryAssembly().Location;
            var assemIo = System.IO.Path.GetDirectoryName(assem);

            Console.WriteLine("Assembly location");
            Console.WriteLine(assem);
            Console.WriteLine("Path Assembly location {assem}");
            Console.WriteLine(assemIo);
        }

        public static void ModifyConstructorParameter()
        {
            var name = "maximiliano";
            var baseClass = new BaseClass(name);
            var inheritedClass = new InheritedClass(name);

            Console.WriteLine($"Base class name      = '{baseClass.Name}'");
            Console.WriteLine($"Inherited class name = '{inheritedClass.Name}'");
        }

        public static string Write(string msg = "")
        {
            Console.WriteLine(msg);
            return msg;
        }

        public static int Write(int msg)
        {
            Write(msg.ToString());
            return msg;
        }

    }
}