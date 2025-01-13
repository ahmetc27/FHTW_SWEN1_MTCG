using System.Net.Sockets;

namespace MTCG_project;

public class Response
{
    private StreamWriter Writer {get; set;}
    public Response(TcpClient tcpClient)
    {
        Writer = new StreamWriter(tcpClient.GetStream());
        Writer.AutoFlush = true; // buffer is cleared immediately after each write operation
    }

    public void Ok()
    {
        Writer.WriteLine("HTTP/1.1 200 OK");
        Writer.Close();
        Console.WriteLine("OK");
    }
}