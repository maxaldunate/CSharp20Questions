using System;

namespace ConsoleAppNetCore.Questions
{
    public static class Q05_BaseAndInheritetClass
    {
        public static void Run()
        {
            var name = "maximiliano";
            var baseClass = new BaseClass(name);
            var inheritedClass = new InheritedClass(name);

            Console.WriteLine($"Base class name      = '{baseClass.Name}'");
            Console.WriteLine($"Inherited class name = '{inheritedClass.Name}'");
        }

    }

    public class BaseClass
    {
        public string Name { get; private set; }

        public BaseClass(string name)
        {
            Name = name;
        }
    }

    public class InheritedClass : BaseClass
    {
        public InheritedClass(string name)  : base(ModifyParameter(name))
        {
        }

        private static string ModifyParameter(string name)
        {
            return name.ToUpper();
        }
    }
}