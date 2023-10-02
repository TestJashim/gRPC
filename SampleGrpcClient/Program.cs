using Grpc.Net.Client;

namespace SampleGrpcClient
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            //string serviceEndPoint = "http://localhost:5114";
            string serviceEndPoint = "https://localhost:7023";
            var channel = GrpcChannel.ForAddress(serviceEndPoint);
            var client = new Greeter.GreeterClient(channel);
            HelloRequest helloRequest = new HelloRequest
            {
                Name = "Jashim"
            };
            var response = await client.SayHelloAsync(helloRequest);

            Console.WriteLine($"Response obtained from the service {response.Message}");
        }
    }
}
