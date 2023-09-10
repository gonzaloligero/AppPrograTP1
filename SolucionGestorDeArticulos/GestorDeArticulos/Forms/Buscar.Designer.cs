namespace GestorDeArticulos.Forms
{
    partial class frmBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscar));
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscarBuscar = new System.Windows.Forms.Button();
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.lbBuscarArticulo = new System.Windows.Forms.Label();
            this.lbCodigoArticulo = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(412, 77);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(76, 20);
            this.txtBuscar.TabIndex = 0;
            // 
            // btnBuscarBuscar
            // 
            this.btnBuscarBuscar.Location = new System.Drawing.Point(412, 147);
            this.btnBuscarBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarBuscar.Name = "btnBuscarBuscar";
            this.btnBuscarBuscar.Size = new System.Drawing.Size(65, 25);
            this.btnBuscarBuscar.TabIndex = 1;
            this.btnBuscarBuscar.Text = "Buscar";
            this.btnBuscarBuscar.UseVisualStyleBackColor = true;
            this.btnBuscarBuscar.Click += new System.EventHandler(this.btnBuscarBuscar_Click);
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.Location = new System.Drawing.Point(224, 187);
            this.dgvBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.RowHeadersWidth = 51;
            this.dgvBuscar.RowTemplate.Height = 24;
            this.dgvBuscar.Size = new System.Drawing.Size(235, 266);
            this.dgvBuscar.TabIndex = 2;
            // 
            // lbBuscarArticulo
            // 
            this.lbBuscarArticulo.AutoSize = true;
            this.lbBuscarArticulo.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscarArticulo.Location = new System.Drawing.Point(302, 21);
            this.lbBuscarArticulo.Name = "lbBuscarArticulo";
            this.lbBuscarArticulo.Size = new System.Drawing.Size(270, 32);
            this.lbBuscarArticulo.TabIndex = 3;
            this.lbBuscarArticulo.Text = "BUSCAR ARTÍCULO";
            // 
            // lbCodigoArticulo
            // 
            this.lbCodigoArticulo.AutoSize = true;
            this.lbCodigoArticulo.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoArticulo.Location = new System.Drawing.Point(239, 78);
            this.lbCodigoArticulo.Name = "lbCodigoArticulo";
            this.lbCodigoArticulo.Size = new System.Drawing.Size(168, 16);
            this.lbCodigoArticulo.TabIndex = 4;
            this.lbCodigoArticulo.Text = "Codigo de artículo: ";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(334, 105);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(64, 16);
            this.lbNombre.TabIndex = 5;
            this.lbNombre.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(412, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(499, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 266);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(731, 472);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(75, 23);
            this.btVolver.TabIndex = 8;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 507);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbCodigoArticulo);
            this.Controls.Add(this.lbBuscarArticulo);
            this.Controls.Add(this.dgvBuscar);
            this.Controls.Add(this.btnBuscarBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBuscar";
            this.Text = "Buscar artículo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscarBuscar;
        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.Label lbBuscarArticulo;
        private System.Windows.Forms.Label lbCodigoArticulo;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btVolver;
    }
}