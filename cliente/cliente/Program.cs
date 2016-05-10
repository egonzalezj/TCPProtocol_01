/* program.cs
 * Descripción:
 * Cliente con protocolo TCP.
 * Despliega un mensaje para indicar que la conexión se realizó correctamente.
 * Fecha: 21 de enero de 2015
 * Versión 1.0
 * 
 * History:
 *  v1.1    09/05/2016  Adición de constantes para hostname.
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
            //Socket Server HostName, IP Address and Port
            const int puerto = 4444;
            IPAddress iplocal = new IPAddress(new byte[] {127, 0, 0, 1});
            //Inicializa una nueva estancia de la clase IPEndPoint con la dirección y el número de puertos especificados
            IPEndPoint ep = new IPEndPoint(iplocal, puerto); // Puerto 4444

            try {
                sCliente.Connect(ep);
                Console.WriteLine("Conectado.");
            }
            catch {
                Console.WriteLine("Error al conectar con el servidor.");
            }
            Console.ReadKey();
            sCliente.Close();
        }
    }
}