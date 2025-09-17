using System;
using System.Collections.Generic;
// filepath: c:\Users\admin\Downloads\C#\testes\Program.cs

namespace testes
{
    class Program
    {
        static void Main(string[] args)
        {
            string divisor = "------------------------";

            List<string> tarefas = new List<string>();

            Console.WriteLine("\n==== MINHA LISTA DE TAREFAS ====");

            tarefas.Add("- Estudar C#");
            tarefas.Add("- Fazer exercícios");
            tarefas.Add("- Ler livros");

            foreach (string tarefa in tarefas)
            {
                Console.WriteLine(tarefa);
            }

            Console.WriteLine(divisor);

            Console.WriteLine("\n==== MINHA LISTA DE TAREFAS ATUALIZADA ====");

            tarefas.Insert(1, "- Praticar logica de programação");
            tarefas.Insert(4, "- Revisar conceitos");

            foreach (string tarefa in tarefas)
            {
                Console.WriteLine(tarefa);
            }

            Console.WriteLine(divisor);

            Console.WriteLine("\n==== MINHA LISTA DE TAREFAS COM REMOVEAT ====");

            tarefas.RemoveAt(2);

            foreach (string tarefa in tarefas)
            {
                Console.WriteLine(tarefa);
            }

            Console.WriteLine(divisor);

            Console.WriteLine("\n==== QUANTOS ELEMENTOS TEM NA LISTA DE TAREFAS ====");
            Console.WriteLine($"Total de tarefas: ");

            for (int i = 0; i < tarefas.Count; i++)
            {
                Console.WriteLine("| Tarefa " + (i + 1) + ": " + tarefas[i]);
            }
        }
    }
}
