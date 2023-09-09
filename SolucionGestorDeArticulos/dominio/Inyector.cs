using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GestorDeArticulos;

namespace GestorDatabase
{
    public class Inyector
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader getLector
        {
            get { return lector; }
        }

        public Inyector()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true");
            comando = new SqlCommand();

            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Agregar(string query)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = query;
            comando.Connection = conexion;
            conexion.Open();
            lector = comando.ExecuteReader();
            return;
        }

        public void Buscar(string consulta)
        {
            try
            {
               comando.CommandType = System.Data.CommandType.Text;
               comando.CommandText = consulta;
            }
            catch (Exception ex)
            {

                throw ex;
            } 
        }

        public void Detallar(string consulta)
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    GestorDeArticulos.Entidades.Articulo aux = new GestorDeArticulos.Entidades.Articulo();
                    aux.CodigoArt = (string)lector["Codigo"];
                    aux.NombreArt = (string)lector["Nombre"];
                    aux.DescripcionArt = (string)lector["Descripcion"];
                    aux.MarcaArt.Id = (int)lector["IdMarca"];
                    aux.CategoriaArt.Id = (int)lector["IdCategoria"];
                    aux.Precio = (decimal)lector["Precio"];
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        
        public void Modificar(GestorDeArticulos.Entidades.Articulo obj)
        {
            return;
        }

        public void CerrarConexion()
        {
            if(lector != null)
            {
                lector.Close();
            }
            conexion.Close();
        }

    }
}
