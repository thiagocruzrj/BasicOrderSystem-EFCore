using System;
using System.Collections.Generic;
using System.Text;

namespace LookeChallenge._1__Questao3._1._1___AbstractFactory
{
    public class SocorroVeiculoGrandeFactory : AutoSocorroFactory
    {
        public override Guincho CriarGuincho()
        {
            return GuinchoCreator.Criar(Porte.Grande);
        }

        public override Veiculo CriarVeiculo(string modelo, Porte porte)
        {
            return VeiculoCreator.Criar(modelo, porte);
        }
    }
}
