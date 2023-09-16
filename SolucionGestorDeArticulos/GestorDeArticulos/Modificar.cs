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
    public partial class frmModificar : Form
    {
        private List<Articulo> listaArticulo;

        public frmModificar()
        {
            InitializeComponent();
        }

        private void btCancelarCambios_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            manager.CategoriaManager negocioCat = new manager.CategoriaManager();
            manager.MarcaManager negocio = new manager.MarcaManager();
            cboCategorias.DisplayMember = "Nombre";
            cboCategorias.ValueMember = "Id";
            cboCategorias.DataSource = negocioCat.ListarCategorias();
            cboMarcas.ValueMember = "Id";
            cboMarcas.DisplayMember = "Nombre";
            cboMarcas.DataSource = negocio.ListarMarcas();
            txtCodigoArticulo.Text = seleccionado.Codigo;
            txtNombreArticulo.Text = seleccionado.Nombre;
            txtDescripcion.Text = seleccionado.Descripcion;
            txtPrecio.Text = seleccionado.Precio.ToString();
            cboCategorias.SelectedValue = seleccionado.Categoria.Descripcion;
            cboMarcas.SelectedValue = seleccionado.Marca.Descripcion;
            txtUrlImagen.Text = seleccionado.Imagen;
            cargarImagen(seleccionado.Imagen);
        }

        private void frmModificar_Load(object sender, EventArgs e)
        {
            manager.CategoriaManager negocioCat = new manager.CategoriaManager();
            manager.MarcaManager negocio = new manager.MarcaManager();
            Articulo seleccionado = new Articulo();
            ArticuloManager articuloManager = new ArticuloManager();
            
            listaArticulo = articuloManager.ListarArticulos();
            dgvArticulos.DataSource = listaArticulo;
            dgvArticulos.Columns[6].Visible = false;
            cboCategorias.ValueMember = "Id";
            cboCategorias.DisplayMember = "Descripcion";
            cboCategorias.DataSource = negocioCat.ListarCategorias();
            cboMarcas.ValueMember = "Id";
            cboMarcas.DisplayMember = "Nombre";
            cboMarcas.DataSource = negocio.ListarMarcas();
            cboCategorias.SelectedValue = seleccionado.Categoria.Id;
            cboMarcas.SelectedValue = seleccionado.Marca.Id;
            cargarImagen(listaArticulo[2].Imagen);
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

        private void btConfirmarModificacion_Click(object sender, EventArgs e)
        {
            ArticuloManager adminArticulos = new ArticuloManager();
            Articulo articuloAModificar = new Articulo();
            articuloAModificar = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            bool letraEnPrecio = false;

            try
            {
                if (adminArticulos.verificadorDeCodigos(articuloAModificar.Codigo) == true && articuloAModificar.Codigo != txtCodigoArticulo.Text)
                {
                    MessageBox.Show("El codigo ya existe. Ingrese otro");
                }
                else
                {
                    articuloAModificar.Codigo = txtCodigoArticulo.Text;
                }

                if (string.IsNullOrEmpty(articuloAModificar.Codigo))
                {
                    articuloAModificar.Codigo = "";
                }

                if (cboCategorias.SelectedValue != null)
                {
                    articuloAModificar.Categoria.Id = (int)cboCategorias.SelectedValue;
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una categoria");
                }

                if (cboMarcas.SelectedValue != null)
                {
                    articuloAModificar.Marca.Id = (int)cboMarcas.SelectedValue;
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una marca");
                }

                if (string.IsNullOrEmpty(txtNombreArticulo.Text))
                {
                    MessageBox.Show("El articulo no contiene nombre");
                }
                else
                {
                    articuloAModificar.Nombre = txtNombreArticulo.Text;
                }

                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    articuloAModificar.Descripcion = "";
                }
                else
                {
                    articuloAModificar.Descripcion = txtDescripcion.Text;
                }
                
                foreach (char caracter in articuloAModificar.Precio.ToString())
                {
                    if (!(char.IsNumber(caracter)) && caracter != '.')
                    {
                        letraEnPrecio = true;
                    }
                }

                if(letraEnPrecio == true)
                {
                    MessageBox.Show("No pueden agregarse letras en el precio. Ingrese sólo números");
                    return;
                }
                else
                {
                    articuloAModificar.Precio = decimal.Parse(txtPrecio.Text);
                }

                //articuloAModificar.Precio = decimal.Parse(txtPrecio.Text);

                articuloAModificar.Imagen = txtUrlImagen.Text;

                adminArticulos.modificarArticulo(articuloAModificar);
                adminArticulos.modificarCategoriaArticulo(articuloAModificar);
                adminArticulos.modificarMarcaArticulo(articuloAModificar);
                adminArticulos.modificarImagenArticulo(articuloAModificar);

               
                
                MessageBox.Show("Articulo modificado correctamente");
                
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }




        }
    }
}
