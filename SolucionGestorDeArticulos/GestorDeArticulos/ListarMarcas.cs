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
    public partial class frmListarMarcas : Form
    {
        private List<Marca> listaMarcas;
        public frmListarMarcas()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmListarMarcas_Load(object sender, EventArgs e)
        {
            MarcaManager adminMarcas = new MarcaManager();
            listaMarcas = adminMarcas.ListarMarcas(); ;
            dgvListarMarcas.DataSource = listaMarcas;
        }
    }
}
