using System;
using System.Text;
using Renci.SshNet;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace dotnetssh
{
    class Program
    {
        private static string username = "svjer";
        private static string password = "$giga";
        private static int port = 22;
        private static string host = "ladjfxmevnrb01";

        static void Main(string[] args)
        {
            ConnectToSSHClient();
        }

        private static void ConnectToSSHClient()
        {
            using(var sshclient = new SshClient(host, username, password))
            {
                sshclient.ConnectionInfo.Timeout = TimeSpan.FromSeconds(10);
                sshclient.Connect();
                ShellStream shellStream = sshclient.CreateShellStream("bash", 80, 24, 800, 600, 1024);

                string userInput = "";

                while(userInput != "exit")
                {
                    userInput = Console.ReadLine();
                    WriteStream(userInput, shellStream);
                    string answer = ReadStream(shellStream);
                    int index1 = answer.IndexOf(System.Environment.NewLine);
                    Console.WriteLine(answer.Trim());
                }
                Console.WriteLine("Disconnected");

                sshclient.Disconnect();
            }
            Console.WriteLine("Disconnected");
        }

        private static ConnectionInfo setupConnection(string host)
        {
             ConnectionInfo ConnNfo = new ConnectionInfo(host, port, username,
                new AuthenticationMethod[]{
                    new PasswordAuthenticationMethod(username, password)
                }
            );
            return ConnNfo;
        }

        private static void WriteStream(string cmd, ShellStream stream)
        {
            stream.WriteLine(cmd + "; echo this-is-the-end");
            while (stream.Length == 0)
                Thread.Sleep(100);
        }

        private static string ReadStream(ShellStream stream)
        {
            StringBuilder result = new StringBuilder();

            string line;
            while ((line = stream.ReadLine()) != "this-is-the-end")
                    result.AppendLine(line);

            return result.ToString();
        }
    }
}
