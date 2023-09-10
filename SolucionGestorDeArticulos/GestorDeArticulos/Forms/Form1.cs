using GestorDeArticulos.Forms;
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

        private void tsmAlta_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmListar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmListar ventana = new frmListar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsmBuscar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmBuscar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmBuscar ventana = new frmBuscar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsmModificar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmModificar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmModificar ventana = new frmModificar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsmDetallar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmDetallar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmDetallar ventana = new frmDetallar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsmAgregarArticulo_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
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

        private void tsmListarArticulos_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmListar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmListar ventana = new frmListar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsmBuscarArticulo_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmBuscar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmBuscar ventana = new frmBuscar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsmModificarArticulo_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmModificar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmModificar ventana = new frmModificar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsmDetallarArticulo_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmDetallar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmDetallar ventana = new frmDetallar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsmContacto_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicación desarrollada por Maximiliano Soria y Gonzalo Ligero");
        }

        private void tsbListar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmListar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmListar ventana = new frmListar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmBuscar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmBuscar ventana = new frmBuscar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmModificar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmModificar ventana = new frmModificar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsbDetallar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmDetallar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmDetallar ventana = new frmDetallar();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
