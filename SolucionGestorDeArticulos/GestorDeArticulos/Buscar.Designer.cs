namespace winform_app
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
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.lbBuscarArticulo = new System.Windows.Forms.Label();
            this.lbCodigoArticulo = new System.Windows.Forms.Label();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btVolver = new System.Windows.Forms.Button();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBuscar.Location = new System.Drawing.Point(11, 176);
            this.dgvBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBuscar.MultiSelect = false;
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.RowHeadersWidth = 51;
            this.dgvBuscar.RowTemplate.Height = 24;
            this.dgvBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscar.Size = new System.Drawing.Size(404, 320);
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
            this.lbCodigoArticulo.Location = new System.Drawing.Point(188, 92);
            this.lbCodigoArticulo.Name = "lbCodigoArticulo";
            this.lbCodigoArticulo.Size = new System.Drawing.Size(168, 16);
            this.lbCodigoArticulo.TabIndex = 4;
            this.lbCodigoArticulo.Text = "Codigo de artículo: ";
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(443, 177);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(383, 318);
            this.pbxArticulo.TabIndex = 7;
            this.pbxArticulo.TabStop = false;
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(612, 127);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(75, 23);
            this.btVolver.TabIndex = 8;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // cboBuscar
            // 
            this.cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Location = new System.Drawing.Point(345, 91);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(342, 21);
            this.cboBuscar.TabIndex = 9;
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 507);
            this.Controls.Add(this.cboBuscar);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.lbCodigoArticulo);
            this.Controls.Add(this.lbBuscarArticulo);
            this.Controls.Add(this.dgvBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBuscar";
            this.Text = "Buscar artículo";
            this.Load += new System.EventHandler(this.frmBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.Label lbBuscarArticulo;
        private System.Windows.Forms.Label lbCodigoArticulo;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.ComboBox cboBuscar;
    }
}