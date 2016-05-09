/* program.cs
 * Descripción:
 * Cliente con protocolo TCP.
 * Despliega un mensaje para indicar que la conexión se realizó correctamente.
 * Fecha: 21 de enero de 2015
 * Versión 1.0
 */

using System;
using System.Net;
using System.Net.Sockets;

namespace cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea el socket para envio de datos sobre TCP
            Socket sCliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4444); // Puerto 4444

            try {
                sCliente.Connect(ep);
                Console.WriteLine("Conectado");
            }
            catch {
                Console.WriteLine("Error al conectar con el servidor.");
            }
            Console.ReadKey();
            sCliente.Close();
        }
    }
}
