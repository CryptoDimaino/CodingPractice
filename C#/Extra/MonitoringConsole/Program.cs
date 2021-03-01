using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System;
using System.Threading.Tasks;

namespace MonitoringConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            pingReply("ladjfxmevpwn01");
            pingReply("ladjfxmevpwn01ttm");
            pingReply("ladjfxmevpwn02");
            pingReply("ladjfxmevpwn02ttm");
            pingReply("ladjfxmevpwn03");
            pingReply("ladjfxmevpwn03ttm");
            pingReply("ladjfxmevpwn04");
            pingReply("ladjfxmevpwn04ttm");
            pingReply("ladjfxmevpwn05");
            pingReply("ladjfxmevpwn05ttm");
            pingReply("ladjfxmevpwn06");
            pingReply("ladjfxmevpwn06ttm");
            pingReply("ladjfxmevpwn07");
            pingReply("ladjfxmevpwn07ttm");
            pingReply("ladjfxmevpwn08");
            pingReply("ladjfxmevpwn08ttm");
            pingReply("ladjfxmevpwn09");
            pingReply("ladjfxmevpwn09ttm");
            pingReply("ladjfxmevpwn10");
            pingReply("ladjfxmevpwn10ttm");
            pingReply("ladjfxmevpwn11");

            Task.Delay(10000).Wait();
        }

        public static async void pingReply(String hostNameOrAddress)
        {
            var pingSender = new Ping();
            PingOptions options = new PingOptions ();
            options.DontFragment = true;
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes (data);
            int timeout = 120;

            try
            {
                var reply = await pingSender.SendPingAsync(hostNameOrAddress, timeout, buffer, options);
                Console.WriteLine($"{hostNameOrAddress} - {reply.Buffer.Length} bytes from {reply.Address}: icmp_seq={1} status={reply.Status} time={reply.RoundtripTime}ms");
            }
            catch(Exception e)
            {
                Console.WriteLine($"The hostname {hostNameOrAddress} - has no reply");
            }
            finally
            {
                
            }
        }
    }
}
