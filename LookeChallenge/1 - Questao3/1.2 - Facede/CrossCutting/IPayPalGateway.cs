using System;
using System.Collections.Generic;
using System.Text;

namespace LookeChallenge._1__Questao3._1._2___Facede.CrossCutting
{
    public interface IPayPalGateway
    {
        string GetPayPalServiceKey(string apiKey, string encriptionKey);
        string GetCardHashKey(string serviceKey, string cartaoCredito);
        bool CommitTransaction(string cardHashKey, string orderId, decimal amount);
    }
}
