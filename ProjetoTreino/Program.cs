using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace TreinoCSharp
{
    class Program
    {
        enum Cor { Azul, Verde , Amarelo, Vermelho }
        static void Main(string[] args)
        {
            //CalculoIdade();
            //CalcularNota();
            //CalcularNota();
            //CalcularNota();
            FunctionSwitch();
            // ParaCadaUm();
            FuncEnum();


        }

        static void CalculoIdade()
        {
            int maiorIdade = 18;
            int naoPermite = 15;
            int idoso = 70;
            Console.WriteLine("Digite sua idade?");
            string idade = Console.ReadLine(); // ou posso fazer assim int idade = int.Parse(Console.ReadLine());
            int age = int.Parse(idade);

            if (age >= maiorIdade)
            {
                Console.WriteLine("Você tem: " + age + " anos, é  maior de idade. \né obrigatório votar.");
            }
            else if (age > naoPermite || age > idoso)
            {
                Console.WriteLine("Seu voto é facultativo. Sua idade é: " + age + " anos.");
            }
            else
            {
                Console.WriteLine("Você é menor não pode votar. Sua idade é: " + age + " anos.");
            }
        }

        static void CalcularNota()
        {
            Console.WriteLine("Digite a primeira nota:");
            float primeiraNota = float.Parse(Console.ReadLine());
            if (primeiraNota > 10)
            {
                Console.WriteLine("Digite um valor máximo de 10 pontos");
            }
            else
            {
                Console.WriteLine("Digite a segunda nota:");
                float segundaNota = float.Parse(Console.ReadLine());
                if (segundaNota > 10)
                {
                    Console.WriteLine("Digite um valor máximo de 10 pontos");
                }
                else
                {
                    Console.WriteLine("Digite a terceira nota:");
                }
                float terceiraNota = float.Parse(Console.ReadLine());
                if (terceiraNota > 10)
                {
                    Console.WriteLine("Digite um valor máximo de 10 pontos");
                }
                else
                {
                    float media = (primeiraNota + segundaNota + terceiraNota) / 3;

                    if (media > 6)
                    {
                        Console.WriteLine("Sua nota final é: " + media.ToString("F") + " Parabéns! Você foi aprovado!");
                    }
                    else if (media < 4)
                    {
                        Console.WriteLine("Sua nota final é: " + media.ToString("F") + " Infelismente, você foi Reprovado.");
                    }
                    else
                    {
                        Console.WriteLine("Sua nota final é: " + media.ToString("F") + " Você deve fazer a prova de Recuperação.");
                    }
                }
            }
            Console.WriteLine("Digite um valor a pagar: ");

            ComParams(float.Parse(Console.ReadLine()));
        }

        static void ComParams(float preco)
        {
            DateTime today = DateTime.Now;
            DateTime dataVenc = today.AddDays(21);

            Console.WriteLine(today);
            float precoFinal = preco;

            if (precoFinal >= 800)
            {
                float total = (precoFinal / 10) * 9;
                Console.WriteLine("Valor final Total: R$ " + preco.ToString("F"));
                Console.WriteLine("Valor final com desconto: R$ " + total.ToString("F"));
                Console.WriteLine("Vencimento: " + dataVenc);
            }
            else
            {
                Console.WriteLine("Valor final R$ " + precoFinal.ToString("F"));
                Console.WriteLine("Vencimento: " + dataVenc);
            }
        }

        static void FunctionSwitch()
        {
            string medico = "Marcelo";
            string procedimento = "Cardiologia";

            switch (medico)
            {
                case "Marcela":
                    Console.WriteLine("Nenhum médico encontrado");
                    break;
                case "Marcelo":
                    Console.WriteLine("Médico: " + medico + " " + procedimento);
                    break;
                default:
                    Console.WriteLine("Busca invalida");
                    break;
            }
        }

        static void ParaCadaUm()
        {
            string[] profissional =
            {
                "Roberto",
                "Alex",
                "Filipe",
                "Gustavo",
                "Isabela",
                "gabriela"
            };

            for(int i = 0; i < profissional.Length; i++)
            {
            Console.WriteLine(profissional[i]);
            }
        
        }

        static void FuncEnum()
        {
            Cor corFavorita = Cor.Amarelo;
            Console.WriteLine(corFavorita);
        }
    }
}
