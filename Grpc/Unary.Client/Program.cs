using System;
using Grpc.Core;

namespace Unary.Client
{
    class Program
    {
        static void Main(string[] args)
        {

            Channel channel = new Channel("127.0.0.1:5001", ChannelCredentials.Insecure);
           
            // using var channel = GrpcChannel.ForAddress("http://localhost:5001");
            Console.WriteLine("Hello World!");
        }
    }
}
