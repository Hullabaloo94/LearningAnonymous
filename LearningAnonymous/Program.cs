using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearningAnonymous
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("downloading file");
            Download();
            Console.ReadLine();

        }

        static void Download()
        {
            Network.Download((message) => Console.WriteLine("File Downloaded" + message));
        }
    }

    // Imaginary external network library

    class Network
    {
        static public void Download(Action<String> callback)
        {
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                callback("completed");
            });
        }
    }

}