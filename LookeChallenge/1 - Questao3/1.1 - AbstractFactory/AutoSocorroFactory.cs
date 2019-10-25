using System;
using System.Collections.Generic;
using System.Text;

namespace LookeChallenge._1__Questao3._1._1___AbstractFactory
{
    public abstract class AutoSocorroFactory
    {
        public abstract Guincho CriarGuincho();
        public abstract Veiculo CriarVeiculo(string modelo, Porte porte);
    }
}
