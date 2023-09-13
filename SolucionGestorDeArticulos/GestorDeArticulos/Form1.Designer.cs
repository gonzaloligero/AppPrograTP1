namespace winform_app
{
    partial class frmPantallaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPantallaPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbListar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDetallar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbContacto = new System.Windows.Forms.ToolStripButton();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tsmArticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListarArticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBuscarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDetallarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCrearMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListarMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCrearCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListarCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBorrarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmContacto = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregar,
            this.toolStripSeparator1,
            this.tsbListar,
            this.toolStripSeparator2,
            this.tsbBuscar,
            this.toolStripSeparator3,
            this.tsbModificar,
            this.toolStripSeparator4,
            this.tsbDetallar,
            this.toolStripSeparator5,
            this.tsbEliminar,
            this.toolStripSeparator6,
            this.tsbContacto});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(935, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAgregar
            // 
            this.tsbAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAgregar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAgregar.Image")));
            this.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregar.Name = "tsbAgregar";
            this.tsbAgregar.Size = new System.Drawing.Size(24, 24);
            this.tsbAgregar.Text = "Agregar Artículo";
            this.tsbAgregar.Click += new System.EventHandler(this.tsbAgregar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbListar
            // 
            this.tsbListar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbListar.Image = ((System.Drawing.Image)(resources.GetObject("tsbListar.Image")));
            this.tsbListar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbListar.Name = "tsbListar";
            this.tsbListar.Size = new System.Drawing.Size(24, 24);
            this.tsbListar.Text = "Listar Artículos";
            this.tsbListar.Click += new System.EventHandler(this.tsbListar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(24, 24);
            this.tsbBuscar.Text = "Buscar Artículo";
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbModificar
            // 
            this.tsbModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbModificar.Image")));
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(24, 24);
            this.tsbModificar.Text = "Modificar Artículo";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbDetallar
            // 
            this.tsbDetallar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDetallar.Image = ((System.Drawing.Image)(resources.GetObject("tsbDetallar.Image")));
            this.tsbDetallar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDetallar.Name = "tsbDetallar";
            this.tsbDetallar.Size = new System.Drawing.Size(24, 24);
            this.tsbDetallar.Text = "Detallar Artículo";
            this.tsbDetallar.Click += new System.EventHandler(this.tsbDetallar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbContacto
            // 
            this.tsbContacto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbContacto.Image = ((System.Drawing.Image)(resources.GetObject("tsbContacto.Image")));
            this.tsbContacto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbContacto.Name = "tsbContacto";
            this.tsbContacto.Size = new System.Drawing.Size(24, 24);
            this.tsbContacto.Text = "Contacto";
            this.tsbContacto.Click += new System.EventHandler(this.tsbContacto_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmArticulos,
            this.tsmMarcas,
            this.tsmCategorias,
            this.tsmContacto});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(935, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tsmArticulos
            // 
            this.tsmArticulos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAgregarArticulo,
            this.tsmListarArticulos,
            this.tsmBuscarArticulo,
            this.tsmModificarArticulo,
            this.tsmDetallarArticulo,
            this.tsmEliminarArticulo});
            this.tsmArticulos.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmArticulos.Name = "tsmArticulos";
            this.tsmArticulos.Size = new System.Drawing.Size(82, 20);
            this.tsmArticulos.Text = "Artículos";
            // 
            // tsmAgregarArticulo
            // 
            this.tsmAgregarArticulo.Name = "tsmAgregarArticulo";
            this.tsmAgregarArticulo.Size = new System.Drawing.Size(180, 22);
            this.tsmAgregarArticulo.Text = "Agregar";
            this.tsmAgregarArticulo.Click += new System.EventHandler(this.tsmAgregarArticulo_Click);
            // 
            // tsmListarArticulos
            // 
            this.tsmListarArticulos.Name = "tsmListarArticulos";
            this.tsmListarArticulos.Size = new System.Drawing.Size(180, 22);
            this.tsmListarArticulos.Text = "Listar";
            this.tsmListarArticulos.Click += new System.EventHandler(this.tsmListarArticulos_Click);
            // 
            // tsmBuscarArticulo
            // 
            this.tsmBuscarArticulo.Name = "tsmBuscarArticulo";
            this.tsmBuscarArticulo.Size = new System.Drawing.Size(180, 22);
            this.tsmBuscarArticulo.Text = "Buscar";
            this.tsmBuscarArticulo.Click += new System.EventHandler(this.tsmBuscarArticulo_Click);
            // 
            // tsmModificarArticulo
            // 
            this.tsmModificarArticulo.Name = "tsmModificarArticulo";
            this.tsmModificarArticulo.Size = new System.Drawing.Size(180, 22);
            this.tsmModificarArticulo.Text = "Modificar";
            this.tsmModificarArticulo.Click += new System.EventHandler(this.tsmModificarArticulo_Click);
            // 
            // tsmDetallarArticulo
            // 
            this.tsmDetallarArticulo.Name = "tsmDetallarArticulo";
            this.tsmDetallarArticulo.Size = new System.Drawing.Size(180, 22);
            this.tsmDetallarArticulo.Text = "Detallar";
            this.tsmDetallarArticulo.Click += new System.EventHandler(this.tsmDetallarArticulo_Click);
            // 
            // tsmEliminarArticulo
            // 
            this.tsmEliminarArticulo.Name = "tsmEliminarArticulo";
            this.tsmEliminarArticulo.Size = new System.Drawing.Size(180, 22);
            this.tsmEliminarArticulo.Text = "Eliminar";
            this.tsmEliminarArticulo.Click += new System.EventHandler(this.tsmEliminarArticulo_Click);
            // 
            // tsmMarcas
            // 
            this.tsmMarcas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCrearMarca,
            this.tsmListarMarcas,
            this.tsmModificarMarca,
            this.tsmEliminarMarca});
            this.tsmMarcas.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmMarcas.Name = "tsmMarcas";
            this.tsmMarcas.Size = new System.Drawing.Size(61, 20);
            this.tsmMarcas.Text = "Marcas";
            // 
            // tsmCrearMarca
            // 
            this.tsmCrearMarca.Name = "tsmCrearMarca";
            this.tsmCrearMarca.Size = new System.Drawing.Size(214, 22);
            this.tsmCrearMarca.Text = "Crear marca";
            // 
            // tsmListarMarcas
            // 
            this.tsmListarMarcas.Name = "tsmListarMarcas";
            this.tsmListarMarcas.Size = new System.Drawing.Size(214, 22);
            this.tsmListarMarcas.Text = "Listar todas";
            // 
            // tsmModificarMarca
            // 
            this.tsmModificarMarca.Name = "tsmModificarMarca";
            this.tsmModificarMarca.Size = new System.Drawing.Size(214, 22);
            this.tsmModificarMarca.Text = "Modificar una marca";
            // 
            // tsmEliminarMarca
            // 
            this.tsmEliminarMarca.Name = "tsmEliminarMarca";
            this.tsmEliminarMarca.Size = new System.Drawing.Size(214, 22);
            this.tsmEliminarMarca.Text = "Eliminar una marca";
            // 
            // tsmCategorias
            // 
            this.tsmCategorias.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCrearCategoria,
            this.tsmListarCategorias,
            this.tsmModificarCategoria,
            this.tsmBorrarCategoria});
            this.tsmCategorias.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmCategorias.Name = "tsmCategorias";
            this.tsmCategorias.Size = new System.Drawing.Size(89, 20);
            this.tsmCategorias.Text = "Categorías";
            // 
            // tsmCrearCategoria
            // 
            this.tsmCrearCategoria.Name = "tsmCrearCategoria";
            this.tsmCrearCategoria.Size = new System.Drawing.Size(200, 22);
            this.tsmCrearCategoria.Text = "Crear categoría";
            // 
            // tsmListarCategorias
            // 
            this.tsmListarCategorias.Name = "tsmListarCategorias";
            this.tsmListarCategorias.Size = new System.Drawing.Size(200, 22);
            this.tsmListarCategorias.Text = "Listar categorías";
            // 
            // tsmModificarCategoria
            // 
            this.tsmModificarCategoria.Name = "tsmModificarCategoria";
            this.tsmModificarCategoria.Size = new System.Drawing.Size(200, 22);
            this.tsmModificarCategoria.Text = "Modificar";
            // 
            // tsmBorrarCategoria
            // 
            this.tsmBorrarCategoria.Name = "tsmBorrarCategoria";
            this.tsmBorrarCategoria.Size = new System.Drawing.Size(200, 22);
            this.tsmBorrarCategoria.Text = "Borrar categoría";
            // 
            // tsmContacto
            // 
            this.tsmContacto.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmContacto.Name = "tsmContacto";
            this.tsmContacto.Size = new System.Drawing.Size(75, 20);
            this.tsmContacto.Text = "Contacto";
            this.tsmContacto.Click += new System.EventHandler(this.tsmContacto_Click_1);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(24, 24);
            this.tsbEliminar.Text = "Eliminar Artículo";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // frmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 444);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmPantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MG Solutions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAgregar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbListar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbDetallar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbContacto;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsmArticulos;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarArticulo;
        private System.Windows.Forms.ToolStripMenuItem tsmListarArticulos;
        private System.Windows.Forms.ToolStripMenuItem tsmBuscarArticulo;
        private System.Windows.Forms.ToolStripMenuItem tsmModificarArticulo;
        private System.Windows.Forms.ToolStripMenuItem tsmDetallarArticulo;
        private System.Windows.Forms.ToolStripMenuItem tsmMarcas;
        private System.Windows.Forms.ToolStripMenuItem tsmCrearMarca;
        private System.Windows.Forms.ToolStripMenuItem tsmListarMarcas;
        private System.Windows.Forms.ToolStripMenuItem tsmModificarMarca;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminarMarca;
        private System.Windows.Forms.ToolStripMenuItem tsmCategorias;
        private System.Windows.Forms.ToolStripMenuItem tsmCrearCategoria;
        private System.Windows.Forms.ToolStripMenuItem tsmListarCategorias;
        private System.Windows.Forms.ToolStripMenuItem tsmModificarCategoria;
        private System.Windows.Forms.ToolStripMenuItem tsmBorrarCategoria;
        private System.Windows.Forms.ToolStripMenuItem tsmContacto;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminarArticulo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
    }
}

