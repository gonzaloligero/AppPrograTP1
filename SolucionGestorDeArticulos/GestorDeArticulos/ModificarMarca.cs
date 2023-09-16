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
    public partial class frmModificarMarca : Form
    {
        private List<Marca> listaMarcas;
        private Marca seleccionada;
        public frmModificarMarca()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmModificarMarca_Load(object sender, EventArgs e)
        {
            MarcaManager adminMarcas = new MarcaManager();
            listaMarcas = adminMarcas.ListarMarcas();
            dgvMarcas.DataSource = listaMarcas;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Marca nuevaMarca = new Marca();
            MarcaManager adminMarcas = new MarcaManager();
            ArticuloManager listaArticulos = new ArticuloManager();
            string descripcion;

            try
            {
                descripcion = txtMarca.Text;
                adminMarcas.verificadorMarcas(descripcion);
                if (adminMarcas.verificadorMarcas(descripcion) == true)
                {
                    MessageBox.Show("Ya existe esa marca");
                }
                else
                {
                    seleccionada.Descripcion = descripcion;
                    adminMarcas.modificarMarca(seleccionada);
                    MessageBox.Show("Se actualizó la marca");
                    listaMarcas = adminMarcas.ListarMarcas();
                    dgvMarcas.DataSource = listaMarcas;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

  

        private void dgvMarcas_SelectionChanged(object sender, EventArgs e)
        {
            MarcaManager adminMarcas = new MarcaManager();
            seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            txtMarca.Text = seleccionada.Descripcion;
        }
    }
}
