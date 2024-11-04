namespace Exercicio2
{
    internal class Exercicio2
    {
        static void ex2()
        {
            System.Console.WriteLine("Digite uma Palavara: ");
            string palavra = Console.ReadLine();

            if (palavra == "Digix"){
                System.Console.WriteLine("Acesso autorizado.");
            } else {
                System.Console.WriteLine("Acesso negado");
            }
        }
    }
}