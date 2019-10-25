using System;
using System.Collections.Generic;
using System.Text;

namespace LookeChallenge._1__Questao3._1._1___AbstractFactory
{
    public class ExecucaoAbstractFactory
    {
        public static void Executar()
        {
            var vSocorro = new List<Veiculo>
            {
                VeiculoCreator.Criar("Kwid", Porte.Pequeno),
                VeiculoCreator.Criar("Civic", Porte.Medio),
                VeiculoCreator.Criar("Evoke", Porte.Grande)
            };
            vSocorro.ForEach(v => AutoSocorro.CriarAutoSocorro(v).RealizarAtendimento());
        }
    }
}
