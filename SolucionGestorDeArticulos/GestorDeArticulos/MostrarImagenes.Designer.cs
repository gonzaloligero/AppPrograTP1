
namespace GestorDeArticulos
{
    partial class frmMostrarImagenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostrarImagenes));
            this.lbMostrarImágenes = new System.Windows.Forms.Label();
            this.dgvListaArticulos = new System.Windows.Forms.DataGridView();
            this.pbxImagenes = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cboCodigoYNombre = new System.Windows.Forms.ComboBox();
            this.lbCodigoYNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMostrarImágenes
            // 
            this.lbMostrarImágenes.AutoSize = true;
            this.lbMostrarImágenes.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMostrarImágenes.Location = new System.Drawing.Point(269, 24);
            this.lbMostrarImágenes.Name = "lbMostrarImágenes";
            this.lbMostrarImágenes.Size = new System.Drawing.Size(271, 32);
            this.lbMostrarImágenes.TabIndex = 0;
            this.lbMostrarImágenes.Text = "MOSTRAR IMÁGENES";
            // 
            // dgvListaArticulos
            // 
            this.dgvListaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaArticulos.Location = new System.Drawing.Point(21, 121);
            this.dgvListaArticulos.Name = "dgvListaArticulos";
            this.dgvListaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaArticulos.Size = new System.Drawing.Size(344, 268);
            this.dgvListaArticulos.TabIndex = 1;
            this.dgvListaArticulos.SelectionChanged += new System.EventHandler(this.dgvListaArticulos_SelectionChanged);
            // 
            // pbxImagenes
            // 
            this.pbxImagenes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImagenes.Location = new System.Drawing.Point(413, 121);
            this.pbxImagenes.Name = "pbxImagenes";
            this.pbxImagenes.Size = new System.Drawing.Size(350, 268);
            this.pbxImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenes.TabIndex = 2;
            this.pbxImagenes.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(688, 424);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cboCodigoYNombre
            // 
            this.cboCodigoYNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoYNombre.FormattingEnabled = true;
            this.cboCodigoYNombre.Location = new System.Drawing.Point(413, 70);
            this.cboCodigoYNombre.Name = "cboCodigoYNombre";
            this.cboCodigoYNombre.Size = new System.Drawing.Size(121, 21);
            this.cboCodigoYNombre.TabIndex = 6;
            this.cboCodigoYNombre.SelectedIndexChanged += new System.EventHandler(this.cboCodigoYNombre_SelectedIndexChanged);
            // 
            // lbCodigoYNombre
            // 
            this.lbCodigoYNombre.AutoSize = true;
            this.lbCodigoYNombre.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoYNombre.Location = new System.Drawing.Point(239, 72);
            this.lbCodigoYNombre.Name = "lbCodigoYNombre";
            this.lbCodigoYNombre.Size = new System.Drawing.Size(168, 16);
            this.lbCodigoYNombre.TabIndex = 7;
            this.lbCodigoYNombre.Text = "Nombre del artículo:";
            // 
            // frmMostrarImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbCodigoYNombre);
            this.Controls.Add(this.cboCodigoYNombre);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pbxImagenes);
            this.Controls.Add(this.dgvListaArticulos);
            this.Controls.Add(this.lbMostrarImágenes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMostrarImagenes";
            this.Text = "Mostrar Imagenes";
            this.Load += new System.EventHandler(this.frmMostrarImagenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMostrarImágenes;
        private System.Windows.Forms.DataGridView dgvListaArticulos;
        private System.Windows.Forms.PictureBox pbxImagenes;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cboCodigoYNombre;
        private System.Windows.Forms.Label lbCodigoYNombre;
    }
}