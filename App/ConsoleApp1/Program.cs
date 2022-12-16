using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            void aula06()
            {
                double salario = 1000;

                //while (salario < 5000) {
                //    salario = salario * 100;
                //    salario *= 2;
                //    Console.WriteLine("Meu salário é " + salario);
                //}

                int opcao = 1;

                //while (opcao == 1) {
                //    Console.WriteLine("Digite a opção desejada \n 1 - Repetir \n 2 - Sair");
                //    opcao = int.Parse(Console.ReadLine());
                //}

                //Console.WriteLine("Programa encerrado");


                //int aumento = 450;

                //while (aumento < 500) {
                //    Console.WriteLine("While" + aumento);
                //    aumento += 50;
                //}

                //do {
                //    Console.WriteLine("Do while" + aumento);
                //    aumento += 50;
                //} while (aumento < 500);

                //for (int i = 10; i >= 1; i--) {
                //    Console.WriteLine("O Valor de i é " + i);
                //}

                //int valor = 0;
                //Console.WriteLine("Digite um valor");
                //valor = Int16.Parse(Console.ReadLine());

                //Console.WriteLine("O número digitado, é "+ valor);

                //int repetir = 1;
                //while (repetir <= 2) {
                //    for (int i = 1; i <= 10; i++) {
                //        Console.WriteLine("Contagem " + i);
                //    }
                //    repetir++;
                //}

                //double[] notas = { 3, 5, 7, 10 };
                //Console.WriteLine(notas[3]);

                //double[] notas1 = new double[] { 3, 5, 6, 8 };
                //Console.WriteLine(notas1[1]);

                double[] notas2 = new double[4];
                notas2[0] = 5;
                notas2[1] = 8;
                notas2[2] = 1;
                notas2[3] = 3;
                Console.WriteLine(notas2);

                for (int i = 0; i < notas2.Length; i++)
                    Console.WriteLine("Nota " + (i + 1) + " é " + notas2[i]);

                //int p = 0;
                //foreach (var nota in notas2) {
                //    p++;
                //    Console.WriteLine("Nota " + p + " é " + nota);
                //}
                //int j = 0;
                //while (j < 4) {
                //    Console.WriteLine("Nota " + (j + 1) + " é " + notas2[j]);
                //    j++;
                //}
                //int v = 0;
                //do {
                //    Console.WriteLine("Nota " + (v + 1) + " é " + notas2[v]);
                //    v++;
                //} while (v < 4);

                string[,] dados = {
                {"Nome", "Idade" },
                {"Paulo", "12" },
                {"Gabriel", "30" }
                };

                //Console.WriteLine("Nome: " + dados[1, 0] + " e sua idade é " + dados[1, 1]);
                //for (int i = 1; i < 3; i++) {
                //    for (int j = 0; j < 2; j++) {
                //        if (j == 0) {
                //            Console.WriteLine("Seu nome é " + dados[i, j]);
                //        } else {
                //            Console.WriteLine("Sua idade é " + dados[i, j]);
                //        }   
                //    }
                //}

                //foreach (string v in dados) {
                //    Console.WriteLine(v+2);
                //}void Questao1()
            }

            void Questao1()
            {
                for (int i = 0; i <= 100; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            void Questao2()
            {
                Console.WriteLine("Digite o tamanho do vetor: ");
                int tamanho = int.Parse(Console.ReadLine());

                int[] vetor = new int[tamanho];
                for (int i = 0; i < tamanho; i++)
                {
                    Console.WriteLine("Digite o valor na posição " + i + " : ");
                    int valor = int.Parse(Console.ReadLine());
                    vetor[i] = valor;
                }
                Console.WriteLine("");
                Console.WriteLine("Seu vetor em forma inversa ficará assim: ");
                Console.WriteLine("");

                for (int j = tamanho-1; j >= 0; j--)
                {
                    Console.WriteLine(vetor[j]);
                }
            }
            void Questao3()
            {
                Console.WriteLine("Digite o tamanho do vetor: ");
                int tamanho = int.Parse(Console.ReadLine());

                int[] vetor = new int[tamanho];

                for (int i = 0; i < tamanho; i++)
                {
                    Console.WriteLine("Digite o valor do elemento na posição " + i + " : ");
                    int valor = int.Parse(Console.ReadLine());
                    vetor[i] = valor;
                }

                int menor = 0, maior = 0;
                for (int j = 0; j < tamanho; j++)
                {
                    if (j == 0)
                    {
                        maior = vetor[j];
                        menor = vetor[j];
                    }
                    else if (vetor[j] > maior)
                    {
                        maior = vetor[j];
                    }
                    else if (vetor[j] < menor)
                    {
                        menor = vetor[j];
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("O maior número digitado foi: " + maior);
                Console.WriteLine("O menor número digitado foi: " + menor);
            }
            void Questao4()
            {
                Console.WriteLine("Digite o tamanho do vetor: ");
                int tamanho = int.Parse(Console.ReadLine());

                int[] vetor = new int[tamanho];

                for (int i = 0; i < tamanho; i++)
                {
                    Console.WriteLine("Digite o valor do elemento na posição " + i + " : ");
                    int valor = int.Parse(Console.ReadLine());
                    vetor[i] = valor;
                }
                Array.Sort(vetor);
                Console.WriteLine();
                Console.WriteLine("Ele organizado ficará assim:");
                for (int j = 0; j < tamanho; j++)
                {
                    Console.WriteLine(vetor[j]);
                }
            }
            void Questao5()
            {
                Console.WriteLine("Digite o tamanho do vetor: ");
                int tamanho = int.Parse(Console.ReadLine());

                string[] vetor = new string[tamanho];

                bool achou = false;

                for (int i = 0; i < tamanho; i++)
                {
                    Console.WriteLine("Digite o nome na posição " + i + " : ");
                    string nome = Console.ReadLine();
                    vetor[i] = nome;
                }

                Console.WriteLine("Digite o nome que deverá ser procurado: ");
                string nomeProcurado = Console.ReadLine();

                for (int j = 0; j<tamanho; j++)
                {
                    if (vetor[j] == nomeProcurado)
                    {
                        achou = true;
                    }
                }
                if (achou)
                {
                    Console.WriteLine("Encontrado!");
                }
                else
                {
                    Console.WriteLine("Não encontrado!");
                }
            }
            Questao4();

            Console.ReadKey();
        }
    }
}

