using System;
using ConsoleAppNetCore.Questions;

namespace ConsoleAppNetCore
{
    public static class Program
    {

        public static void Main(string[] args)
        {
            //GetIndexInForEachLoop();
            //StructureVersusClassByRef();
            //StructureVersusClass();
            //GetAssemblyLocation();
            //ModifyConstructorParameter();

            Q15_Enumeration.Run();

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

        public static void StructureVersusClassByRef()
        {
            var myStr = new MyStructure();
            myStr.Name = "Max assigned in console";

            Console.WriteLine($"Ref parameter before assign method result is '{myStr.Name}'");
            Assign.AssignMethodByRef(ref myStr);
            Console.WriteLine($"Ref parameter after assign method result is '{myStr.Name}'");

            Console.WriteLine();
            MyStructure mySNoInit;
            Assign.AssignMethodOut(out mySNoInit);
            Console.WriteLine($"Out parameter no init result is '{mySNoInit.Name}'");

            Console.WriteLine();
            MyStructure mySInit = new MyStructure();
            mySInit.Name = "Init name";
            Assign.AssignMethodOut(out mySInit);
            Console.WriteLine($"Out parameter init result is '{mySInit.Name}'");

            Console.WriteLine();
            String myStringOut = null;
            Assign.AssignMethodOutString(out myStringOut);
            Console.WriteLine($"Out parameter init result is '{myStringOut}'");

            Console.WriteLine();
            String myStringRef = null;
            Assign.AssignMethodRefString(ref myStringRef);
            Console.WriteLine($"Out parameter init result is '{myStringRef}'");

        }

        public static void StructureVersusClass()
        {
            var myStructure = new MyStructure();
            var myClass = new MyClass();

            myStructure.Name = "max";
            myClass.Name = "max";

            var myPrintClass = new PrintClass(myClass, ref myStructure);
            Console.WriteLine("First time, max is the name");
            myPrintClass.Print();

            myClass.Name = "Otro Maximiliano";
            myStructure.Name = "Otro Maximiliano";

            Console.WriteLine("");
            Console.WriteLine("Second time, maximiliano is the name");
            myPrintClass.Print();
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