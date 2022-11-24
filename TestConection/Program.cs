using System;
using System.Collections.Generic;
using System.Threading;
using CapaDatos;
using CapaNegocio;
using Common;

namespace TestConection
{
    class Program
    {
        static void Main(string[] args)
        {

            QueryDB queryDB = new QueryDB();
            RequestsDA requestsDA = new RequestsDA();
            List<string> lista = requestsDA.GetNotesTicket("202261933");
            
            foreach(var nota in lista)
            {
                Console.WriteLine(nota);
            }
           

            Console.Read();

        }


    }
}
