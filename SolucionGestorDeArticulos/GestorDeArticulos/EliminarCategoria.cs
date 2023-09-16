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

namespace GestorDeArticulos
{
    public partial class frmEliminarCategoria : Form
    {
        private List<Categoria> listaCategorias;

        public frmEliminarCategoria()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEliminarCategoria_Load(object sender, EventArgs e)
        {
            CategoriaManager adminCategorias = new CategoriaManager();
            listaCategorias = adminCategorias.ListarCategorias();
            dgvCategorias.DataSource = listaCategorias;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Categoria seleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

            ArticuloManager articuloManager = new ArticuloManager();
            CategoriaManager categoriamanager = new CategoriaManager();

            List<Articulo> listaArticulos = articuloManager.ListarArticulos();

            bool enUso = listaArticulos.Any(item => item.Categoria.Descripcion == seleccionada.Descripcion);

            if (!enUso)
            {
                categoriamanager.eliminarCategoria(seleccionada.Id);
                MessageBox.Show("Categoria eliminada correctamente");
            }
            else
            {
                MessageBox.Show("No se puede eliminar una marca en uso");
            }

            List<Categoria> listaMarcas = categoriamanager.ListarCategorias();
            dgvCategorias.DataSource = listaMarcas;


        }
    }
}
