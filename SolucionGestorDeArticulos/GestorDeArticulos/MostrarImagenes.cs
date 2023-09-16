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


        public frmMostrarImagenes()
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
            {
                pbxImagenes.Load("https://i.pinimg.com/564x/a5/6e/f6/a56ef61429307a58fbcbb16139d623f6.jpg");

            }
        }


        private void frmMostrarImagenes_Load(object sender, EventArgs e)
        {
            ArticuloManager articuloManager = new ArticuloManager();
            List<Imagen> seleccion = new List<Imagen>();
            listaArticulo = articuloManager.ListarArticulos();

            cboArticulos.DisplayMember = "Nombre";
            cboArticulos.ValueMember = "Codigo";
            cboArticulos.DataSource = articuloManager.ListarArticulos().GroupBy(a => a.Codigo).Select(group => group.First()).ToList();

        }

        private void dgvListaArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen);
        }

       
        private void cboArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboArticulos.SelectedItem != null)
            {
                string codigoSeleccionado = cboArticulos.SelectedValue.ToString();

                List<Articulo> articulosFiltrados = listaArticulo.Where(a => a.Codigo == codigoSeleccionado).ToList();

                dgvListaArticulos.DataSource = articulosFiltrados;
                dgvListaArticulos.Columns[3].Visible = false;
                dgvListaArticulos.Columns[4].Visible = false;
                dgvListaArticulos.Columns[5].Visible = false;
                dgvListaArticulos.Columns[6].Visible = false;
                dgvListaArticulos.Columns[7].Visible = false;
            }
        }
    }


}
