
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
            this.lbCrearCategoria.Location = new System.Drawing.Point(100, 106);
            this.lbCrearCategoria.Name = "lbCrearCategoria";
            this.lbCrearCategoria.Size = new System.Drawing.Size(255, 32);
            this.lbCrearCategoria.TabIndex = 0;
            this.lbCrearCategoria.Text = "CREAR CATEGORÍA";
            // 
            // lbDescripcionCategoria
            // 
            this.lbDescripcionCategoria.AutoSize = true;
            this.lbDescripcionCategoria.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcionCategoria.Location = new System.Drawing.Point(54, 152);
            this.lbDescripcionCategoria.Name = "lbDescripcionCategoria";
            this.lbDescripcionCategoria.Size = new System.Drawing.Size(112, 16);
            this.lbDescripcionCategoria.TabIndex = 1;
            this.lbDescripcionCategoria.Text = "Descripción: ";
            // 
            // txtNuevaCategoria
            // 
            this.txtNuevaCategoria.Location = new System.Drawing.Point(154, 150);
            this.txtNuevaCategoria.Name = "txtNuevaCategoria";
            this.txtNuevaCategoria.Size = new System.Drawing.Size(109, 20);
            this.txtNuevaCategoria.TabIndex = 2;
            // 
            // btAgregarCategoría
            // 
            this.btAgregarCategoría.Location = new System.Drawing.Point(280, 148);
            this.btAgregarCategoría.Name = "btAgregarCategoría";
            this.btAgregarCategoría.Size = new System.Drawing.Size(75, 23);
            this.btAgregarCategoría.TabIndex = 4;
            this.btAgregarCategoría.Text = "Crear";
            this.btAgregarCategoría.UseVisualStyleBackColor = true;
            this.btAgregarCategoría.Click += new System.EventHandler(this.btAgregarCategoría_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(280, 310);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmCrearCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 345);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btAgregarCategoría);
            this.Controls.Add(this.txtNuevaCategoria);
            this.Controls.Add(this.lbDescripcionCategoria);
            this.Controls.Add(this.lbCrearCategoria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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