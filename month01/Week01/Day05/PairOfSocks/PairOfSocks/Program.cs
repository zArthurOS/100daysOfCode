string sockets = "CABBACCC";

int socketsPair = Sockets.findPairs(sockets);

Console.WriteLine($"Found {socketsPair} pairs.");

Console.ReadKey();


public static class Sockets
{
    public static int findPairs(string sockets)
    {
        int SocketsPair = 0;
        var list = new HashSet<char>(sockets);

        foreach(var socket in list)
        {
            SocketsPair += CountPair(socket, sockets);
        }

        return SocketsPair / 2;
    }

    private static int CountPair(char socket, string sockets)
    {
        return sockets.Count(item => item == socket);
    }

}