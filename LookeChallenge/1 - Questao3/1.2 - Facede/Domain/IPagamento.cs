using System;
using System.Collections.Generic;
using System.Text;

namespace LookeChallenge._1__Questao3._1._2___Facede.Domain
{
    public interface IPagamento
    {
        Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}
