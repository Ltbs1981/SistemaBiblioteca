using System;

namespace SistemaBiblioteca
{
    public class Revista : Biblioteca
    {
        public Revista(string titulo, string ano)
            : base(titulo, ano, 1.0, 1.0, 7)
        {
        }
    }
}
