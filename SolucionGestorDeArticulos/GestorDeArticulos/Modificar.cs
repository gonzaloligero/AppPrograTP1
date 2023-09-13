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
    public partial class frmModificar : Form
    {
        private List<Articulo> listaArticulo;

        public frmModificar()
        {
            InitializeComponent();
        }

        private void btCancelarCambios_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            manager.CategoriaManager negocioCat = new manager.CategoriaManager();
            manager.MarcaManager negocio = new manager.MarcaManager();
            cboCategorias.DisplayMember = "Nombre";
            cboCategorias.ValueMember = "Id";
            cboCategorias.DataSource = negocioCat.ListarCategorias();
            cboMarcas.ValueMember = "Id";
            cboMarcas.DisplayMember = "Nombre";
            cboMarcas.DataSource = negocio.ListarMarcas();
            txtCodigoArticulo.Text = seleccionado.Codigo;
            txtNombreArticulo.Text = seleccionado.Nombre;
            txtDescripcion.Text = seleccionado.Descripcion;
            txtPrecio.Text = seleccionado.Precio.ToString();
            cboCategorias.SelectedValue = seleccionado.Categoria.Descripcion;
            cboMarcas.SelectedValue = seleccionado.Marca.Descripcion;
            txtUrlImagen.Text = seleccionado.Imagen;
            cargarImagen(seleccionado.Imagen);
        }

        private void frmModificar_Load(object sender, EventArgs e)
        {
            ArticuloManager articuloManager = new ArticuloManager();
            listaArticulo = articuloManager.ListarArticulos();
            dgvArticulos.DataSource = listaArticulo;
            dgvArticulos.Columns[6].Visible = false;
            cargarImagen(listaArticulo[2].Imagen);
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

        private void btConfirmarModificacion_Click(object sender, EventArgs e)
        {
            ArticuloManager cargar = new ArticuloManager();
            Articulo articuloAModificar = new Articulo();
            articuloAModificar = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAgregar modificar = new frmAgregar(articuloAModificar);


            
        }
    }
}
