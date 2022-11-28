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
        enum DiaSemana { Domingo = 1, Segunda, Terça, Quarta, Quinta, Sexta, sabado }
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
            //FuncFor();
            //FuncVenda();
            //ConvIntParse();
            //BitWiseUso();
            //DiaSemanaEnum();
            //FuncCast();
            //IfElseAninhado();
            //FuncArray();
            //FuncArrayBiDirec();
            //FuncSenha();
            FuncManipulandoArray();
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


        //CFB CURSOS - FORMATANDO SAIDA

        static void FuncVenda()
        {
            double valorCompra = 5.50;
            double lucro = 0.35;
            string[] produto = { "Coxinha", "Pastel", "Cigarrete" };
            double valorVenda = valorCompra + (valorCompra * lucro);

            Console.WriteLine("Salgado........:{0,10}", produto[1]);
            Console.WriteLine("valor..........:{0,10:c} ", valorCompra);
            Console.WriteLine("lucro..........:{0,10:p} ", lucro);
            Console.WriteLine("Valor final....:{0,10:c} ", valorVenda);

        }

        static void ConvIntParse()
        {
            int val1, val2, soma;
            Console.WriteLine("Digite o peirmeiro valor: ");
            val1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            val2 = Convert.ToInt32(Console.ReadLine());
            soma = val1 + val2;
            Console.WriteLine("O valor de {0} mais {1} é igual a {2}", val1, val2, soma);

        }

        static void BitWiseUso()
        //a função bitwise ou operadores de shift (<< e >>)      << dobrar valor  e >> Metade 
        {
            int dobro = 20;
            int metade = 20;
            dobro = dobro << 2;
            metade = metade >> 2;
            Console.WriteLine(metade);
            Console.WriteLine(dobro);
        }
        static void DiaSemanaEnum()
        {
            int dia = int.Parse(Console.ReadLine());

        inicio:

            DiaSemana diaFolga = (DiaSemana)dia;

            switch (diaFolga)
            {
                case DiaSemana.Domingo:
                    Console.WriteLine("Hoje é nossa folga " + diaFolga);
                    break;
                case DiaSemana.Segunda:
                case DiaSemana.Terça:
                case DiaSemana.Quarta:
                case DiaSemana.Quinta:
                case DiaSemana.Sexta:
                    Console.WriteLine("Hoje é trabalho " + diaFolga);
                    break;
                case DiaSemana.sabado:
                    Console.WriteLine("Hoje é nossa folga " + diaFolga);
                    break;
                default:
                    Console.WriteLine("Nenhum dia escolhido");
                    break;

            }

            Console.WriteLine("Escolher outro dia?");

            // função  goto

            dia = int.Parse(Console.ReadLine());
            if (dia > 0 & dia < 8)
            {
                goto inicio;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Fim da execução!");
            }

        }

        //conversão em typecast quando a conver~sao não é implicita ´precisamos converte-la com Convert ou Parse.

        static void FuncCast()
        {
            float n2 = 10.5f;
            // int n1 = Convert.ToInt32(n2);
            // int n1 = (int)n2;

            int n3 = 20;
            short n4 = (short)n3;

            Console.WriteLine(n4 + n2);

        }

        static void IfElseAninhado()
        {
            decimal nota1, nota2, nota3, media;
            Console.WriteLine("Digite as três notas em sequência: (Valor máximo 10)");
            nota1 = decimal.Parse(Console.ReadLine());
            nota2 = decimal.Parse(Console.ReadLine());
            nota3 = decimal.Parse(Console.ReadLine());
            media = (nota1 + nota2 + nota3) / 3;

            if (media > 6)
            {
                if (media > 9)
                {
                    Console.WriteLine("Aprovado com louvor. Nota: " + media.ToString("F"));
                }
                else
                {
                    Console.WriteLine("Aprovado. Nota: " + media.ToString("F"));
                }
            }
            else if (media < 4)
            {
                Console.WriteLine("Reprovado. Nota: " + media.ToString("F"));
            }
            else
            {
                Console.WriteLine("Prova final para tentar ser aprovado. Nota: " + media.ToString("F"));
            }

        }

        static void FuncArray()
        {

            //Formas de declarar arrays

            int[] num = new int[5];
            num[0] = 10;
            num[1] = 25;
            num[2] = 265;
            num[3] = 523;
            num[4] = 53;

            int[] num1 = new int[3] { 56, 84, 5 };
            int[] num2 = { 5, 87, 26 };

            foreach (int i in num)
            {
                foreach (int j in num1)
                {
                    Console.WriteLine(j);
                }
                Console.WriteLine(i);
            }

            for (int i = 0; i < num1.Length; i++)
            {
                Console.WriteLine("Numero For 'i' " + num1[i]);
                for (int j = 0; j < num2.Length; j++)
                {
                    Console.WriteLine("Numero For 'j' " + num2[j]);
                }
            }
        }

        static void FuncArrayBiDirec()
        {
            int[,] num = new int[3, 5] {
                {2,6,8,9,4 }, //linha 0
                {5,56,8,3,4 }, //linha 1
                {85,64,35,98,101 }  //linha 2
            };
            if (num[1, 3] < num[2, 1])
            {
                Console.WriteLine("true " + num[1, 3]);
            }
            else
            {
                Console.WriteLine("false " + num[2, 1]);
            }

            Console.WriteLine(num[0, 4]);
        }


        //senha

        static void FuncSenha()
        {
            string senha = "123";
            string senhaDig;
            int tentativas = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Digite sua senha:");
                senhaDig = Console.ReadLine();
                tentativas++;
            } while (senha != senhaDig);

            Console.Clear();
            Console.WriteLine("Senha correta, número de tentativas {0}", tentativas);
        }

        static void FuncManipulandoArray()
        {
            int[] vet = new int[5];
            int[] vet1 = new int[5];
            int[] vet2 = new int[5];
            int[,] matriz = new int[2, 5] { { 1, 3, 5, 6, 4 }, { 25, 4, 53, 2, 8 } };

            Random random = new Random();

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = random.Next(50);
            }

            Console.WriteLine("Elementos de vet");
            foreach (int i in vet)
            {
                Console.WriteLine(i);
            }

            //BinarySearch
            Console.WriteLine("BinarySearch");
            int procurado = 33;
            int pos = Array.BinarySearch(vet, procurado);
            Console.WriteLine("O valor {0} está na posição {1}", procurado, pos);
            Console.WriteLine("--------------------------------");

            //metodo copy

            Console.WriteLine("Copiar");
            Array.Copy(vet, vet1, vet.Length);
            foreach (int i in vet1)
            {
                Console.WriteLine(i);
            }
            Array.Sort(vet);
            Array.Reverse(vet);

            Console.WriteLine("-------------------------------");


            //Copiar para um testino

            Console.WriteLine("Copiar para:");
            vet.CopyTo(vet2, 0);
            foreach (int i in vet2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------------------------");

            //GetLowerBound retorna o menor indice
            Console.WriteLine("getLowerBound");
            int menorIndice = vet.GetLowerBound(0);
            int menorMatriz = matriz.GetLowerBound(1);
            Console.WriteLine("Menor indice do vet {0}", menorIndice);
            Console.WriteLine(menorMatriz);
            Console.WriteLine("---------------------------------");

            //getValue retorna um valor 

            Console.WriteLine("GetValue");
            int valor1 = Convert.ToInt32(vet.GetValue(3));
            int valor2 = Convert.ToInt32(matriz.GetValue(1, 2));
            Console.WriteLine("O valor da posição 3 do vet: {0}", valor1);
            Console.WriteLine("O valor da posição linah 1 coluna 3 do matriz: {0}", valor2);
            Console.WriteLine("---------------------------------"); Console.WriteLine("GetValue");


            Console.WriteLine("IndexOf");
            int posInd = Array.IndexOf(vet, 3);
            Console.WriteLine("O valor da posição 3 do vet: {0}", posInd);
            Console.WriteLine("---------------------------------");


            //reverse
        }

    }
}
