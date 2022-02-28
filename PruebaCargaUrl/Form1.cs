using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PruebaCargaUrl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //"https://cdn4.josefacchin.com/wp-content/uploads/2020/02/como-quitar-el-fondo-de-una-imagen.png"
        private void btnCargar_Click(object sender, EventArgs e)
        {
            Stream StreamImagen;
            string elError = "";
            StreamImagen = getUrl("");
            if (elError == "")
            {
                guna2PictureBox1.Image = System.Drawing.Image.FromStream(StreamImagen);
            }
            else
            {
                //MsgBox(elError);
            }

        }
        // do it 
        private static Stream getUrl(string URL)
        {
            URL = "https://lh3.googleusercontent.com/FXciY7Zdy4oxWkwwg9P2zUa07qSnJBmQUGkLMfV3JxEvJHV2P_-yuT_WybRbYhtfva5RUzijTDAgPhU3MHK23mbIVxz6JO1xviXVbylz31HJ0WnG3jRR-UcycJaas31n7OfbMg6-JcuGIRITBQv9VVF2SKaapLQ-eKYfPavWtQC-iklDXvhjXKYLZRthgFQ8oLwkmpn7NE4e92Mnv9K-WQDW30c1yfVDfknWYwpRejPF4ksu6mm7KTRDA6lFciVf4vTcYWpEi5wMrMKdGfbI0619oE-X32cmkn1HF7yF_GHmUNpeFToeK0lQVOtXnKtCsdar1_n-dqnbmIux39NcnZlpE0XwQSC1x353Nm16SjtLlZeC7wYR5M_-MR3qSbmnsxxYufz6Y822TXmiuPAWTfH54QyYvFpC_Z-ncmYxt0wxPsfP7ARiSkI5fmbq7wS5uNwe2PLq2-tu5hOvNFBhfThrA4VBHhOkyPKdL12E3ZBvfdwgJjUjk9-1l8s06lxeTd4TkrvhOgvdwAi7tpkc-RKGWAGcd5tk4wFMUYvkm8xg21dc9631b3TuyEebdVrfUr2nKPu-39uNA2k8kdRYnEDMBydH51DlZI4YZ6JUufGpc16XKFwjACJusotQCM_97au5oWVGxM-0U6Mo4mRZujN-kW9TxXpis1RZtjb8Pxpr8Q1edbH_GwzY1BG7c1Tat5c8h4T8_KuW5geVkhlIp2Cl=w1253-h937-no?authuser=0";

           // string strResp = "https://www.adslzone.net/app/uploads-adslzone.net/2019/04/borrar-fondo-imagen.jpg";
            HttpWebRequest request = ((HttpWebRequest)WebRequest.Create(URL));

            HttpWebResponse response = ((HttpWebResponse)request.GetResponse());

            try
            {

                return response.GetResponseStream();

            }
            catch
            {
                return response.GetResponseStream();
                //elError = ex.ToString();
            }


            /*private static void UploadBasicImage(string path, DriveService service)
            {
                var fileMetadata = new Google.Apis.Drive.v3.Data.File();
                fileMetadata.Name = Path.GetFileName(path);
                fileMetadata.MimeType = "image/jpeg";
                FilesResource.CreateMediaUpload request;
                using (var stream = new System.IO.FileStream(path, System.IO.FileMode.Open))
                {
                    request = service.Files.Create(fileMetadata, stream, "image/jpeg");
                    request.Fields = "id";
                    request.Upload();
                }

                var file = request.ResponseBody;

                Console.WriteLine("File ID: " + file.Id);

            }*/

        }
    }
}  
