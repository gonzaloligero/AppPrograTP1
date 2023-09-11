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
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            dominio.Articulo nuevoArticulo = new dominio.Articulo();
            manager.ArticuloManager nuevoManager = new manager.ArticuloManager();
            try
            {
                nuevoArticulo.Codigo = txtCodigoArticulo.Text;
                nuevoArticulo.Nombre = txtNombreArticulo.Text;
                nuevoArticulo.Descripcion = txtDescripcion.Text;
                nuevoArticulo.Precio = decimal.Parse(txtPrecio.Text);

                nuevoManager.agregarArticulo(nuevoArticulo);
                MessageBox.Show("Artículo agregado exitosamente");
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            manager.ArticuloManager negocio = new manager.ArticuloManager();

            try
            {
                cboCategorias.DataSource = negocio.ListarCategorias();
                cboMarcas.DataSource = negocio.ListarMarcas();
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.ToString());
            }

        }

       
    }
}
