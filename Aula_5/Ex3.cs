namespace Exercicio3
{
    internal class Exercicio3
    {
        static void ex3()
        {
            System.Console.WriteLine("Digite o DDD: ");
            int ddd = int.Parse(Console.ReadLine());

            switch (ddd){
                case int n when n >= 41 && n<=46:
                    System.Console.WriteLine("Paraná");
                    break;
                case int n when n >= 51 && n<=55:
                    System.Console.WriteLine("Rio Grande do Sul");
                    break;
                case 61:
                    System.Console.WriteLine("Brasília");
                    break;
                case int n when n == 62 || n == 64:
                    System.Console.WriteLine("Mato Grosso");
                    break;
                case 67:
                    System.Console.WriteLine("Mato Grosso do Sul");
                    break;
            }
                
        }
    }
}