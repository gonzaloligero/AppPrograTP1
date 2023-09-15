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
            Categoria nuevaCategoria = new Categoria();
            CategoriaManager adminCategorias = new CategoriaManager();


            try
            {
                nuevaCategoria.Descripcion = txtNuevaCategoria.Text;
                if(adminCategorias.verificadorCategorias(nuevaCategoria.Descripcion) == true)
                {
                    MessageBox.Show("Ya existe una categoria con esa descripcion");
                }else if (string.IsNullOrEmpty(nuevaCategoria.Descripcion)){
                    MessageBox.Show("No es posible incluir una categoria vacia");
                }
                else
                {
                    
                    adminCategorias.agregarCategoria(nuevaCategoria);
                    MessageBox.Show("Categoria creada con éxito"); 
                }
                    
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
          

        }
    }
}
