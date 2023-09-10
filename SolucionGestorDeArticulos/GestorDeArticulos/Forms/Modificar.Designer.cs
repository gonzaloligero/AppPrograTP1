namespace GestorDeArticulos.Forms
{
    partial class frmModificar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificar));
            this.lbModificarArticulo = new System.Windows.Forms.Label();
            this.lbCodigoArticulo = new System.Windows.Forms.Label();
            this.tsNuevoCodigoArticulo = new System.Windows.Forms.TextBox();
            this.dgvModificarArticulo = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbNuevoNombre = new System.Windows.Forms.Label();
            this.lbNuevaDescripcion = new System.Windows.Forms.Label();
            this.lbNuevaMarca = new System.Windows.Forms.Label();
            this.lbNuevaCategoria = new System.Windows.Forms.Label();
            this.lbNuevoPrecio = new System.Windows.Forms.Label();
            this.tsNuevoNombre = new System.Windows.Forms.TextBox();
            this.tsNuevaDescripcion = new System.Windows.Forms.TextBox();
            this.tsNuevoPrecio = new System.Windows.Forms.TextBox();
            this.lbMarcaNueva = new System.Windows.Forms.ListBox();
            this.lbCategoriaNueva = new System.Windows.Forms.ListBox();
            this.btConfirmarModificacion = new System.Windows.Forms.Button();
            this.btCancelarCambios = new System.Windows.Forms.Button();
            this.btSubirImagenNueva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbModificarArticulo
            // 
            this.lbModificarArticulo.AutoSize = true;
            this.lbModificarArticulo.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModificarArticulo.Location = new System.Drawing.Point(186, 20);
            this.lbModificarArticulo.Name = "lbModificarArticulo";
            this.lbModificarArticulo.Size = new System.Drawing.Size(321, 32);
            this.lbModificarArticulo.TabIndex = 0;
            this.lbModificarArticulo.Text = "MODIFICAR ARTÍCULO";
            // 
            // lbCodigoArticulo
            // 
            this.lbCodigoArticulo.AutoSize = true;
            this.lbCodigoArticulo.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoArticulo.Location = new System.Drawing.Point(199, 65);
            this.lbCodigoArticulo.Name = "lbCodigoArticulo";
            this.lbCodigoArticulo.Size = new System.Drawing.Size(168, 16);
            this.lbCodigoArticulo.TabIndex = 5;
            this.lbCodigoArticulo.Text = "Codigo de artículo: ";
            // 
            // tsNuevoCodigoArticulo
            // 
            this.tsNuevoCodigoArticulo.Location = new System.Drawing.Point(364, 63);
            this.tsNuevoCodigoArticulo.Name = "tsNuevoCodigoArticulo";
            this.tsNuevoCodigoArticulo.Size = new System.Drawing.Size(100, 20);
            this.tsNuevoCodigoArticulo.TabIndex = 6;
            // 
            // dgvModificarArticulo
            // 
            this.dgvModificarArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModificarArticulo.Location = new System.Drawing.Point(79, 264);
            this.dgvModificarArticulo.Name = "dgvModificarArticulo";
            this.dgvModificarArticulo.Size = new System.Drawing.Size(197, 159);
            this.dgvModificarArticulo.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(299, 264);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 159);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lbNuevoNombre
            // 
            this.lbNuevoNombre.AutoSize = true;
            this.lbNuevoNombre.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNuevoNombre.Location = new System.Drawing.Point(247, 92);
            this.lbNuevoNombre.Name = "lbNuevoNombre";
            this.lbNuevoNombre.Size = new System.Drawing.Size(112, 16);
            this.lbNuevoNombre.TabIndex = 9;
            this.lbNuevoNombre.Text = "Nuevo nombre:";
            // 
            // lbNuevaDescripcion
            // 
            this.lbNuevaDescripcion.AutoSize = true;
            this.lbNuevaDescripcion.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNuevaDescripcion.Location = new System.Drawing.Point(208, 122);
            this.lbNuevaDescripcion.Name = "lbNuevaDescripcion";
            this.lbNuevaDescripcion.Size = new System.Drawing.Size(152, 16);
            this.lbNuevaDescripcion.TabIndex = 10;
            this.lbNuevaDescripcion.Text = "Nueva descripción:";
            // 
            // lbNuevaMarca
            // 
            this.lbNuevaMarca.AutoSize = true;
            this.lbNuevaMarca.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNuevaMarca.Location = new System.Drawing.Point(257, 155);
            this.lbNuevaMarca.Name = "lbNuevaMarca";
            this.lbNuevaMarca.Size = new System.Drawing.Size(112, 16);
            this.lbNuevaMarca.TabIndex = 11;
            this.lbNuevaMarca.Text = "Nueva marca: ";
            // 
            // lbNuevaCategoria
            // 
            this.lbNuevaCategoria.AutoSize = true;
            this.lbNuevaCategoria.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNuevaCategoria.Location = new System.Drawing.Point(225, 186);
            this.lbNuevaCategoria.Name = "lbNuevaCategoria";
            this.lbNuevaCategoria.Size = new System.Drawing.Size(136, 16);
            this.lbNuevaCategoria.TabIndex = 12;
            this.lbNuevaCategoria.Text = "Nueva categoría:";
            // 
            // lbNuevoPrecio
            // 
            this.lbNuevoPrecio.AutoSize = true;
            this.lbNuevoPrecio.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNuevoPrecio.Location = new System.Drawing.Point(248, 214);
            this.lbNuevoPrecio.Name = "lbNuevoPrecio";
            this.lbNuevoPrecio.Size = new System.Drawing.Size(112, 16);
            this.lbNuevoPrecio.TabIndex = 13;
            this.lbNuevoPrecio.Text = "Nuevo precio:";
            // 
            // tsNuevoNombre
            // 
            this.tsNuevoNombre.Location = new System.Drawing.Point(364, 91);
            this.tsNuevoNombre.Name = "tsNuevoNombre";
            this.tsNuevoNombre.Size = new System.Drawing.Size(100, 20);
            this.tsNuevoNombre.TabIndex = 14;
            // 
            // tsNuevaDescripcion
            // 
            this.tsNuevaDescripcion.Location = new System.Drawing.Point(364, 121);
            this.tsNuevaDescripcion.Name = "tsNuevaDescripcion";
            this.tsNuevaDescripcion.Size = new System.Drawing.Size(100, 20);
            this.tsNuevaDescripcion.TabIndex = 15;
            // 
            // tsNuevoPrecio
            // 
            this.tsNuevoPrecio.Location = new System.Drawing.Point(364, 213);
            this.tsNuevoPrecio.Name = "tsNuevoPrecio";
            this.tsNuevoPrecio.Size = new System.Drawing.Size(100, 20);
            this.tsNuevoPrecio.TabIndex = 16;
            // 
            // lbMarcaNueva
            // 
            this.lbMarcaNueva.FormattingEnabled = true;
            this.lbMarcaNueva.Location = new System.Drawing.Point(364, 155);
            this.lbMarcaNueva.Name = "lbMarcaNueva";
            this.lbMarcaNueva.Size = new System.Drawing.Size(87, 17);
            this.lbMarcaNueva.TabIndex = 17;
            // 
            // lbCategoriaNueva
            // 
            this.lbCategoriaNueva.FormattingEnabled = true;
            this.lbCategoriaNueva.Location = new System.Drawing.Point(364, 185);
            this.lbCategoriaNueva.Name = "lbCategoriaNueva";
            this.lbCategoriaNueva.Size = new System.Drawing.Size(87, 17);
            this.lbCategoriaNueva.TabIndex = 18;
            // 
            // btConfirmarModificacion
            // 
            this.btConfirmarModificacion.Location = new System.Drawing.Point(468, 428);
            this.btConfirmarModificacion.Name = "btConfirmarModificacion";
            this.btConfirmarModificacion.Size = new System.Drawing.Size(117, 23);
            this.btConfirmarModificacion.TabIndex = 19;
            this.btConfirmarModificacion.Text = "Confirmar cambios";
            this.btConfirmarModificacion.UseVisualStyleBackColor = true;
            // 
            // btCancelarCambios
            // 
            this.btCancelarCambios.Location = new System.Drawing.Point(600, 428);
            this.btCancelarCambios.Name = "btCancelarCambios";
            this.btCancelarCambios.Size = new System.Drawing.Size(75, 23);
            this.btCancelarCambios.TabIndex = 20;
            this.btCancelarCambios.Text = "Cancelar";
            this.btCancelarCambios.UseVisualStyleBackColor = true;
            this.btCancelarCambios.Click += new System.EventHandler(this.btCancelarCambios_Click);
            // 
            // btSubirImagenNueva
            // 
            this.btSubirImagenNueva.Location = new System.Drawing.Point(603, 264);
            this.btSubirImagenNueva.Name = "btSubirImagenNueva";
            this.btSubirImagenNueva.Size = new System.Drawing.Size(89, 23);
            this.btSubirImagenNueva.TabIndex = 21;
            this.btSubirImagenNueva.Text = "Subir imagen";
            this.btSubirImagenNueva.UseVisualStyleBackColor = true;
            // 
            // frmModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 463);
            this.Controls.Add(this.btSubirImagenNueva);
            this.Controls.Add(this.btCancelarCambios);
            this.Controls.Add(this.btConfirmarModificacion);
            this.Controls.Add(this.lbCategoriaNueva);
            this.Controls.Add(this.lbMarcaNueva);
            this.Controls.Add(this.tsNuevoPrecio);
            this.Controls.Add(this.tsNuevaDescripcion);
            this.Controls.Add(this.tsNuevoNombre);
            this.Controls.Add(this.lbNuevoPrecio);
            this.Controls.Add(this.lbNuevaCategoria);
            this.Controls.Add(this.lbNuevaMarca);
            this.Controls.Add(this.lbNuevaDescripcion);
            this.Controls.Add(this.lbNuevoNombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvModificarArticulo);
            this.Controls.Add(this.tsNuevoCodigoArticulo);
            this.Controls.Add(this.lbCodigoArticulo);
            this.Controls.Add(this.lbModificarArticulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmModificar";
            this.Text = "Modificar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbModificarArticulo;
        private System.Windows.Forms.Label lbCodigoArticulo;
        private System.Windows.Forms.TextBox tsNuevoCodigoArticulo;
        private System.Windows.Forms.DataGridView dgvModificarArticulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbNuevoNombre;
        private System.Windows.Forms.Label lbNuevaDescripcion;
        private System.Windows.Forms.Label lbNuevaMarca;
        private System.Windows.Forms.Label lbNuevaCategoria;
        private System.Windows.Forms.Label lbNuevoPrecio;
        private System.Windows.Forms.TextBox tsNuevoNombre;
        private System.Windows.Forms.TextBox tsNuevaDescripcion;
        private System.Windows.Forms.TextBox tsNuevoPrecio;
        private System.Windows.Forms.ListBox lbMarcaNueva;
        private System.Windows.Forms.ListBox lbCategoriaNueva;
        private System.Windows.Forms.Button btConfirmarModificacion;
        private System.Windows.Forms.Button btCancelarCambios;
        private System.Windows.Forms.Button btSubirImagenNueva;
    }
}