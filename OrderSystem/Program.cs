using System;
using OrderSystem.Data;
using OrderSystem.Domain;
using OrderSystem.ValueObjects;

namespace OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // using var db = new Data.ApplicationContext();

            // var existMigration = db.Database.GetPendingMigrations().Any();
            // if(existMigration)
            // {

            // }

            Console.WriteLine("Hello World!");
        }

        private static void InserirDados()
        {
            var produto = new Produto
            {
                Descricao = "Produto teste",
                CodigoBarras = "1234567891231",
                Valor = 10m,
                TipoProduto = TipoProduto.Revenda,
                Ativo = true
            };

            using var db = new ApplicationContext();
            db.Produtos.Add(produto);
        }
    }
}