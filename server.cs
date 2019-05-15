using System;
using System.IO.Pipes;
using System.Text;

namespace NamedPipesPython {
    class Program {
        static void Main(string[] args) {

            NamedPipeServerStream server = new NamedPipeServerStream("Server", PipeDirection.InOut, 1, PipeTransmissionMode.Message);
            
            server.WaitForConnection();

            byte[] bytes_to_write = Encoding.ASCII.GetBytes("Hello Python");

            server.Write(bytes_to_write, 0, bytes_to_write.Length);

            byte[] bytes_to_read = new byte[1];
            string message = "";
            do {
                server.Read(bytes_to_read, 0, 1);
                message += Encoding.UTF8.GetString(bytes_to_read);
            } while (!server.IsMessageComplete);

            Console.Write(message);
            server.Disconnect();
            server.Close();

        }
    }
}
