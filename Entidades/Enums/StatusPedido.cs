using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Entidades.Enums
{
    enum StatusPedido : int
    {
        PagamentoPendente = 0,
        Processando = 1,
        Enviado = 2,
        Entregue = 3
    }
}
