using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeArticulos.Entidades
{
    internal class Articulo
    {
        public Articulo()
        {
            CodigoArt = 0;
            NombreArt = "";
            DescripcionArt = "";
            MarcaArt = new Marca();
            CategoriaArt = new Categoria();
            Precio = 0;
        }

        public Articulo(int codigoArt, string nombreArt, string descripcionArt, Marca marcaArt, Categoria categoriaArt, List<string> imagenes, decimal precio)
        {
            CodigoArt = codigoArt;
            NombreArt = nombreArt;
            DescripcionArt = descripcionArt;
            MarcaArt = marcaArt;
            CategoriaArt = categoriaArt;
            Imagenes = imagenes;
            Precio = precio;
        }

        public int CodigoArt { get; set; }
        public string NombreArt { get; set; }
        public string DescripcionArt { get; set; }
        public Marca MarcaArt { get; set; }
        public Categoria CategoriaArt { get; set; }
        public List<string> Imagenes { get; set; }
        public decimal Precio { get; set; }

    }
}
