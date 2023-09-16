
namespace GestorDeArticulos
{
    partial class frmListarMarcas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarMarcas));
            this.lbListarMarcas = new System.Windows.Forms.Label();
            this.dgvListarMarcas = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbListarMarcas
            // 
            this.lbListarMarcas.AutoSize = true;
            this.lbListarMarcas.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListarMarcas.Location = new System.Drawing.Point(124, 33);
            this.lbListarMarcas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbListarMarcas.Name = "lbListarMarcas";
            this.lbListarMarcas.Size = new System.Drawing.Size(280, 45);
            this.lbListarMarcas.TabIndex = 0;
            this.lbListarMarcas.Text = "LISTAR MARCAS";
            // 
            // dgvListarMarcas
            // 
            this.dgvListarMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarMarcas.Location = new System.Drawing.Point(115, 90);
            this.dgvListarMarcas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListarMarcas.Name = "dgvListarMarcas";
            this.dgvListarMarcas.ReadOnly = true;
            this.dgvListarMarcas.RowHeadersWidth = 51;
            this.dgvListarMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarMarcas.Size = new System.Drawing.Size(359, 185);
            this.dgvListarMarcas.TabIndex = 1;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(225, 299);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmListarMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 374);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvListarMarcas);
            this.Controls.Add(this.lbListarMarcas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListarMarcas";
            this.Text = "Listar Marcas";
            this.Load += new System.EventHandler(this.frmListarMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbListarMarcas;
        private System.Windows.Forms.DataGridView dgvListarMarcas;
        private System.Windows.Forms.Button btnVolver;
    }
}