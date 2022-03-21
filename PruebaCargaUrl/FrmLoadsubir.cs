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



namespace PruebaCargaUrl
{
    public partial class FrmLoadsubir : Form
    {
        //El stream,es una Transmisión de bytes que en conjunto contienen una imagen
        String imagen;
        public FrmLoadsubir()
        {
            InitializeComponent();
            //En el inicializador se le asigna las credenciales del cervidor.
            cloud = new Cloudinary(A); 
            
        }

        // se crea una valiblae statica de cloudinay
        public static Cloudinary cloud;

        //Se crea una variable Account A que contendra todos las credenciasles de nuestro servidor 
        Account A = new Account("cloudname", "apikey", "apiSecret");

        private void CargarImagen(String ruta) {
            //metodo try para capturar los posibles errores

            try
            {

                //funcion de peticion para suvir una imagen A cloudinai
                var uploadParams = new ImageUploadParams()
                {
                    //se el apsa la ruta de la ubicacion del archivo.
                    File = new FileDescription(ruta)
                };

                

                //Funcion que obtiene resultado del la suvida .
                var uploadResult = cloud.Upload(uploadParams);

                ruta = uploadResult.SecureUri.ToString();
                MessageBox.Show("Foto subida correctamente al servidor cloudinary");

                ptbConfrirm.ImageLocation = @"" + ruta;

                MessageBox.Show(@""+ruta);
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
