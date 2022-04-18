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
        string public_id;
        public FrmLoadsubir()
        {
            InitializeComponent();
            //En el inicializador se le asigna las credenciales del cervidor.
            cloud = new Cloudinary(A);


        }

        // se crea una valiblae statica de cloudinay
        public static Cloudinary cloud;

        //Se crea una variable Account A que contendra todos las credenciasles de nuestro servidor 
        Account A = new Account("pandaop", "632968835138977", "GDDZ6eYUYF5_upckyKxZqbpQm8w");

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

                public_id = uploadResult.PublicId.ToString();
                MessageBox.Show(public_id);
                MessageBox.Show(ruta);
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
                //MessageBox.Show( img_Delete("https://res.cloudinary.com/pandaop/image/upload/v1646087753/ylwzmagxvgnpop2j9bjp.jpg"));
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
        public String img_Delete(String nombre_img)
        {

            try
            {
                cloud.Api.Timeout = int.MaxValue;
                DeletionParams destroyParams = new DeletionParams(nombre_img)
                {
                    ResourceType = ResourceType.Image
                };

                DeletionResult destroyResult = cloud.Destroy(destroyParams);
                return destroyResult.ToString();
            }
            catch (Exception)
            {

                return "Error";
            }
        }


        private void FrmLoadsubir_Load(object sender, EventArgs e)
        {

        }
    }
}
