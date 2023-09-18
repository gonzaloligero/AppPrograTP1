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
            listaArticulo = articuloManager.listaParaImagenes();
            dgvBuscar.DataSource = listaArticulo;

            dgvBuscar.Columns[0].Visible = false;
            dgvBuscar.Columns[6].Visible = false;

            manager.ArticuloManager negocio = new manager.ArticuloManager();
            Articulo seleccionado = null;
            if (dgvBuscar.CurrentRow != null)
            {
                seleccionado = (Articulo)dgvBuscar.CurrentRow.DataBoundItem;
            }

            if (seleccionado != null)
            {
                cargarImagen(seleccionado.Imagen);
            }

            cboCampo.Items.Add("Codigo");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoria");

            cboCriterio.Items.Add("Comienza con");
            cboCriterio.Items.Add("Termina con");
            cboCriterio.Items.Add("Contiene");

            cboCampo.SelectedIndex = 0;
            cboCriterio.SelectedIndex = 0;

        }




        private void dgvBuscar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBuscar.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvBuscar.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagen);
            }
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloManager manager = new ArticuloManager();

                string campo = (string)cboCampo.SelectedItem;
                string criterio = (string)cboCriterio.SelectedItem;
                string filtro = txtFiltroAvanzado.Text;
                if(campo != "" && criterio != "")
                {
                    dgvBuscar.DataSource = manager.filtrar(campo,criterio,filtro);
                }
                else
                {
                    MessageBox.Show("Existe un parametro sin seleccionar");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltrar.Text.Trim().ToUpper();

            List<Articulo> listaFiltrada;

            if (!string.IsNullOrEmpty(filtro))
            {
                listaFiltrada = listaArticulo.FindAll(a => a.Codigo.ToUpper().Contains(filtro));
            }
            else
            {
                listaFiltrada = listaArticulo;
            }

            dgvBuscar.DataSource = listaFiltrada;

            if (listaFiltrada.Count > 0 && dgvBuscar.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvBuscar.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagen);
            }
            else
            {
                pbxArticulo.Load("https://i.pinimg.com/564x/a5/6e/f6/a56ef61429307a58fbcbb16139d623f6.jpg");
            }
        }






        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();

        }
    }
}

