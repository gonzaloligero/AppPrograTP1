
namespace GestorDeArticulos
{
    partial class frmModificarMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarMarca));
            this.lbModificarMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbModificarMarca
            // 
            this.lbModificarMarca.AutoSize = true;
            this.lbModificarMarca.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModificarMarca.Location = new System.Drawing.Point(92, 36);
            this.lbModificarMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbModificarMarca.Name = "lbModificarMarca";
            this.lbModificarMarca.Size = new System.Drawing.Size(320, 45);
            this.lbModificarMarca.TabIndex = 0;
            this.lbModificarMarca.Text = "MODIFICAR MARCA";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(153, 98);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(132, 22);
            this.txtMarca.TabIndex = 1;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(295, 96);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Confirmar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(141, 132);
            this.dgvMarcas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.ReadOnly = true;
            this.dgvMarcas.RowHeadersWidth = 51;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(312, 172);
            this.dgvMarcas.TabIndex = 3;
            this.dgvMarcas.SelectionChanged += new System.EventHandler(this.dgvMarcas_SelectionChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(295, 311);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmModificarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 369);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvMarcas);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lbModificarMarca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmModificarMarca";
            this.Text = "Modificar Marca";
            this.Load += new System.EventHandler(this.frmModificarMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbModificarMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Button btnVolver;
    }
}