using winform_app;
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
using dominio;
using manager;

namespace winform_app
{
    public partial class frmListar : Form
    {
        private List<Articulo> listaArticulo;

        public frmListar()
        {
            InitializeComponent();
        }

        private void frmListar_Load(object sender, EventArgs e)
        {
            ArticuloManager articuloManager = new ArticuloManager();
            listaArticulo = articuloManager.listaParaImagenes();
            dgvArticulos.DataSource = articuloManager.listaParaImagenes().GroupBy(a => a.Codigo).Select(group => group.First()).ToList();
            dgvArticulos.Columns[6].Visible = false;
            cargarImagen(listaArticulo[0].Imagen);
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            int cant = seleccionado.Imagenes.Count();
           // MessageBox.Show(cant.ToString());
            cargarImagen(seleccionado.Imagen);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://i.pinimg.com/564x/a5/6e/f6/a56ef61429307a58fbcbb16139d623f6.jpg");

            }
        }

        private int indiceImagenActual = 0;

        private void btnImagenSiguiente_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            int totalImagenes = seleccionado.Imagenes.Count;

            if (totalImagenes > 0)
            {
                indiceImagenActual++;

                if (indiceImagenActual >= totalImagenes)
                {
                    indiceImagenActual = 0;
                }

                cargarImagen(seleccionado.Imagenes[indiceImagenActual]);
            }
            else
            {
                MessageBox.Show("No hay imágenes disponibles para este artículo.");
            }
        }

        private void btnImagenAnterior_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            int totalImagenes = seleccionado.Imagenes.Count;

            
            if (totalImagenes > 0)
            {
                
                indiceImagenActual--;

                
                if (indiceImagenActual < 0)
                {
                    indiceImagenActual = totalImagenes - 1; 
                }

                
                cargarImagen(seleccionado.Imagenes[indiceImagenActual]);
            }
            else
            {
         
                MessageBox.Show("No hay imágenes disponibles para este artículo.");
            }
        }
    }
}
