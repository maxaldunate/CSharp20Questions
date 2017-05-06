using System;
using ConsoleAppNetCore.Questions;

namespace ConsoleAppNetCore
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Q01_StructureAndClasses.Run();
            Q01_StructureAndClasses.RunByRef();
            Q04_AssemblyLocation.Run();
            Q12_GetIndex.Run();
            //ModifyConstructorParameter();
            //Q15_Enumeration.Run();

            Console.ReadKey();
        }

        public static void ModifyConstructorParameter()
        {
            var name = "maximiliano";
            var baseClass = new BaseClass(name);
            var inheritedClass = new InheritedClass(name);

            Console.WriteLine($"Base class name      = '{baseClass.Name}'");
            Console.WriteLine($"Inherited class name = '{inheritedClass.Name}'");
        }



    }
}