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
        enum Cor { Azul, Verde, Amarelo, Vermelho }
        enum Opcao { Criar = 1, Deletar, editar, Listar, Atualizar }
        static void Main(string[] args)
        {
            //CalculoIdade();
            //CalcularNota();
            //CalcularNota();
            //CalcularNota();
            //FunctionSwitch();
            // ParaCadaUm();
            //FuncEnum();
            //FuncDoWile();
            //FuncWhile();
            FuncFor();


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

            for (int i = 0; i < profissional.Length; i++)
            {
                Console.WriteLine(profissional[i]);
            }

        }

        static void FuncEnum()
        {
            Cor corFavorita = Cor.Amarelo;
            Console.WriteLine(corFavorita);
        }

        static void EdicaoEnum()
        {
            Console.WriteLine("Selecione uma das opoções abaixo: ");
            Console.WriteLine("1 - Criar\n2 - Deletar\n3 - Editar\n4 - Listar\n5 - Atualizar");
            int idEscolhido = int.Parse(Console.ReadLine());

            Opcao selecionado = (Opcao)idEscolhido;

            //Console.WriteLine(selecionado);


            //switch (idEscolhido)
            //{
            //    case 1:
            //        Console.WriteLine("Abrir função criar");
            //        break;
            //    case 2:
            //        Console.WriteLine("Podemos deletar");
            //        break;
            //    case 3:
            //        Console.WriteLine("Edição permitida");
            //        break;
            //    case 4:
            //        Console.WriteLine("Listar os itens");
            //        break;
            //    case 5:
            //        Console.WriteLine("Atualizar dados");
            //        break;
            //    default:
            //        Console.WriteLine("ERRO O número escolhido não corresponde a um id valido.");
            //        break;
            //}

            switch (selecionado)
            {
                case Opcao.Criar:
                    Console.WriteLine("Abrir função criar");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("Podemos deletar");
                    break;
                case Opcao.editar:
                    Console.WriteLine("Edição permitida");
                    break;
                case Opcao.Listar:
                    Console.WriteLine("Listar os itens");
                    break;
                case Opcao.Atualizar:
                    Console.WriteLine("Atualizar dados");
                    break;
                default:
                    Console.WriteLine("ERRO O número escolhido não corresponde a um id valido.");
                    break;
            }
        }

        static void FuncWhile()
        {
            int cont = 0;
            while (cont < 10)
            {
                Console.WriteLine(cont);
                if (cont == 8)
                {
                    Console.WriteLine("Achamos o 8");
                    break;
                }
                cont++;
            }
            Console.WriteLine("Fim de linha");
        }

        //static void FuncDoWile()
        //{
        //    int cont = 20;
        //    do { cont++; }
        //    while (cont < 10);

        //    Console.WriteLine(cont);

        //}

        static void FuncForEach()
        {
            int[] medicoExc = { 2, 58, 11 };
            int[] medicoIncluso = { 2, 8, 6, 69, 42, 58, 1, 11 };
            //Console.WriteLine(medicoIncluso[0]);

            foreach (int i in medicoExc)
            {
                if (i != 0)
                {
                    Console.WriteLine("Medicos Exclusos " + i);
                }
            }
        }

        static void FuncFor()
        {
            int[] medicoIncluso = { 2, 8, 6, 69, 42, 58, 1, 11 };
            for (int i = 0; i < medicoIncluso.Length; i++)
            {
                Console.WriteLine(medicoIncluso[i]);
            }
        }
    }
}
