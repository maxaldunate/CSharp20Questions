using System;

namespace ConsoleAppNetCore
{
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