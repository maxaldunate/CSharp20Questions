using System;

namespace ConsoleAppFw45
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IpAddressPublic();
            //IpAddressPrivate();
            //EncryptDecrypt();

            Console.ReadKey();
        }

        public static void IpAddressPublic()
        {
            var address = "";
            var request = System.Net.WebRequest.Create("http://checkip.dyndns.org/");
            using (var response = request.GetResponse())
            using (var stream = new System.IO.StreamReader(response.GetResponseStream()))
            {
                address = stream.ReadToEnd();
            }

            //var first = address.IndexOf("Address: ") + 9;
            //var last = address.LastIndexOf("</body>");
            //address = address.Substring(first, last - first);

            var ip = new System.Text.RegularExpressions.Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b");
            address = ip.Match(address).Value;
            Write("My public IP is '" + address + "'");

        }

        public static void IpAddressPrivate()
        {
            foreach (var intfs in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
                foreach (var addss in intfs.GetIPProperties().UnicastAddresses)
                    if (addss.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        Write($"Ip Addess: " + addss.Address.ToString());
        }

        public static void EncryptDecrypt()
        {
            var texto = Write("Este es el texto que desaseamos encryptar");
            Write();

            var pwd = "P@$$w0rd";

            var testEncrypt = new DesEncrypt();

            Write("********** Encrypted Text * *********");
            var encText = testEncrypt.EncryptString(texto, pwd);
            Write(encText);
            Write();

            Write("********** Decrypted Text * *********");
            var plain = testEncrypt.EncryptString(encText, pwd);
            Write(plain);
            Write();
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
