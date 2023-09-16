namespace GestorDeArticulos
{
    partial class frmEliminarMarca
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
            this.dgvEliminarMarca = new System.Windows.Forms.DataGridView();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEliminarMarca
            // 
            this.dgvEliminarMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminarMarca.Location = new System.Drawing.Point(39, 86);
            this.dgvEliminarMarca.Name = "dgvEliminarMarca";
            this.dgvEliminarMarca.ReadOnly = true;
            this.dgvEliminarMarca.RowHeadersWidth = 51;
            this.dgvEliminarMarca.RowTemplate.Height = 24;
            this.dgvEliminarMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEliminarMarca.Size = new System.Drawing.Size(364, 280);
            this.dgvEliminarMarca.TabIndex = 0;
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Location = new System.Drawing.Point(474, 184);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(132, 48);
            this.btnEliminarMarca.TabIndex = 1;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(474, 268);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 41);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmEliminarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.dgvEliminarMarca);
            this.Name = "frmEliminarMarca";
            this.Text = "Eliminar Marca";
            this.Load += new System.EventHandler(this.frmEliminarMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarMarca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEliminarMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnSalir;
    }
}