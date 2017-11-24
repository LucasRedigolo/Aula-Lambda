using System;

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

            Func<double, double, double> calculo = (x, y) => x/y;
            System.Console.WriteLine(calculo(6.0,2.0));
        }
    }
}