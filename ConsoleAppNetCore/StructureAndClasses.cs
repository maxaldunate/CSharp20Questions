using System;

namespace ConsoleAppNetCore
{
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