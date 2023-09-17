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
    public partial class frmAgregar : Form
    {
        private Articulo articulo = null;

        public frmAgregar()
        {
            InitializeComponent();
        }
        public frmAgregar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            dominio.Articulo nuevoArticulo = new dominio.Articulo();
            Imagen nuevaImagen = new Imagen();
            manager.ArticuloManager nuevoManager = new manager.ArticuloManager();
            ArticuloManager imagenes = new ArticuloManager();
            try
            {
                if(nuevoManager.verificadorDeCodigos(nuevoArticulo.Codigo) == true)
                {
                    MessageBox.Show("El codigo ya existe. Ingrese otro");
                }
                else
                {
                    nuevoArticulo.Codigo = txtCodigoArticulo.Text;
                }

                if (string.IsNullOrEmpty(nuevoArticulo.Codigo))
                {
                    MessageBox.Show("El campo de código no puede quedar vacío. Ingrese uno por favor");
                    return;
                }
               
                nuevoArticulo.Nombre = txtNombreArticulo.Text;
                nuevoArticulo.Descripcion = txtDescripcion.Text;

                if (string.IsNullOrEmpty(nuevoArticulo.Nombre))
                {
                    MessageBox.Show("No se ha ingresado un nombre al artículo");
                    return;
                }

                if (cboCategorias.SelectedValue != null)
                {
                    nuevoArticulo.Categoria.Id = (int)cboCategorias.SelectedValue;
                }

                if(cboMarcas.SelectedValue != null)
                {
                    nuevoArticulo.Marca.Id = (int)cboMarcas.SelectedValue;
                }

                nuevoArticulo.Imagen = (string)txtUrlImagen.Text;

                decimal verificadorNumero;
                
                if(decimal.TryParse((txtPrecio.Text),out verificadorNumero)){
                    nuevoArticulo.Precio = decimal.Parse(txtPrecio.Text);
                }
                else
                {
                    MessageBox.Show("Ingresar sólo números en el precio por favor");
                    return;
                }

                nuevoManager.agregarArticulo(nuevoArticulo);
                imagenes.agregarImagen(nuevoArticulo);
                MessageBox.Show("Artículo agregado exitosamente");
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            manager.CategoriaManager negocioCat = new manager.CategoriaManager();
            manager.MarcaManager negocio = new manager.MarcaManager();

            try
            {
        
                cboCategorias.DisplayMember = "Nombre";
                cboCategorias.ValueMember = "Id";
                cboCategorias.DataSource = negocioCat.ListarCategorias();
                cboMarcas.ValueMember = "Id";
                cboMarcas.DisplayMember = "Nombre";
                cboMarcas.DataSource = negocio.ListarMarcas();

                if(articulo != null)
                {
                    txtNombreArticulo.Text = articulo.Nombre;
                    txtCodigoArticulo.Text = articulo.Codigo;
                    txtUrlImagen.Text = articulo.Imagen;
                    txtPrecio.Text = articulo.Precio.ToString();
                   
                }
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }

       private void cargarImagen(string imagen)
          {
             try
              {
                 pbxArticulo.Load(imagen);}
                 catch (Exception)
              { pbxArticulo.Load("https://i.pinimg.com/564x/a5/6e/f6/a56ef61429307a58fbcbb16139d623f6.jpg");}
                        }

        private void txtCodigoArticulo_Leave(object sender, EventArgs e)
        {
            ArticuloManager verificador = new ArticuloManager();
            if(verificador.verificadorDeCodigos(txtCodigoArticulo.Text) == true)
            {
                MessageBox.Show("Codigo existente. Ingrese otro");
                txtCodigoArticulo.Clear();
            }

            if (string.IsNullOrEmpty(txtCodigoArticulo.Text))
            {
                MessageBox.Show("El campo de código no puede quedar vacío. Ingrese uno por favor");
                
            }

          
        }

        private void txtNombreArticulo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreArticulo.Text))
            {
                MessageBox.Show("No se ha ingresado un nombre al artículo");
                return;
            }
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            decimal verificadorNumero;

            if ((!decimal.TryParse((txtPrecio.Text), out verificadorNumero))){
                MessageBox.Show("Ingresar sólo números en el precio por favor");
                return;
            }
           
        }
    }
}
