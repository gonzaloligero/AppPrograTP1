using System;
using winform_app;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using dominio;
using manager;

namespace GestorDeArticulos
{
    public partial class frmMostrarImagenes : Form
    {
        private List<Articulo> listaArticulo;
        private SqlConnection conexion;
        public SqlCommand comando;
        private SqlDataReader lector;
        public frmMostrarImagenes()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
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
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagenes.Load(imagen);
            }
            catch (Exception)
            {
                pbxImagenes.Load("https://i.pinimg.com/564x/a5/6e/f6/a56ef61429307a58fbcbb16139d623f6.jpg");

            }
        }

      

        private void frmMostrarImagenes_Load(object sender, EventArgs e)
        {
            ArticuloManager articuloManager = new ArticuloManager();
            listaArticulo = articuloManager.ListarArticulos();
            dgvListaArticulos.DataSource = listaArticulo;
            //dgvListaArticulos.Columns[0].Visible = false;
            dgvListaArticulos.Columns[3].Visible = false;
            dgvListaArticulos.Columns[4].Visible = false;
            dgvListaArticulos.Columns[5].Visible = false;
            dgvListaArticulos.Columns[6].Visible = false;
            dgvListaArticulos.Columns[7].Visible = false;
            cargarImagen(listaArticulo[0].Imagen);

        }

         private void dgvListaArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen);
        }
    }
}
