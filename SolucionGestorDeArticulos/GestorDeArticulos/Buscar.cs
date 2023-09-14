using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using manager;

namespace winform_app
{
    public partial class frmBuscar : Form
    {
        private List<Articulo> listaArticulo;

        public frmBuscar()
        {
            InitializeComponent();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            try
            {
                ArticuloManager articuloManager = new ArticuloManager();
                MarcaManager marcaManager = new MarcaManager();

                // Carga la lista de artículos desde el gestor
                listaArticulo = articuloManager.ListarArticulos();
                

                // Configura el origen de datos para el DataGridView
                dgvBuscar.DataSource = listaArticulo;

                // Oculta la columna en la posición 6 (suponiendo que la columna a ocultar sea la 7ma)
                dgvBuscar.Columns[6].Visible = false;

                // Obtiene el artículo seleccionado actualmente en el DataGridView
                //Articulo seleccionado = (Articulo)dgvBuscar.CurrentRow?.DataBoundItem;

                // Si se seleccionó un artículo, carga su imagen
                pbxArticulo.Load(listaArticulo[0].Imagen);
                
                //cargarImagen(seleccionado.Imagen);

                // Configura el origen de datos para el ComboBox
                cboCodigo.DisplayMember = "Codigo";
                cboMarca.DataSource = marcaManager.ListarMarcas();
                cboCodigo.DataSource = listaArticulo; // Puedes ajustar esto según tus necesidades
                

            }
            catch (Exception ex)
            {
                // Maneja las excepciones de manera adecuada (registra el error o muestra un mensaje amigable)
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvBuscar_SelectionChanged(object sender, EventArgs e)
        {
            
            Articulo seleccionado = (Articulo)dgvBuscar.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen);

            //cargarImagen(seleccionado.Imagen);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);

            }
            catch (Exception)
            {
                pbxArticulo.Load("https://i.pinimg.com/564x/a5/6e/f6/a56ef61429307a58fbcbb16139d623f6.jpg");

            }
        }

        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            List<Articulo> lista = new List<Articulo>();
            ArticuloManager listaArticulo = new ArticuloManager();

            Articulo articulo = (Articulo)cboCodigo.SelectedItem;

            string codigo = articulo.Codigo;
            lista = listaArticulo.buscarArticulo(codigo);

            dgvBuscar.DataSource = lista;
        }

        private void btnBuscarMarca_Click(object sender, EventArgs e)
        {
            List<Articulo> lista = new List<Articulo>();
            ArticuloManager listaArticulo = new ArticuloManager();

            Marca marca = (Marca)cboMarca.SelectedItem;

            string codigo = marca.Descripcion;
            lista = listaArticulo.buscarMarca(codigo);

            dgvBuscar.DataSource = lista;
        }
    }
}

