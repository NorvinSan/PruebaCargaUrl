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
            URL = "https://lh3.googleusercontent.com/e40R8CokfUFCwx_hWTRJNKXSClNQxAi6Ua3eb8PYlrRUmnpmSlPjLBl4Tc0eLa0352H12xfIOV58WCQpOAQPhBAm8vczxG8EPmchkGWNRLTW9xcwmQ_-uJtaq5SXrw990cnh7vC637_HYYFlt4khKURrLfs8ZpB-yf81FduhgsBkzxPgcZ5wEuA2gDCuYkmxgux2ETxaGxupilx9GmGgl84BFppAQzj35lP4yFSd89iVmIupb4AztE5L4EEqmlIlp-69Qgy9oaQKpb1AHK3cBPcTmL9TzWJjkBTgkZxpFCL6juy2WcK6lHVrzhChNbTUXxCl0ZHDmFvKu84b3A80lTWBK2HZDVtElZbLsFHdfAZ0ohOu_6Q1A23UA6D4G6y0E0YWhYC3O-UG45n2COg3L6b_0e1yL4_O28j_svEPXPgTq_-t0GBFzwvT_uMdbHDQitD1H7L0U_lb-tEboSuOcWQwopSWcmaELsfsgbM2IRtL1Eyp7doOo58vgsYcfE5PkpLBTuNmaODt2P8m31VbIxa7JHZ5rqj26q_3aq2sFTIkTBEVoJAeDXB1FUWa4rt5vUyLjVPeIl0MlRi-FgJG779NdWsA9qKzvw4eAmYGtLjGM6IezYcaQaF1QEut0ndk8UzMRpyixtkcqMyu2U0aBJJw03bDAHWg1vrwgT8cRc8Uuk1286VnMwxWlRvbSM4cE50qNQ2-oEh82glHuTMA-gbv=w1295-h969-no?authuser=1";
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
