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
           // guna2PictureBox1.ImageLocation = "https://res.cloudinary.com/pandaop/image/upload/v1646088026/gatzbwtgj7ju7e3d1sbh.jpg";
            //Stream variable contenedora para la trasferecia de bytes donde el formato de la misma es astracto
            Stream StreamImagen;
            string elError = "";
            // Se almacena en la varialbe StreamImagen El return del metodo GetUrl del link que se le hace la peticion;
            StreamImagen = getUrl("https://res.cloudinary.com/pandaop/image/upload/v1646088026/gatzbwtgj7ju7e3d1sbh.jpg");
            if (elError == "")
            {
                //al Picturi box se le asigna los datos almacenados en la varibale StreamImagen
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
            
            //URL = "https://res.cloudinary.com/pandaop/image/upload/v1646088026/gatzbwtgj7ju7e3d1sbh.jpg.";
            // string strResp = "https://www.adslzone.net/app/uploads-adslzone.net/2019/04/borrar-fondo-imagen.jpg";

            // HttpWebRequest y HttpWebResponse
            //Son métodos de c# para enviar una petición a un servicio web(HttpWebRequest)
            //y para obtener la respuesta de dicha petición(HttpWebResponse)

            //declaramos un objeto de la tipo HttpWebRequest donde le madaremos una peticion con el link o la informacion que se 
            //desea obtener
            HttpWebRequest request = ((HttpWebRequest)WebRequest.Create(URL));

            ////declaramos un objeto de la tipo HttpWebResponse para tomar la respuesta mas adelante de la peticion ya hecha
            HttpWebResponse response; 
             
            // metodo try para capturar exepciones
            try
            {
                // al objeto response Se le asigna la respuesta de la peticion
                response =((HttpWebResponse)request.GetResponse());
                //se retorna la la peticion .
                return response.GetResponseStream();

            }
            catch(System.Net.WebException)
            {
                // en caso de exepcion se retorna una imagen que se sabe que no dara error. en mi caso
                return getUrl("https://res.cloudinary.com/pandaop/image/upload/v1646080345/cld-sample.jpg");
                //elError = ex.ToString();
            }


          

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}  
