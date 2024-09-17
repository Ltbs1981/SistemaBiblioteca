using System;

namespace SistemaBiblioteca
{
    public class Biblioteca
    {
        public string Titulo { get; set; }
        public string Ano { get; set; }
        public int DiasDeAluguel { get; set; }
        public double ValorAluguel { get; set; }
        public double MultaDiaria { get; set; }
        public bool Emprestado { get; private set; }

        public Biblioteca(string titulo, string ano, double valorAluguel, double multaDiaria, int diasDeAluguel)
        {
            Titulo = titulo;
            Ano = ano;
            DiasDeAluguel = diasDeAluguel;
            ValorAluguel = valorAluguel;
            MultaDiaria = multaDiaria;
            Emprestado = false;
        }

        public virtual void Alugar()
        {
            if (!Emprestado)
            {
                Emprestado = true;
                Console.WriteLine($"{Titulo} alugado com sucesso!");
            }
            else
            {
                Console.WriteLine($"{Titulo} já está alugado.");
            }
        }

        public void Devolver(int diasAtraso)
        {
            if (Emprestado)
            {
                Emprestado = false;
                double multa = diasAtraso * MultaDiaria;
                Console.WriteLine($"{Titulo} devolvido! Multa por atraso: R${multa}");
            }
            else
            {
                Console.WriteLine($"{Titulo} não foi alugado.");
            }
        }
    }
}
