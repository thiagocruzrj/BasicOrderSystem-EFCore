using System;
using System.Collections.Generic;
using System.Text;

namespace LookeChallenge._1__Questao3._1._2___Facede.Domain
{
    public class Pedido
    {
        public Guid Id { get; set; }
        public decimal Valor { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
