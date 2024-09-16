using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    public class Biblioteca
    {

        public string  Titulo { get; set; }
        public string  Ano { get; set; }
        public int DiasDeAluguel { get; set; }
        public double  ValorAluguel { get; set; }
        public double   MultaDiaria{ get; set; }

        public Biblioteca(string titulo, string ano, double valorAluguel, double multaDiaria, int diasDeAluguel)
        {
            Titulo = titulo;
            Ano = ano;
            DiasDeAluguel = diasDeAluguel;
                        ValorAluguel = valorAluguel;
            MultaDiaria = multaDiaria;  
                    }
public void AlugandoTitulo()
        {
            Console.WriteLine("Titulo alugado com sucesso!");
        }
    }
}
