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
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(35, 143);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 22);
            this.txtBuscar.TabIndex = 0;
            // 
            // btnBuscarBuscar
            // 
            this.btnBuscarBuscar.Location = new System.Drawing.Point(167, 142);
            this.btnBuscarBuscar.Name = "btnBuscarBuscar";
            this.btnBuscarBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarBuscar.TabIndex = 1;
            this.btnBuscarBuscar.Text = "Buscar";
            this.btnBuscarBuscar.UseVisualStyleBackColor = true;
            this.btnBuscarBuscar.Click += new System.EventHandler(this.btnBuscarBuscar_Click);
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.Location = new System.Drawing.Point(35, 199);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.RowHeadersWidth = 51;
            this.dgvBuscar.RowTemplate.Height = 24;
            this.dgvBuscar.Size = new System.Drawing.Size(917, 154);
            this.dgvBuscar.TabIndex = 2;
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 624);
            this.Controls.Add(this.dgvBuscar);
            this.Controls.Add(this.btnBuscarBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBuscar";
            this.Text = "Buscar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscarBuscar;
        private System.Windows.Forms.DataGridView dgvBuscar;
    }
}