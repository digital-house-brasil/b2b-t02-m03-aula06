using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args) {
            //Faça um programa que imprima todos os números pares até 100
            void NumerosPares() {
                for (int i = 1; i <= 100; i++) {
                    Console.WriteLine(i);
                }
            }
            // NumerosPares();

            //Faça um programa que imprima todos os números ímpares que esteja entre 100 e 0, de forma inversa.
            void NumerosInmpares() {
                for (int i = 100; i >= 1; i--) {
                    Console.WriteLine(i);
                }
            }
            //NumerosInmpares();

            //Faça um programa que receba um array e imprima ele da forma inversa.
            //Exemplo:
            //Entrada:
            //[1, 2, 3, 4, 5]
            //Saída:
            //[5, 4, 3, 2, 1]
            void ArrayInverso() {
                int[] numeros = { 1, 2, 3, 4, 5 };

                for (int i = (numeros.Length) - 1; i >= 0; i--) {
                    Console.WriteLine(numeros[i]);
                }
            }
            //ArrayInverso();

            //Faça um programa que receba um array de números e imprima o maior e o menor número.
            //Exemplo:
            //Entrada:
            // [1, 2, 3, 4, 5]
            //Saída:
            // Maior: 5
            //Menor: 1
            void NumeroMaiorMenor() {
                int[] numeros = { 8, 6, 4, 2, 7 };

                int maior, menor;

                menor = numeros[0];
                for (int i = 1; i < numeros.Length; i++) {
                    if (menor > numeros[i])
                        menor = numeros[i];
                }

                maior = numeros[0];
                for (int i = 1; i < numeros.Length; i++) {
                    if (maior < numeros[i])
                        maior = numeros[i];
                }
                Console.WriteLine("Maior: " + maior);
                Console.WriteLine("Manor: " + menor);
            }
            //NumeroMaiorMenor();

            //Faça um programa que receba um array de números e ordene - o.O programa deve receber um array de números e ordená - lo.
            //Exemplo:
            //Entrada:
            // [6, 2, 5, 100, 23, 1]
            //Saída:
            // [1, 2, 5, 6, 23, 100]
            void OrdenacaoArray() {
                int[] numeros = { 56, 7, 4, 90, 1, 3 };

                for (int i = 0; i < numeros.Length; i++) {
                    for (int j = i+1; j < numeros.Length; j++) {
                        if (numeros[i] > numeros[j]) {  
                            int num = numeros[i];
                            numeros[i] = numeros[j];
                            numeros[j] = num;
                        }
                    }
                }

                foreach (int i in numeros) 
                    Console.WriteLine(i);
                
            }
            // OrdenacaoArray();

            //Faça um programa que receba um array com nomes de alunos e verificar se o nome do aluno está na lista.
            //Exemplo:
            //Entrada:
            //  ['João', 'Maria', 'José', 'Pedro']
            //  Procurar por: 'Maria'
            //Saída:
            //  Encontrado!

            void ProcurarNome() {
                string[] nomes = { "João", "Maria", "José", "Pedro" };

                string pesquisa = "Diego";
                bool achou = false;

                for (int i = 0; i < nomes.Length; i++) {
                    if (pesquisa == nomes[i]) {
                        achou = true;
                        break;
                    }
                }
                if (achou) {
                    Console.WriteLine("Encontrado");
                } else {
                    Console.WriteLine("Não encontrado");
                }
            }
            // ProcurarNome();

            Console.ReadKey();
        }
    }
}
