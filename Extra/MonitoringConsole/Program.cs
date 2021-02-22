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
            // var hostNameOrAddress = "ladjfxmevpwn01";
            options.DontFragment = true;
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes (data);
            int timeout = 120;
            
            // Console.Clear();
            // Console.WriteLine($"PING {hostNameOrAddress}");

            try
            {
                var reply = await pingSender.SendPingAsync(hostNameOrAddress, timeout, buffer, options);
                Console.WriteLine($"{hostNameOrAddress} - {reply.Buffer.Length} bytes from {reply.Address}: icmp_seq={1} status={reply.Status} time={reply.RoundtripTime}ms");
            }
            catch(Exception e)
            {
                // Console.WriteLine(e);
                Console.WriteLine($"The hostname {hostNameOrAddress} - has no reply");
            }
            finally
            {
                
            }
        }



        // public static void AsyncComplexLocalPing()
        // {
        //     AutoResetEvent waiter = new AutoResetEvent(false);

        //     Ping pingSender = new Ping();

        //     pingSender.PingCompleted += new PingCompletedEventHandler(PingCompletedCallback);

        //     IPAddress address = IPAddress.Parse("10.23.19.108");

        //     string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
        //     byte[] buffer = Encoding.ASCII.GetBytes(data);

        //     int timeout = 10000;

        //     PingOptions options = new PingOptions(64, true);
        //     pingSender.SendPingAsync(address);//"ladjfxmevpwn01");
        //     // pingSender.SendAsync(address, timeout, buffer, options, waiter);

        //     // waiter.WaitOne();

        //     Console.WriteLine("Ping example completed.");
        // }

        //  private static void PingCompletedCallback (object sender, PingCompletedEventArgs e)
        // {
        //     // If the operation was canceled, display a message to the user.
        //     if (e.Cancelled)
        //     {
        //         Console.WriteLine ("Ping canceled.");

        //         // Let the main thread resume.
        //         // UserToken is the AutoResetEvent object that the main thread
        //         // is waiting for.
        //         ((AutoResetEvent)e.UserState).Set ();
        //     }

        //     // If an error occurred, display the exception to the user.
        //     if (e.Error != null)
        //     {
        //         Console.WriteLine ("Ping failed:");
        //         Console.WriteLine (e.Error.ToString ());

        //         // Let the main thread resume.
        //         ((AutoResetEvent)e.UserState).Set();
        //     }

        //     PingReply reply = e.Reply;

        //     DisplayReply (reply);

        //     // Let the main thread resume.
        //     ((AutoResetEvent)e.UserState).Set();
        // }

        // public static void DisplayReply (PingReply reply)
        // {
        //     if (reply == null)
        //         return;

        //     Console.WriteLine ("ping status: {0}", reply.Status);
        //     if (reply.Status == IPStatus.Success)
        //     {
        //         Console.WriteLine ("Address: {0}", reply.Address.ToString ());
        //         Console.WriteLine ("RoundTrip time: {0}", reply.RoundtripTime);
        //         Console.WriteLine ("Time to live: {0}", reply.Options.Ttl);
        //         Console.WriteLine ("Don't fragment: {0}", reply.Options.DontFragment);
        //         Console.WriteLine ("Buffer size: {0}", reply.Buffer.Length);
        //     }
        // }
    }
}
