using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Channels;

namespace MTCG_project;

public class Server
{
    private TcpListener Listener; 
    public Server()
    {
        Listener = new TcpListener(IPAddress.Loopback, 10101);
        Listener.Start();
    }

    public void Run()
    {
        while(true)
        {
            var client = Listener.AcceptTcpClient();
            // ToDo Add Thread
            Request request = new Request(client);
            Console.WriteLine(request.Method);
            Console.WriteLine(request.Path);
            Console.WriteLine(request.Version);
            foreach(var header in request.Headers)
            {
                Console.WriteLine($"{header.Key}: {header.Value}");
            }
            Console.WriteLine(request.Body);
            Response response = new Response(client);
            response.Ok();
        }
    }
}