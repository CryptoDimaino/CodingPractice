using System;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ping1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();

            List<string> IPs = new List<string>();

            IPs.Add("1.1.1.1");
            IPs.Add("ladjfxmevpwn01");
            IPs.Add("ladjfxmevpwn01ttm");
            IPs.Add("ladjfxmevnrb01");
            IPs.Add("10.23.19.107");
            IPs.Add("10.23.19.202");
            IPs.Add("ladjfxmevpwn02");
            IPs.Add("ladjfxmevpwn02ttm");
            IPs.Add("ladjfxmevnrb02");
            IPs.Add("10.23.19.124");
            IPs.Add("10.23.19.214");
            IPs.Add("ladjfxmevpwn03");
            IPs.Add("ladjfxmevpwn03ttm");
            IPs.Add("10.23.19.103");
            IPs.Add("ladjfxmevpwn04");
            IPs.Add("ladjfxmevpwn04ttm");
            IPs.Add("10.23.19.125");
            IPs.Add("ladjfxmevpwn05");
            IPs.Add("ladjfxmevpwn05ttm");
            IPs.Add("ladjfxmevpwn05ttm");
            IPs.Add("ladjfxmevpwn06");
            IPs.Add("ladjfxmevpwn06ttm");
            IPs.Add("ladjfxmevpwn06ttm");
            IPs.Add("ladjfxmevpwn07");
            IPs.Add("ladjfxmevpwn07ttm");
            IPs.Add("ladjfxmevpwn07ttm");
            IPs.Add("ladjfxmevpwn08");
            IPs.Add("ladjfxmevpwn08ttm");
            IPs.Add("ladjfxmevpwn08ttm");
            IPs.Add("ladjfxmevpwn09");
            IPs.Add("ladjfxmevpwn09ttm");
            IPs.Add("ladjfxmevpwn09ttm");
            IPs.Add("ladjfxmevpwn10");
            IPs.Add("ladjfxmevpwn10ttm");
            IPs.Add("ladjfxmevpwn10ttm");
            
            options.DontFragment = true;

            string data = "aaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;
            foreach(string ip in IPs)
            {
                PingReply reply = pingSender.Send(ip, timeout, buffer, options);

                if(reply.Status == IPStatus.Success) 
                {
                    Console.WriteLine($"{ip} - Success");
                }
                // Console.WriteLine(ip);
            }
        }
    }
}
