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
    public partial class frmListarCategorias : Form
    {
        private List<Categoria> listaCategorias;

        public frmListarCategorias()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmListarCategorias_Load(object sender, EventArgs e)
        {
            CategoriaManager adminCategorias = new CategoriaManager();
            listaCategorias = adminCategorias.ListarCategorias();
            dgvCategorias.DataSource = listaCategorias;
 
        }
    }
}
