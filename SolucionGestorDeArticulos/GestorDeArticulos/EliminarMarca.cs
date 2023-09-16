using manager;
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

namespace GestorDeArticulos
{
    public partial class frmEliminarMarca : Form
    {
        public frmEliminarMarca()
        {
            InitializeComponent();
        }

        private void frmEliminarMarca_Load(object sender, EventArgs e)
        {
            MarcaManager adminMarcas = new MarcaManager();
            List<Marca> listaMarcas = adminMarcas.ListarMarcas();
            dgvEliminarMarca.DataSource = listaMarcas;
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            Marca seleccionada = (Marca)dgvEliminarMarca.CurrentRow.DataBoundItem;

            ArticuloManager articuloManager = new ArticuloManager();
            MarcaManager marcamanager = new MarcaManager();

            List<Articulo> listaArticulos = articuloManager.ListarArticulos();

            
            bool enUso = listaArticulos.Any(item => item.Marca.Descripcion == seleccionada.Descripcion);

            
            if (!enUso)
            {
                marcamanager.eliminarMarca(seleccionada.Id);
                MessageBox.Show("Marca eliminada correctamente");
            }
            else
            {
                MessageBox.Show("No se puede eliminar una marca en uso");
            }

            List<Marca> listaMarcas = marcamanager.ListarMarcas();
            dgvEliminarMarca.DataSource = listaMarcas;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
