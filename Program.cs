using System;
using ConsoleApp8.Entidades;
using ConsoleApp8.Entidades.Enums;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido1 = new Pedido { Id = 1, Momento = DateTime.Now, Status = StatusPedido.Enviado };
            Console.WriteLine(pedido1);


            string texto = StatusPedido.PagamentoPendente.ToString();

            Console.WriteLine(StatusPedido.Processando);

            StatusPedido pedido2 = Enum.Parse<StatusPedido>("PagamentoPendente");

            Console.WriteLine(pedido2);
        }
    }
}
