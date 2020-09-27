using System;
using System.Linq;
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
            //InserirDadosEmMassa();
            ConsultarDados();
        }

        private static void ConsultarDados()
        {
            using var db = new ApplicationContext();
            //var consultaPorSintaxe = (from c in db.Clientes where c.Id > 0 select c).ToList();
            var consultarPorMetodo = db.Clientes.AsNoTracking().Where(p => p.Id > 0).OrderBy(p => p.Id).ToList();

            foreach (var cliente in consultarPorMetodo)
            {
                Console.WriteLine($"Consultando o cliente : {cliente.Id}");
                // db.Clientes.Find(cliente.Id);
                db.Clientes.FirstOrDefault(p => p.Id == cliente.Id);
            }
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

            var listaClientes = new[]
            {
                new Cliente
                {
                    Nome = "Thiago",
                    CEP = "20921333",
                    Cidade = "Logo",
                    Estado = "Lo",
                    Telefone = "21972914185"
                },
                new Cliente
                {
                    Nome = "Thiago2",
                    CEP = "20921233",
                    Cidade = "Logoo",
                    Estado = "Lq",
                    Telefone = "31972914185"
                }
            };

            using var db = new ApplicationContext();
            // db.AddRange(produto, cliente);
            db.Clientes.AddRange(listaClientes);
            var registros = db.SaveChanges();
            Console.WriteLine($"Total de registro(s): {registros}");
        }

    }
}