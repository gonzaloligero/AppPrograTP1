using GestorDeArticulos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeArticulos.Managers
{
    internal class ArticuloManager
    {
        private List<Articulo> listaArticulos = new List<Articulo>();

        public ArticuloManager(List<Articulo> listaArticulos)
        {
            this.listaArticulos = listaArticulos;
        }

        //Listado de Articulos.
        public List<Articulo> getListaArticulos() { return  listaArticulos; }
        //------------------------------------------------------------------------

        //Busca un articulo por codigo
        public Articulo getArticuloPorCodigo(int codigo)
        {
            return listaArticulos.FirstOrDefault(a => a.CodigoArt ==  codigo);
        }

        //Busca un articulo por nombre
        public Articulo getArticuloPorNombre(string nombre)
        {
            return listaArticulos.FirstOrDefault(n => n.NombreArt ==  nombre);
        }

        //Busca un articulo por descripcion
        public Articulo getArticuloPorDescripcion(string descripcion)
        {
            return listaArticulos.FirstOrDefault(d => d.DescripcionArt ==  descripcion);
        }

        //Busca todos los articulos de la misma marca
        public List<Articulo> getArticulosPorMarca(int idMarca)
        {
            return listaArticulos.Where(m => m.MarcaArt.Id == idMarca).ToList();
        }

        //Busca todos los articulos de la misma Categoria
        public List<Articulo> getArticulosPorCategoria(int idCategoria)
        {
            return listaArticulos.Where(c => c.CategoriaArt.Id == idCategoria).ToList();
        }
        //-------------------------------------------------------------------------------

        //Metodo para agregar un articulo a la lista
        public void AgrergarArticulo(Articulo articulo)
        {
            listaArticulos.Add(articulo);
        }

        //Metodo para modificar un articulo de la lista
        public void ModificarArticulo(Articulo articulo)
        {
            var articuloExistente = listaArticulos.FirstOrDefault(a => a.CodigoArt == articulo.CodigoArt);

            if (articuloExistente != null)
            {
                articuloExistente.NombreArt = articulo.NombreArt;
                articuloExistente.DescripcionArt = articulo.DescripcionArt;
                articuloExistente.MarcaArt = articulo.MarcaArt;
                articuloExistente.CategoriaArt = articulo.CategoriaArt;
                articuloExistente.Imagenes = articulo.Imagenes;
                articuloExistente.Precio = articulo.Precio;
            }
        }

        //Metodo para eliminar un articulo de la lista
        public void EliminarArticulo(int codigo)
        {
            var articuloExistente = listaArticulos.FirstOrDefault(a => a.CodigoArt == codigo);
            if (articuloExistente != null) listaArticulos.Remove(articuloExistente);
            
        }



    }

}
