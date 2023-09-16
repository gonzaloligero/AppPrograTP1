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
    public partial class frmAgregarMarca : Form
    {
        private List<Marca> listaMarcas;

        public frmAgregarMarca()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAgregarMarca_Load(object sender, EventArgs e)
        {
            Marca nuevaMarca = new Marca();
            MarcaManager adminMarcas = new MarcaManager();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Marca nuevaMarca = new Marca();
            MarcaManager adminMarcas = new MarcaManager();


            try
            {
                nuevaMarca.Descripcion = txtAgregarMarca.Text;
                if (adminMarcas.verificadorMarcas(nuevaMarca.Descripcion) == true)
                {
                    MessageBox.Show("Ya existe una marca con esa descripcion");
                }
                else if (string.IsNullOrEmpty(nuevaMarca.Descripcion))
                {
                    MessageBox.Show("No es posible incluir una marca vacia");
                }
                else
                {

                    adminMarcas.agregarMarcas(nuevaMarca);
                    MessageBox.Show("Marca creada con éxito");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
