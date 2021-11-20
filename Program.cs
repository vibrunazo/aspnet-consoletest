using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao separador de listas");
            List<int> primeiroGrupo = new List<int>();
            List<int> segundoGrupo = new List<int>();
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Digite um número entre 1 e 20");
                string input = "";
                int number;
                try
                {
                    input = Console.ReadLine();
                    number = Int32.Parse(input);
                }
                catch (Exception)
                {
                    Console.WriteLine("número inválido");
                    continue;
                }
                if (number < 1 | number > 20) continue;
                if (number % 2 == 0 && number <= 10)
                {
                    primeiroGrupo.Add(number);
                    Console.WriteLine("Adicionei na 1a lista: " + i + " a lista agora tem tamanho: " + primeiroGrupo.Count);
                }
                if (number > 10)
                {
                    segundoGrupo.Add(number);
                    Console.WriteLine("Adicionei na 2a lista: " + i + " a lista agora tem tamanho: " + segundoGrupo.Count);
                }
                
            }

            string stringDaPrimeiraLista = "";
            primeiroGrupo.ForEach(n => stringDaPrimeiraLista += n + " ");
            Console.WriteLine("Lista 1: " + stringDaPrimeiraLista);

            string stringDaSegundaLista = "";
            segundoGrupo.ForEach(n => stringDaSegundaLista += n + " ");
            Console.WriteLine("Lista 2: " + stringDaSegundaLista);


        }
    }
}
