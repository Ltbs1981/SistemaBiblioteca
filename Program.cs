using SistemaBiblioteca;
using System;

class Program
{
    static void Main(string[] args)
    {
        Livro livro = new Livro("O Senhor dos Anéis", "1954");
        Revista revista = new Revista("Revista Época", "2009");
        Filme filme = new Filme("Top Gun", "1986");

        while (true)
        {
            Console.WriteLine("\nSistema de Biblioteca");
            Console.WriteLine("1. Alugar Livro");
            Console.WriteLine("2. Alugar Revista");
            Console.WriteLine("3. Alugar Filme");
            Console.WriteLine("4. Devolver Livro");
            Console.WriteLine("5. Devolver Revista");
            Console.WriteLine("6. Devolver Filme");
            Console.WriteLine("7. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();


            switch (opcao)
            {
                case "1":
                    livro.Alugar();
                    break;
                case "2":
                    revista.Alugar();
                    break;
                case "3":
                    filme.Alugar();
                    break;
                case "4":
                    Console.Write("Quantos dias de atraso? ");
                    int atrasoLivro = int.Parse(Console.ReadLine());
                    livro.Devolver(atrasoLivro);
                    break;
                case "5":
                    Console.Write("Quantos dias de atraso? ");
                    int atrasoRevista = int.Parse(Console.ReadLine());
                    revista.Devolver(atrasoRevista);
                    break;
                case "6":
                    Console.Write("Quantos dias de atraso? ");
                    int atrasoFilme = int.Parse(Console.ReadLine());
                    filme.Devolver(atrasoFilme);
                    break;
                case "7":
                    Console.WriteLine("Saindo...");
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
