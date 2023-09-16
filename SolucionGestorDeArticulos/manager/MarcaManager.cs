using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace manager
{
    public class MarcaManager
    {
        private SqlConnection conexion;
        public SqlCommand comando;
        private SqlDataReader lector;

        public MarcaManager()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESSLABO; database=CATALOGO_P3_DB; integrated security=true");
            comando = new SqlCommand();
        }
        public List<Marca> ListarMarcas()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT * FROM MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
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

        public bool verificadorMarcas(string descripcion)
        {
            List<Marca> listaMarcas = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();


            try
            {

                datos.setearConsulta("SELECT COUNT(*) FROM MARCAS WHERE Descripcion = @Descripcion");
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
        public void agregarMarcas(Marca nuevaMarca)
        {
            try
            {
                setearConsulta("INSERT INTO MARCAS (Descripcion) VALUES (@Descripcion)");
                setearParametro("@Descripcion", nuevaMarca.Descripcion);
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

        public void modificarMarca(Marca nuevaMarca)
        {

            try
            {
                setearConsulta("UPDATE MARCAS SET Descripcion = @Descripcion WHERE Id = @Id");
                setearParametro("@Id", nuevaMarca.Id);
                setearParametro("@Descripcion", nuevaMarca.Descripcion);
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
