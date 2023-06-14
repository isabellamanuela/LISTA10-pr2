using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LISTA10_PR2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {


            Console.Write("escreva o tamanho do vetor: ");
            int p = int.Parse(Console.ReadLine());

            float[] vetor = new float[p];

            for (int o = 0; o < p; o++)
            {
                Console.Write("escreva o número {0}: ", p+ 1);
                vetor[o] = float.Parse(Console.ReadLine());
            }

            float menor  = vetor[0];
            float maior = vetor[0];
            float soma = vetor[0];

            for (int o = 1; o < p; o++)
            {
                if (vetor[o] < menor)
                    menor = vetor[o];
                if (vetor[o] > maior)
                    maior = vetor[o];

                soma += vetor[o];
            }

            float media = soma / p;

            Console.WriteLine("Menor número: " + menor);
            Console.WriteLine("Maior número: " + maior);
            Console.WriteLine("Média aritmética: " + media);
        }
        public static void Exercicio2()
        {
            Console.Write("Digite o tamanho do vetor: ");
            int p = int.Parse(Console.ReadLine());

            while (p <= 0)
            {
                Console.WriteLine("O tamanho do vetor precisa ser maior que zero. Tente novamente.");
                Console.Write("escreva o tamanho do vetor: ");
                p = int.Parse(Console.ReadLine());
            }
        
            float[] vetor = new float[p];

            for (int o = 0; o < p; o++)
            {
                Console.Write("Digite o número {0}: ", o+ 1);
                vetor[o] = float.Parse(Console.ReadLine());
            }

            float soma = 0;

            for (int o = 0; o < p; o++)
            {
                soma += vetor[o];
            }

            float media = soma / p;

            Console.WriteLine("\nNúmero maior ou igual à média:");

            for (int o = 0; o< p; o++)
            {
                if (vetor[o] >= media)
                {
                    Console.WriteLine(vetor[o]);
                }
            }
        }
        public static void Exercicio3()
        {
            Console.Write("Digite o tamanho do vetor: ");
            int p = int.Parse(Console.ReadLine());
            Random rand = new Random();

            while (p <= 0)
            {
                Console.WriteLine("O tamanho do vetor precisa ser maior que zero. Tente novamente.");
                Console.Write("escreva o tamanho do vetor: ");
                p = int.Parse(Console.ReadLine());
            }

            float[] vetor = new float[p];

            for (int o = 0; o < p; o++)
            {

                vetor[o] = rand.Next(10, 50);

            }

            float soma = 0;

            for (int o = 0;  o < p; o++)
            {
                soma += vetor[o];
            }

            float media = soma / p;

            Console.WriteLine("\nNúmeros maiores ou iguais à média:");

            for (int o = 0; o < p; o++)
            {
                if (vetor[o] >= media)
                {
                    Console.WriteLine(vetor[o]);
                }
            }
        }
        public static void Exercicio4()
        {
            Console.Write("escreva o número de assinaturas: ");
            int p = int.Parse(Console.ReadLine());

            string[] lista = new string[p];

            for (int o = 0; o < p; o++)
            {
                Console.Write("escreva o nome da assinatura {0}: ", o + 1);
                lista[o] = Console.ReadLine();

            }
            for (int o = p - 1; o >= 0; o--)
            {

                Console.WriteLine("posição [{0}] = {1}", o, lista[o]);


            }
        }
        public static void Exercicio5()
        {
            Console.Write("escreva o tamanho do vetor: ");
            int p = int.Parse(Console.ReadLine());
            Random rand = new Random();

            while (p <= 0)
            {
                Console.WriteLine("O tamanho do vetor precisa ser maior que zero. Tente novamente.");
                Console.Write("escreva o tamanho do vetor: ");
                p = int.Parse(Console.ReadLine());
            }

            float[] vetor = new float[p];

            for (int o = 0; o < p; o++)
            {

                vetor[o] = rand.Next(10, 50);

            }

            int In = 0, o = 0;

            for (int o = 0; o < p; o++)
            {

                if (vetor[o] % 2 == 0)
                {
                    PARES = PARES + 1;
                }
                else
                {
                    In = In + 1;
                }
                Console.WriteLine("a soma dos pares é" + p);
                Console.WriteLine("a soma dos impares é" + In);
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            int opcao;

            do
            {

                Console.WriteLine("==================menu=================");
                Console.WriteLine("para sair digite 0");
                Console.WriteLine("para executar o exercicio 1 - digite 1");
                Console.WriteLine("para executar o exercicio 2 - digite 2");
                Console.WriteLine("para executar o exercicio 3 - digite 3");
                Console.WriteLine("para executar o exercicio 4 - digite 4");
                Console.WriteLine("para executar o exercicio 5 - digite 5");
                Console.WriteLine("======================================");
                opcao = int.Parse(Console.ReadLine());


                switch (opcao)
                {
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    case 5:
                        Exercicio5();
                        break;
                    default:
                        Console.WriteLine(" numero não é um exercicio valido");
                        break;
                }

            } while (opcao != 0);
        }
    }
}

