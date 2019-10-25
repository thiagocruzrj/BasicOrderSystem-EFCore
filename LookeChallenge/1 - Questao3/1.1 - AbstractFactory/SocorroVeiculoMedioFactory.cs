using System;
using System.Collections.Generic;
using System.Text;

namespace LookeChallenge._1__Questao3._1._1___AbstractFactory
{
    public class SocorroVeiculoMedioFactory : AutoSocorroFactory
    {
        public override Guincho CriarGuincho()
        {
            return GuinchoCreator.Criar(Porte.Medio);
        }

        public override Veiculo CriarVeiculo(string modelo, Porte porte)
        {
            return VeiculoCreator.Criar(modelo, porte);
        }
    }
}
