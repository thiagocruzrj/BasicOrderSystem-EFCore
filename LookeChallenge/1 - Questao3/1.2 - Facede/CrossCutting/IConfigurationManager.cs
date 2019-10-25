using System;
using System.Collections.Generic;
using System.Text;

namespace LookeChallenge._1__Questao3._1._2___Facede.CrossCutting
{
    public interface IConfigurationManager
    {
        string GetValue(string node);
    }
}
