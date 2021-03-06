﻿/* program.cs
 * Descripción:
 * Servidor con protocolo TCP.
 * Asegura la conexión de 100 clientes.
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

namespace servidor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea el socket para envio de datos sobre TCP
            Socket sServidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //Socket Server HostName, IP Address and Port
            const int puerto = 4444;
            //Inicializa una nueva estancia de la clase IPEndPoint con la dirección y el número de puertos especificados
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, puerto); // Puerto 4444

            try {
                Console.WriteLine("Esperando conexión...");
                sServidor.Bind(ep);
                sServidor.Listen(100);
                sServidor.Accept();
                Console.WriteLine("Conectado con el servidor.");
            }
            catch {
                Console.WriteLine("Error al conectar con el servidor.");
            }
            Console.ReadKey();
            sServidor.Close();
        }
    }
}
