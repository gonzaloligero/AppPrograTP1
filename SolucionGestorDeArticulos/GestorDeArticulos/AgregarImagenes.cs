using System;
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
    public partial class frmAgregarImagenes : Form
    {
        private List<Articulo> listaArticulo;
        private SqlConnection conexion;
        public SqlCommand comando;
        private SqlDataReader lector;

        public frmAgregarImagenes()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagenes.Load(imagen);
            }
            catch (Exception)
            { pbxImagenes.Load("https://i.pinimg.com/564x/a5/6e/f6/a56ef61429307a58fbcbb16139d623f6.jpg"); }
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
        public void agregarImagenes(Articulo nuevoArticulo)
        {
            Articulo articulo = new Articulo();
            articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            try
            {


                int idArticulo = articulo.Id;
                setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
                setearParametro("@IdArticulo", idArticulo);
                setearParametro("@ImagenUrl", nuevoArticulo.Imagen);

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
        

        private void frmAgregarImagenes_Load(object sender, EventArgs e)
        {
            ArticuloManager articuloManager = new ArticuloManager();
            listaArticulo = articuloManager.ListarArticulos();
            var articulosAgrupados = listaArticulo.GroupBy(a => a.Id).Select(g => g.First()).ToList();
            dgvArticulos.DataSource = articulosAgrupados;
 
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new dominio.Articulo();
            Imagen nuevaImagen = new Imagen();
            ArticuloManager imagenes = new ArticuloManager();

            try
            {
                articulo.Imagen = (string)txtUrlImagen.Text;
                imagenes.agregarImagen(articulo);
                MessageBox.Show("Nueva imagen agregada al articulo con codigo " + articulo.Codigo.ToString());
            }
            catch (Exception ex)
            {

                throw ex;
            }

           
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }
    }
}
