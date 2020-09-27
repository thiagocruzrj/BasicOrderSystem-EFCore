using System;
using System.Collections.Generic;
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
            //ConsultarDados();
            //CadastrarPedido();
            //ConsultarPedidoCarregamentoAdiantado();
            AtualizarDados();
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

        private static void CadastrarPedido()
        {
            using var db = new ApplicationContext();

            var cliente = db.Clientes.FirstOrDefault();
            var produto = db.Produtos.FirstOrDefault();

            var pedido = new Pedido
            {
                ClienteId = cliente.Id,
                IniciadoEm = DateTime.Now,
                FinalizadoEm = DateTime.Now,
                Observacao = "Teste",
                StatusPedido = StatusPedido.Analise,
                TipoFrete = TipoFrete.SemFrete,
                Itens = new List<PedidoItem>()
                {
                    new PedidoItem
                    {
                        ProdutoId= produto.Id,
                        Desconto = 0,
                        Quantidade = 1,
                        Valor = produto.Valor
                    },
                }
            };

            db.Pedidos.Add(pedido);
            db.SaveChanges();
        }
    
        private static void ConsultarPedidoCarregamentoAdiantado()
        {
            using var db = new ApplicationContext();
            var pedidos = db.Pedidos
                            .Include(p => p.Itens)
                            .ThenInclude(p => p.Produto)
                            .ToList();

            Console.WriteLine(pedidos.Count);
        }
    
        private static void AtualizarDados()
        {
            using var db = new ApplicationContext();
            // var cliente = db.Clientes.Find(3);

            var cliente = new Cliente
            {
                Id = 1
            };

            var clienteDesconectado = new 
            {
                Nome = "Cliente Desconectado passo 3",
                Telefone = "98979304158"
            };

            db.Attach(cliente);
            db.Entry(cliente).CurrentValues.SetValues(clienteDesconectado);
            // db.Entry(cliente).State = EntityState.Modified;
            // PARA FAZER A ATUALIZAÇÃO SOMENTE DOS DADOS NECESSÁRIOS DEVEMOS COMENTAR O METODO UPDATE, POIS ELE ATUALIZA TODA A TABELA
            // db.Clientes.Update(cliente);
            db.SaveChanges();
        }
    }
}