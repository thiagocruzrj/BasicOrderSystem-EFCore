using System;
using System.Collections.Generic;
using System.Text;

namespace LookeChallenge._1__Questao3._1._2___Facede.Domain
{
    public class Pagamento
    {
        public string Status { get; set; }
        public decimal Valor { get; set; }
        public MeioPagamento MeioPagamento { get; set; }

        // Possiveis meios de pagamento implementados direto 
        // na classe pagamento por brevidade do exemplo
        public string CartaoCredito { get; set; }
        public string LinhaDigitavelBoleto { get; set; }
        public string ConfirmacaoTransferencia { get; set; }
    }
}
