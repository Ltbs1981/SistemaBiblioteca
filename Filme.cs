using System;

namespace SistemaBiblioteca
{
    public class Filme : Biblioteca
    {
        public Filme(string titulo, string ano)
            : base(titulo, ano, 5.0, 5.0, 7)
        {
        }
        public override void Alugar()
        {
            base.Alugar();
            Console.WriteLine("Qual o nome do filme");
        }
    }
}
