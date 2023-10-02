# gRPC

## gRPC Client
```csharp
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
```

This code is a C# program that acts as a gRPC client. It communicates with a gRPC service located at a specific endpoint (either "http://localhost:5114" or "https://localhost:7023") and sends a request to that service. Once it receives a response from the service, it prints the response message to the console.

Here's a step-by-step explanation of the code:

1. Importing Required Libraries:
   - The code begins by importing the necessary libraries. In this case, it uses the `Grpc.Net.Client` namespace, which is part of the gRPC library for .NET.

2. `Main` Method:
   - The `Main` method is the entry point of the program, which is invoked when the program starts running.

3. Setting the Service Endpoint:
   - The service endpoint is the URL where the gRPC service is hosted. There are two service endpoint URLs provided in the code as comments: "http://localhost:5114" and "https://localhost:7023". Depending on which one is chosen, you would uncomment the corresponding line.

4. Creating a gRPC Channel:
   - The `GrpcChannel.ForAddress` method is used to create a gRPC channel for communication with the gRPC service. It takes the service endpoint URL as an argument.

5. Creating a gRPC Client:
   - After creating the channel, a gRPC client is instantiated using the `Greeter.GreeterClient` class, which is generated from the gRPC service definition. This client is used to make RPC (Remote Procedure Call) requests to the service.

6. Creating a Request:
   - A `HelloRequest` object is created and initialized with a `Name` property set to "Jashim". This request will be sent to the gRPC service.

7. Making an Async gRPC Request:
   - The `client.SayHelloAsync` method is used to send the `helloRequest` to the gRPC service asynchronously. It returns a task, and the program awaits this task using the `await` keyword.

8. Handling the Response:
   - Once the gRPC call is complete, the program receives a response from the service. The response is stored in the `response` variable.

9. Printing the Response:
   - Finally, the program prints the response message obtained from the service to the console using `Console.WriteLine`.

To summarize, this code sets up a gRPC client, sends a "Hello" request to a gRPC service at a specified endpoint, waits for the response, and then prints the response message to the console. It demonstrates how to use gRPC in a C# application to communicate with a remote service.
