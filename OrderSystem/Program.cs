using System;
using Microsoft.EntityFrameworkCore;
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

            //Console.WriteLine("Hello World!");
            //InserirDados();
            InserirDadosEmMassa();
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
           // db.Produtos.Add(produto);
           // db.Set<Produto>().Add(produto);
           // db.Entry(produto).State = EntityState.Added;
           db.Add(produto);

           var registros = db.SaveChanges();
           Console.WriteLine($"Total de registro(s): {registros}");
        }

        private static void InserirDadosEmMassa()
        {

            var produto = new Produto
            {
                Descricao = "Produto teste",
                CodigoBarras = "1234567891231",
                Valor = 10m,
                TipoProduto = TipoProduto.Revenda,
                Ativo = true
            };

            var cliente = new Cliente
            {
                Nome = "Thiago",
                CEP = "20921333",
                Cidade = "Logo",
                Estado = "Lo",
                Telefone = "21972914185"
            };

            using var db = new ApplicationContext();
            db.AddRange(produto, cliente);

            var registros = db.SaveChanges();
            Console.WriteLine($"Total de registro(s): {registros}");
        }
    }
}