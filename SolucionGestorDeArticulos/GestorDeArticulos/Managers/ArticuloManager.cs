using GestorDeArticulos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestorDeArticulos.Managers
{
    internal class ArticuloManager
    {
        private List<Articulo> lista = new List<Articulo>();
        private List<Categoria> listaCategorias = new List<Categoria>();
        private List<Marca> listaMarcas = new List<Marca>();
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
       

        public ArticuloManager()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESSLABO; database=CATALOGO_P3_DB; integrated security=true");
            comando = new SqlCommand();
        }


        public List<Articulo> ListarArticulos()
        {
            try
            {
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion AS Marca, C.Descripcion AS Categoria, Precio FROM ARTICULOS A, MARCAS M , CATEGORIAS C WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.CodigoArt = (string)lector["Codigo"];
                    aux.NombreArt = (string)lector["Nombre"];
                    aux.DescripcionArt = (string)lector["Descripcion"];
                    aux.MarcaArt.Descripcion = (string)lector["Marca"];
                    aux.CategoriaArt.Descripcion = (string)lector["Categoria"];
                    aux.Precio = (decimal)lector["Precio"];

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Categoria> ListarCategorias()
        {
            try
            {
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM CATEGORIAS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)lector["Id"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    
                    listaCategorias.Add(aux);
                }

                conexion.Close();
                return listaCategorias;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Marca> ListarMarcas()
        {
            try
            {
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM MARCAS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)lector["Id"];
                    aux.Descripcion = (string)lector["Descripcion"];

                    listaMarcas.Add(aux);
                }

                conexion.Close();
                return listaMarcas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<Articulo> buscarArticulo(string buscar)
        {
            try
            {
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio FROM ARTICULOS WHERE Codigo LIKE @Codigo";
                comando.Parameters.AddWithValue("@Codigo", "%" + buscar + "%");
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                List<Articulo> lista = new List<Articulo>();

                while (lector.Read())
                {
                    string codigoArticulo = (string)lector["Codigo"];

                    // Verifica si el código del artículo contiene la cadena de búsqueda
                    if (codigoArticulo.Contains(buscar))
                    {
                        Articulo aux = new Articulo();
                        aux.CodigoArt = codigoArticulo;
                        aux.NombreArt = (string)lector["Nombre"];
                        aux.DescripcionArt = (string)lector["Descripcion"];
                        aux.MarcaArt.Id = (int)lector["IdMarca"];
                        aux.CategoriaArt.Id = (int)lector["IdCategoria"];
                        aux.Precio = (decimal)lector["Precio"];

                        lista.Add(aux);
                    }
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void setearConsulta(string query)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = query;
        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre,valor);
        }

        public void agregarArticulo(GestorDeArticulos.Entidades.Articulo nuevoArticulo)
        {
           
            try
            {
                setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio) VALUES (@Codigo,@Nombre,@Descripcion,@Precio)");
                //setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES (@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@Precio)");
                setearParametro("@Codigo", nuevoArticulo.CodigoArt);
                setearParametro("@Nombre", nuevoArticulo.NombreArt);
                setearParametro("@Descripcion", nuevoArticulo.DescripcionArt);
                //setearParametro("@IdMarca", nuevoArticulo.MarcaArt);
                //setearParametro("@IdCategoria", nuevoArticulo.CategoriaArt);
                setearParametro("Precio", nuevoArticulo.Precio);
                ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

    }
}


