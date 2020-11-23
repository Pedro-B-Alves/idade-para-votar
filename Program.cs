using System;

namespace idade_para_votar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o ano atual");
            int ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seu ano de nascimento");
            int nascimento = int.Parse(Console.ReadLine());
            int idade = ano - nascimento;
            if(idade >= 16){
                Console.WriteLine($"Você pode votar este ano, pois você tem {idade} anos.");
            }else{
                Console.WriteLine($"Você não pode votar este ano, pois você é menor de 16 anos.");
            }
            
        }
    }
}
