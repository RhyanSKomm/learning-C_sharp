using System.ComponentModel;

namespace Exercicio4
{
    internal class Exercicio4
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            
            while (true)
            {
                System.Console.WriteLine("Digite a quantidade de números que deseja, -1 para finalizar");
                int num = int.Parse(Console.ReadLine());

                if(num != -1){
                    nums.Add(num);
                    continue;
                }
                int maior = nums [0];
                int menor = nums [0];

                for (int i = 1; i < nums.Count; i++){
                    if (nums[i] > maior){
                        maior = nums[i];
                    }
                    if (nums[i] < menor){
                        menor = nums [i];
                    }
                }
                System.Console.WriteLine($"Maior:{maior}");
                System.Console.WriteLine($"Menor:{menor}");
            }
        }
    }
}