using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaCargaUrl
{
    public partial class BtnSubir : Form
    {
        public BtnSubir()
        {
            InitializeComponent();
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
             
            Form1  Norvin= new Form1();
            Norvin.ShowDialog();    

            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmLoadsubir Norvin = new FrmLoadsubir();
            Norvin.ShowDialog();

            this.Close();
        }
    }
}
