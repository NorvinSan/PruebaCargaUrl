namespace PruebaCargaUrl
{
    partial class BtnSubir
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
            this.lblHechoPorNorvin = new System.Windows.Forms.Label();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lblHechoPorNorvin
            // 
            this.lblHechoPorNorvin.AutoSize = true;
            this.lblHechoPorNorvin.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHechoPorNorvin.Location = new System.Drawing.Point(460, 109);
            this.lblHechoPorNorvin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHechoPorNorvin.Name = "lblHechoPorNorvin";
            this.lblHechoPorNorvin.Size = new System.Drawing.Size(216, 36);
            this.lblHechoPorNorvin.TabIndex = 0;
            this.lblHechoPorNorvin.Text = "Elija un opción";
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(147, 314);
            this.btnCargarImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(332, 120);
            this.btnCargarImagen.TabIndex = 1;
            this.btnCargarImagen.Text = "Cargar";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(728, 314);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(363, 138);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Subir";
            // 
            // BtnSubir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 640);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.lblHechoPorNorvin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BtnSubir";
            this.Text = "FrmInicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHechoPorNorvin;
        private System.Windows.Forms.Button btnCargarImagen;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}