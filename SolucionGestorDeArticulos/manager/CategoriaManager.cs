using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace manager
{
    public class CategoriaManager
    {
        private SqlConnection conexion;
        public SqlCommand comando;
        private SqlDataReader lector;

        public CategoriaManager()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true");
            comando = new SqlCommand();
        }

        public List<Categoria> ListarCategorias()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT * FROM CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            
        }

        public bool verificadorCategorias(string descripcion)
        {
            List<Categoria> listaCategorias = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();


            try
            {

                datos.setearConsulta("SELECT COUNT(*) FROM CATEGORIAS WHERE Descripcion = @Descripcion");
                datos.comando.Parameters.AddWithValue("@Descripcion", descripcion);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    int count = datos.Lector.GetInt32(0);
                    return count > 0;
                }
                else
                {
                    return false;
                }

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
            comando.Parameters.AddWithValue(nombre, valor);
        }
        public void agregarCategoria(Categoria nuevaCategoria)
        {
            try
            {
                setearConsulta("INSERT INTO CATEGORIAS (Descripcion) VALUES (@Descripcion)");
                setearParametro("@Descripcion", nuevaCategoria.Descripcion);
                conexion.Close();
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

        public void modificarCategoria(Categoria nuevaCategoria)
        {

            try
            {
                setearConsulta("UPDATE CATEGORIAS SET Descripcion = @Descripcion WHERE Id = @Id");
                setearParametro("@Id", nuevaCategoria.Id);
                setearParametro("@Descripcion", nuevaCategoria.Descripcion);
                conexion.Close();
                ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }

          
        }

        public void modificarMarcaArticulo(Categoria nuevaCategoria)
        {

            try
            {
                setearConsulta("UPDATE CATEGORIAS SET Descripcion = @Descripcion WHERE Id = @Id");
                setearParametro("@Id", nuevaCategoria.Id);
                setearParametro("@Descripcion", nuevaCategoria.Descripcion);
                conexion.Close();
                ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

    }
}
