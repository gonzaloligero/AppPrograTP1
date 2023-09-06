using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeArticulos.Entidades
{
    internal class Categoria
    {
        public Categoria()
        {
            Id = 0;
            Nombre = "";
        }
        public Categoria(int id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }
        public int Id { get; set; }
        public string Nombre { get; set;}

    }
}
