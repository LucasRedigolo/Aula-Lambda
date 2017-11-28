using System;
using System.Collections.Generic;
using System.Linq;

namespace ExemplosLambda {
    class Program {
        static void Main (string[] args) {
            // Func<int, int, int> res = Soma; // func cabe até 16 parametros, sendo que o ultimo sempre será o parametro de SAIDA (ou seja, o parametro do retorno)
            // System.Console.WriteLine (res (50, 50));

            // Func <int, int, double> res = Atividade.Subtrair; // o ultimo parametro sempre tem que ser do tipo que o metodo retorna
            // System.Console.WriteLine(res(100, 50));

            // Func<int,int,string> ser = Atividade.Multiplicar;
            // System.Console.WriteLine(ser(10,3));

            // Action<int, int> res = Soma; // executa o código usando os parâmetros e não retorna nada
            // res (20, 30);

            // Predicate<int> res = Par; // sempre retorna um valor BOOLEANO
            // System.Console.WriteLine(res(20));

            //     // Data ds = delegate (string msg) { // utilizando um metodo anonimo
            //     //     return msg + "Hoje é " + DateTime.Now;
            //     // };
            //     // System.Console.WriteLine (ds ("Olá... Sextou!\n "));
            // }

            // static void Soma (int v1, int v2) {
            //     System.Console.WriteLine (v1 + v2);
            // }
            // static bool Par (int valor) {
            //     return valor % 2 == 0; // % faz uma divisão exata e subtrai os valores por eles mesmos
            // }

            // delegate string Data (string Mensagem);

            // int[] valores = { 40, 32, 65, 23, 13 };

            // Func<int, bool> res = delegate (int x) {
            //     return x % 2 == 0;
            // };

            // foreach (int i in valores)
            //     if (res (i))
            //         System.Console.WriteLine (i);

            // Func<int, bool> res = x => x % 2 == 0; //função lambda dos metodos acima

            // foreach (int i in valores)
            //     if (res (i))
            //         System.Console.WriteLine (i);

            // Func<double, double, double> calculo = (x, y) => x/y;
            // System.Console.WriteLine(calculo(6.0,2.0));

            // List<string> cidades = new List<string> ();

            // cidades.Add ("Campinas");
            // cidades.Add ("Rio");
            // cidades.Add ("Salvador");
            // cidades.Add ("Vitoria");
            // cidades.Add ("Natal");

            // var cid = cidades.Where(x=>x.Length<=5); // Linq usado para pesquisar dentro da lista
            // foreach (string i in cid)
            //     System.Console.WriteLine (i.ToUpper());

            // List<Alunos> aluno = new List<Alunos> () {
            //     new Alunos { Id = 32, Nome = "Lucas", Email = "lucas@lindo", Idade = 21 },
            //     new Alunos { Id = 597, Nome = "Jaime", Email = "Jaime@sirilo", Idade = 42 },
            //     new Alunos { Id = 217, Nome = "Pablo", Email = "Pablo@lindo", Idade = 30 },
            //     new Alunos { Id = 471, Nome = "Ana", Email = "ana@banana", Idade = 15 }
            // };
            // // var res = from x in aluno where x.Idade > 20 && x.Idade < 50 select x;
            // // foreach (Alunos al in res)
            // // System.Console.WriteLine(al.Id + " - " + al.Nome + " - " + al.Idade + " - " + al.Email);

            // var res = aluno.Count(x=> x.Email.Contains("lindo")); // Count serve para contar quantos itens cumprem determinada logica
            // System.Console.WriteLine(res);

            List<Produto> prod = new List<Produto> () {
                new Produto { IdProduto = 1, NomeProduto = "Lapis", Preco = 2, IdFornecedor = 30 },
                new Produto { IdProduto = 2, NomeProduto = "Borracha", Preco = 3, IdFornecedor = 41 },
                new Produto { IdProduto = 3, NomeProduto = "Caneta", Preco = 4, IdFornecedor = 30 },
                new Produto { IdProduto = 4, NomeProduto = "Caderno", Preco = 15, IdFornecedor = 41 }
            };
            List<Fornecedor> forne = new List<Fornecedor> {
                new Fornecedor { IdFornecedor = 30, RazaoSocial = "Faber Castel", Telefone = "11" },
                new Fornecedor { IdFornecedor = 41, RazaoSocial = "Bic", Telefone = "21" },
                new Fornecedor { IdFornecedor = 51, RazaoSocial = "Chameco", Telefone = "45" }
            };
            var resultado = prod.Join ( // usado para mesclar duas listas distintas
                forne,
                p => p.IdFornecedor, // o primeiro item se refere a qual lista que chamou o metodo Join
                f => f.IdFornecedor,
                (p, f) => new { pNome = p.NomeProduto, fRazao = f.RazaoSocial });

                foreach (var x in resultado)
                System.Console.WriteLine(x.pNome + " -- " + x.fRazao);
        }
    }
}