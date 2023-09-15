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
            //UTILIZAR EL ELIMINAR DE MARCAS
        }
    }
}
