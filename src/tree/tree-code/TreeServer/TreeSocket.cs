using System.Net.WebSockets;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace TreeServer;

class TreeSocket : WebSocketBehavior
{
    public TreeSocket()
    {
        
    }
    protected override void OnMessage(MessageEventArgs e)
    {
        Console.WriteLine("Received message" + e.Data);
        Send("Joshua coulter sucks");
    }
}