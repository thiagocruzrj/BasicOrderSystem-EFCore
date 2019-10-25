using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LookeChallenge._1__Questao3._1._2___Facede.CrossCutting
{
    public class ConfigurationManager : IConfigurationManager
    {
        public string GetValue(string node)
        {
            return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }
}
