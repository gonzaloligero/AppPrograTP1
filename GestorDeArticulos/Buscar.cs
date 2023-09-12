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
            ArticuloManager articuloManager = new ArticuloManager();
            listaArticulo = articuloManager.ListarArticulos();
            dgvBuscar.DataSource = listaArticulo;
            dgvBuscar.Columns[5].Visible = false;
            cargarImagen(listaArticulo[2].Imagen);
            manager.ArticuloManager negocio = new manager.ArticuloManager();
            Articulo seleccionado = (Articulo)dgvBuscar.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen);

            try
            {
                cboBuscar.DisplayMember = "Codigo";
                dgvBuscar.DataSource = negocio.ListarCodigoArticulo();
                cboBuscar.DataSource = negocio.ListarArticulos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void dgvBuscar_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvBuscar.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen);
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
    }
    }

