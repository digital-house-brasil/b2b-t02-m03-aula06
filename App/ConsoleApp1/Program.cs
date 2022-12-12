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
        static void Main(string[] args) {
            // Calculo da média

            //
            int[] notas = { 4, 5,6,7};
            string[,] resultadoMedia = {
                { "5", "Reprovado" },
                { "7", "Recuperação" },
                { "8", "Aprovado" },
            };

            int soma = 0;
            for (int i = 0; i < notas.Length; i++) {
                soma += notas[i];
            }
            double media = soma / notas.Length;

            Console.WriteLine(resultadoMedia[1, 0]);
           

            

        }
    }
}
