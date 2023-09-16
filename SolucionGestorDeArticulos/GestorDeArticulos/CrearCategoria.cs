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
    public partial class frmCrearCategoria : Form
    {
        private List<Categoria> listaCategorias;
        public frmCrearCategoria()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCrearCategoria_Load(object sender, EventArgs e)
        {
            CategoriaManager administrador = new CategoriaManager();
            listaCategorias = administrador.ListarCategorias();
        }

        private void btAgregarCategoría_Click(object sender, EventArgs e)
        {
            Categoria nueva = new Categoria();
            CategoriaManager manager = new CategoriaManager();
            List<Categoria> lista = new List<Categoria>();

            lista = manager.ListarCategorias();

            try
            {
                nueva.Descripcion = txtNuevaCategoria.Text;
                if (nueva.Descripcion == "")
                {
                    MessageBox.Show("El campo no puede estar vacio!");
                }
                else
                {
                    if (!lista.Any(c => c.Descripcion.Equals(nueva.Descripcion, StringComparison.OrdinalIgnoreCase)))
                    {
                        manager.agregarCategoria(nueva);
                        MessageBox.Show("Agregada");
                        Close();
                    }
                    else { MessageBox.Show("Esa marca ya existe"); }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            /*



            */
        }

    }
}
