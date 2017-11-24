namespace ExemplosLambda
{
    public abstract class Atividade // classes abstract precisam de metodos STATIC para serem chamados sem a classe ser stanciada
    {
        public static double Subtrair(int v1, int v2)
        {
            return v1-v2;
        }
        public static string Multiplicar (int v1, int v2)
        {
            return "O resultado é: " + (v1 * v2);
        }
    }
}