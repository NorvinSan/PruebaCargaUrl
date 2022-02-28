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
    public partial class FrmLoadsubir : Form
    {
        String imagen;
        public FrmLoadsubir()
        {
            InitializeComponent();
        }

        private void btnload_Click(object sender, EventArgs e)
        {

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
