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
            conexion = new SqlConnection("server=.\\SQLEXPRESSLABO; database=CATALOGO_P3_DB; integrated security=true");
            comando = new SqlCommand();
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
        public void agregarImagenes(Articulo articulo)
        {
            
            //articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            try
            {


                
                setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
                setearParametro("@IdArticulo", articulo.Id);
                setearParametro("@ImagenUrl", articulo.Imagen);

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

            cboArticulos.DisplayMember = "Id";
            cboArticulos.ValueMember = "Id";
            cboArticulos.DataSource = articuloManager.ListarArticulos().GroupBy(a => a.Codigo).Select(group => group.First()).ToList();
            

                dgvArticulos.DataSource = articuloManager.ListarArticulos().GroupBy(a => a.Codigo).Select(group => group.First()).ToList();
                dgvArticulos.Columns[3].Visible = false;
                dgvArticulos.Columns[4].Visible = false;
                dgvArticulos.Columns[5].Visible = false;
                dgvArticulos.Columns[6].Visible = false;
                dgvArticulos.Columns[7].Visible = false;

           

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = new Articulo();
            Imagen nuevaImagen = new Imagen();
            ArticuloManager imagenes = new ArticuloManager();

            try
            {
                seleccionado.Imagen = txtUrlImagen.Text;
                seleccionado.Id = int.Parse(cboArticulos.Text);

                
                agregarImagenes(seleccionado);
                MessageBox.Show("Nueva imagen agregada al articulo");
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
