using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeArticulos
{
    public partial class frmPantallaPrincipal : Form
    {
        public frmPantallaPrincipal()
        {
            InitializeComponent();
        }

        private void tsmContacto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicación desarrollada por Maximiliano Soria y Gonzalo Ligero");
        }

        private void tsbContacto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicación desarrollada por Maximiliano Soria y Gonzalo Ligero");
        }

        private void tsmAgregar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if(item.GetType() == typeof(frmAgregar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmAgregar ventana = new frmAgregar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            foreach(var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmAgregar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmAgregar ventana = new frmAgregar();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
