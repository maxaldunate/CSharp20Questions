using System;

namespace ConsoleAppFw45.Questions
{
    public class Q13_IpAddress
    {
        public static void RunPublic()
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
            ("My public IP is '" + address + "'").ToConsole();

        }

        public static void RunPrivate()
        {
            foreach (var intfs in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
                foreach (var addss in intfs.GetIPProperties().UnicastAddresses)
                    if (addss.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        ($"Ip Addess: " + addss.Address.ToString()).ToConsole();
        }



    }
}