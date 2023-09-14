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
    public partial class frmBuscar : Form
    {
        private List<Articulo> listaArticulo;

        public frmBuscar()
        {
            InitializeComponent();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            
            try
            {
               
                
                ArticuloManager articuloManager = new ArticuloManager();
                MarcaManager marcaManager = new MarcaManager();
                CategoriaManager categoriaManager = new CategoriaManager();
                

                listaArticulo = articuloManager.ListarArticulos();
                
                dgvBuscar.DataSource = listaArticulo;

                dgvBuscar.Columns[6].Visible = false;


                pbxArticulo.Load(listaArticulo[0].Imagen);
                
                cboCodigo.DisplayMember = "Codigo";
                cboMarca.DataSource = marcaManager.ListarMarcas();
                cboCodigo.DataSource = listaArticulo; 
                cboCategoria.DataSource = categoriaManager.ListarCategorias();
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvBuscar_SelectionChanged(object sender, EventArgs e)
        {
            
            Articulo seleccionado = (Articulo)dgvBuscar.CurrentRow.DataBoundItem;
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

        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            List<Articulo> lista = new List<Articulo>();
            ArticuloManager listaArticulo = new ArticuloManager();

            Articulo articulo = (Articulo)cboCodigo.SelectedItem;

            string codigo = articulo.Codigo;
            lista = listaArticulo.buscarArticulo(codigo);

            dgvBuscar.DataSource = lista;
        }

        private void btnBuscarMarca_Click(object sender, EventArgs e)
        {
            List<Articulo> lista = new List<Articulo>();
            ArticuloManager listaArticulo = new ArticuloManager();

            Marca marca = (Marca)cboMarca.SelectedItem;

            string codigo = marca.Descripcion;
            lista = listaArticulo.buscarMarca(codigo);

            dgvBuscar.DataSource = lista;
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            List<Articulo> lista = new List<Articulo>();
            ArticuloManager listaArticulo = new ArticuloManager();

            Categoria categoria = (Categoria)cboCategoria.SelectedItem;

            string codigo = categoria.Descripcion;
            lista = listaArticulo.buscarCategoria(codigo);

            dgvBuscar.DataSource = lista;
        }
    }
}

