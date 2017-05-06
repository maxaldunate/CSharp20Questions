using System;

namespace ConsoleAppNetCore.Questions
{
    public class Q15_Enumeration
    {
        public enum AuthMethod
        {
            Forms = 1,
            WindowsAuth = 2,
            SingleSignOn = 3
        }

        public static void Run()
        {
            var auth = AuthMethod.Forms;
            string str = Enum.GetName(typeof(AuthMethod), auth);
            Console.WriteLine(str);

            var max = auth.ToString();
            Console.WriteLine(max);

            string str2 = AuthMethod.Forms.ToString();
            Console.WriteLine(str);
        }
    }
}