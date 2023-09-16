
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
            this.lbListarMarcas.Location = new System.Drawing.Point(93, 27);
            this.lbListarMarcas.Name = "lbListarMarcas";
            this.lbListarMarcas.Size = new System.Drawing.Size(223, 32);
            this.lbListarMarcas.TabIndex = 0;
            this.lbListarMarcas.Text = "LISTAR MARCAS";
            // 
            // dgvListarMarcas
            // 
            this.dgvListarMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarMarcas.Location = new System.Drawing.Point(86, 73);
            this.dgvListarMarcas.Name = "dgvListarMarcas";
            this.dgvListarMarcas.Size = new System.Drawing.Size(240, 150);
            this.dgvListarMarcas.TabIndex = 1;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(169, 243);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmListarMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 304);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvListarMarcas);
            this.Controls.Add(this.lbListarMarcas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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