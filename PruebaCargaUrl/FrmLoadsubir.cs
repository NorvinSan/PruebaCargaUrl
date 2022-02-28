using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using CloudinaryDotNet.Core;
using CloudinaryDotNet.Provisioning;


namespace PruebaCargaUrl
{
    public partial class FrmLoadsubir : Form
    {
        String imagen;
        public FrmLoadsubir()
        {
            InitializeComponent();
            cloud = new Cloudinary(A); 
            
        }

        public static Cloudinary cloud;
        Account A = new Account("pandaop", "632968835138977", "GDDZ6eYUYF5_upckyKxZqbpQm8w");

        private void CargarImagen(String ruta) {
            try
            {
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(ruta),
                };

                var uploadResult = cloud.Upload(uploadParams);

                ruta = uploadResult.SecureUri.ToString();
                MessageBox.Show("Foto subida correctamente al servidor cloudinary");

                ptbConfrirm.ImageLocation = @"" + ruta;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        
        
        }
        

        private void btnload_Click(object sender, EventArgs e)
        {
            if (imagen !="")
            {
                CargarImagen(imagen);
            }
            else
            {
                MessageBox.Show("pegate un tiro mejor");
            }
        }
     
        private void ptbLoad_Click(object sender, EventArgs e)
        {
            if (ofdSelectorImagen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ptbLoad.Image = Image.FromFile(ofdSelectorImagen.FileName);
            }

            imagen = ofdSelectorImagen.FileName.ToString();
            imagen = imagen.Replace('\\', '/');
        }
    }
}
