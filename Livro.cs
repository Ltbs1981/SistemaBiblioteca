using System;

namespace SistemaBiblioteca
{
    public class Livro : Biblioteca
    {
        public Livro(string titulo, string ano)
            : base(titulo, ano, 2.0, 2.0, 7)
        {
        }
    }
}
