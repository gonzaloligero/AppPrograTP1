
namespace GestorDeArticulos
{
    partial class frmCrearCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearCategoria));
            this.lbCrearCategoria = new System.Windows.Forms.Label();
            this.lbDescripcionCategoria = new System.Windows.Forms.Label();
            this.txtNuevaCategoria = new System.Windows.Forms.TextBox();
            this.btAgregarCategoría = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCrearCategoria
            // 
            this.lbCrearCategoria.AutoSize = true;
            this.lbCrearCategoria.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrearCategoria.Location = new System.Drawing.Point(106, 24);
            this.lbCrearCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCrearCategoria.Name = "lbCrearCategoria";
            this.lbCrearCategoria.Size = new System.Drawing.Size(320, 45);
            this.lbCrearCategoria.TabIndex = 0;
            this.lbCrearCategoria.Text = "CREAR CATEGORÍA";
            // 
            // lbDescripcionCategoria
            // 
            this.lbDescripcionCategoria.AutoSize = true;
            this.lbDescripcionCategoria.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcionCategoria.Location = new System.Drawing.Point(53, 97);
            this.lbDescripcionCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescripcionCategoria.Name = "lbDescripcionCategoria";
            this.lbDescripcionCategoria.Size = new System.Drawing.Size(140, 22);
            this.lbDescripcionCategoria.TabIndex = 1;
            this.lbDescripcionCategoria.Text = "Descripción: ";
            // 
            // txtNuevaCategoria
            // 
            this.txtNuevaCategoria.Location = new System.Drawing.Point(201, 97);
            this.txtNuevaCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNuevaCategoria.Name = "txtNuevaCategoria";
            this.txtNuevaCategoria.Size = new System.Drawing.Size(144, 22);
            this.txtNuevaCategoria.TabIndex = 2;
            // 
            // btAgregarCategoría
            // 
            this.btAgregarCategoría.Location = new System.Drawing.Point(394, 95);
            this.btAgregarCategoría.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAgregarCategoría.Name = "btAgregarCategoría";
            this.btAgregarCategoría.Size = new System.Drawing.Size(100, 28);
            this.btAgregarCategoría.TabIndex = 4;
            this.btAgregarCategoría.Text = "Crear";
            this.btAgregarCategoría.UseVisualStyleBackColor = true;
            this.btAgregarCategoría.Click += new System.EventHandler(this.btAgregarCategoría_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(394, 176);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmCrearCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 229);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btAgregarCategoría);
            this.Controls.Add(this.txtNuevaCategoria);
            this.Controls.Add(this.lbDescripcionCategoria);
            this.Controls.Add(this.lbCrearCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCrearCategoria";
            this.Text = "Crear Categoria";
            this.Load += new System.EventHandler(this.frmCrearCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCrearCategoria;
        private System.Windows.Forms.Label lbDescripcionCategoria;
        private System.Windows.Forms.TextBox txtNuevaCategoria;
        private System.Windows.Forms.Button btAgregarCategoría;
        private System.Windows.Forms.Button btnVolver;
    }
}