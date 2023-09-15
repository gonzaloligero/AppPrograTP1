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
    public partial class frmModificarCategoria : Form
    {
        private List<Categoria> listaCategorias;
        private Categoria seleccionada;

        public frmModificarCategoria()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmModificarCategoria_Load(object sender, EventArgs e)
        {
            CategoriaManager adminCategorias = new CategoriaManager();
            listaCategorias = adminCategorias.ListarCategorias();
            dgvCategorias.DataSource = listaCategorias;




        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Categoria nuevaCategoria = new Categoria();
            CategoriaManager adminCategorias = new CategoriaManager();
            ArticuloManager listaArticulos = new ArticuloManager();
            string descripcion;

            try
            {
                descripcion = txtModificarCategoria.Text;
                adminCategorias.verificadorCategorias(descripcion);
                if(adminCategorias.verificadorCategorias(descripcion) == true)
                {
                    MessageBox.Show("Ya existe esa categoria");
                }
                else { seleccionada.Descripcion = descripcion;
                    adminCategorias.modificarCategoria(seleccionada);
                    MessageBox.Show("Se actualizó la categoría");
                    listaCategorias = adminCategorias.ListarCategorias();
                    dgvCategorias.DataSource = listaCategorias;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvCategorias_SelectionChanged(object sender, EventArgs e)
        {
            CategoriaManager adminCategorias = new CategoriaManager();
            seleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            txtModificarCategoria.Text = seleccionada.Descripcion;
        }
    }
}
