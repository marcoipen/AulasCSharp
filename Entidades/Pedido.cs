using System;
using ConsoleApp8.Entidades.Enums;

namespace ConsoleApp8.Entidades
{
    class Pedido
    {
        public int Id { get; set; }
        public DateTime Momento { get; set; }
        public StatusPedido Status { get; set; }

               public override string ToString()
        {
            return Id + ", " + Momento + ", " + Status;
        }
    }
}
