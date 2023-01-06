using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MediaService
    {
        public string Nome { get; set; }
        double[] Notas = new double[3];
        public double Media { get; set; }


        public void ReceberDados()
        {
            Console.WriteLine("Digite o nome do aluno: ");
            Nome = Console.ReadLine();




            for (int i = 0; i < Notas.Length; i++)
            {
                Console.WriteLine("Digite a nota " + (i + 1));
                var valido = false;
                while (!valido)
                {
                    try
                    {

                        Notas[i] = double.Parse(Console.ReadLine());
                        valido = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Você deve digitar um número.");
                    }
                }
                

            }

        }
        public void CalcularMedia()
        {
            double soma = 0;

            for (int i = 0; i < Notas.Length; i++)
            {
                soma += Notas[i];
            }
            Media = soma / Notas.Length;

            if (Media >= 7)
            {
                Console.WriteLine("Aluno Aprovado");
            }
            else
            {
                Console.WriteLine("Aluno Reprovado");
            }
        }
        public void DevolverResultado()
        {
            Console.WriteLine("Nome do aluno: " + Nome);
            Console.WriteLine("Média do aluno: " + Media);
            Console.ReadKey();
        }
    }
}


