using System;

namespace ConsoleAppNetCore.Questions
{
    public class Q01_StructureAndClasses
    {
        public static void RunByRef()
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

        public static void Run()
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

    }


    public static class Assign
    {
        public static void AssignMethodRefString(ref string myString)
        {
            myString = "Max assignado inside";
        }

        public static void AssignMethodOutString(out string myString)
        {
            myString = "Max assignado inside";
        }

        public static void AssignMethodByRef(ref MyStructure myStruct)
        {
            myStruct.Name = "Max assignado inside";
        }

        public static void AssignMethodOut(out MyStructure myStruct)
        {
            myStruct = default(MyStructure);
            myStruct.Name = "Max assignado inside";
        }
    }

    public class PrintClass
    {
        private MyClass _myClass { get; set; }
        private MyStructure _myStruct { get; set; }

        public PrintClass(MyClass c, ref MyStructure s)
        {
            _myClass = c;
            _myStruct = s;
        }

        public void Print()
        {
            Console.WriteLine($"MyClass  name {_myClass.Name}");
            Console.WriteLine($"MyStruct name {_myStruct.Name}");
        }
    }
 

    public class MyClass
    {
        public string Name { get;  set; }
    }

    public struct MyStructure
    {
        public string Name { get; set; }
    }
}