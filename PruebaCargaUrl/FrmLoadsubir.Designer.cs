namespace PruebaCargaUrl
{
    partial class FrmLoadsubir
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
            this.ptbLoad = new System.Windows.Forms.PictureBox();
            this.ptbConfrirm = new System.Windows.Forms.PictureBox();
            this.btnload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbConfrirm)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbLoad
            // 
            this.ptbLoad.Location = new System.Drawing.Point(12, 12);
            this.ptbLoad.Name = "ptbLoad";
            this.ptbLoad.Size = new System.Drawing.Size(150, 153);
            this.ptbLoad.TabIndex = 0;
            this.ptbLoad.TabStop = false;
            this.ptbLoad.Click += new System.EventHandler(this.ptbLoad_Click);
            // 
            // ptbConfrirm
            // 
            this.ptbConfrirm.Location = new System.Drawing.Point(192, 12);
            this.ptbConfrirm.Name = "ptbConfrirm";
            this.ptbConfrirm.Size = new System.Drawing.Size(150, 153);
            this.ptbConfrirm.TabIndex = 1;
            this.ptbConfrirm.TabStop = false;
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(66, 191);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(75, 23);
            this.btnload.TabIndex = 2;
            this.btnload.Text = "load";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // FrmLoadsubir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 244);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.ptbConfrirm);
            this.Controls.Add(this.ptbLoad);
            this.Name = "FrmLoadsubir";
            this.Text = "FrmLoadsubir";
            ((System.ComponentModel.ISupportInitialize)(this.ptbLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbConfrirm)).EndInit();
            this.ResumeLayout(false);
            this.ofdSelectorImagen = new System.Windows.Forms.OpenFileDialog();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbLoad;
        private System.Windows.Forms.PictureBox ptbConfrirm;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.OpenFileDialog ofdSelectorImagen;
       
    }
}