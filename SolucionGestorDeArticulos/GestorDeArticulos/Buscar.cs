//using winform_app.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using manager;

namespace winform_app
{
    public partial class frmBuscar : Form
    {
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void btnBuscarBuscar_Click(object sender, EventArgs e)
        {
            string buscar = (string)cboBuscar.Text;
            ArticuloManager articuloManager = new ArticuloManager();
            dgvBuscar.DataSource = articuloManager.buscarArticulo(buscar);
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void frmBuscar_Load(object sender, EventArgs e)
        { 
            manager.ArticuloManager negocio = new manager.ArticuloManager();
            
            try
            {
               
                ArticuloManager articuloManager = new ArticuloManager();
                cboBuscar.DataSource = negocio.ListarCodigoArticulo();
    

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
