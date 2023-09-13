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
            manager.ArticuloManager nuevoManager = new manager.ArticuloManager();
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
                    nuevoArticulo.Codigo = "";
                }
               
                nuevoArticulo.Nombre = txtNombreArticulo.Text;
                nuevoArticulo.Descripcion = txtDescripcion.Text;
                
                if(cboCategorias.SelectedValue != null)
                {
                    nuevoArticulo.Categoria.Id = (int)cboCategorias.SelectedValue;
                }

                if(cboMarcas.SelectedValue != null)
                {
                    nuevoArticulo.Marca.Id = (int)cboMarcas.SelectedValue;
                }

                nuevoArticulo.Imagen = (string)txtUrlImagen.Text;
                

                nuevoArticulo.Precio = decimal.Parse(txtPrecio.Text);

                nuevoManager.agregarArticulo(nuevoArticulo);
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
            
        }
    }
}
