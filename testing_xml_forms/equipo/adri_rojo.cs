using System;
using System.Windows.Forms;

namespace testing_xml_forms
{
    public partial class adri_rojo : Form
    {
        public adri_rojo()
        {
            InitializeComponent();
        }

        private void lbl_url_adri_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbl_url_adri.LinkVisited = true;

            System.Diagnostics.Process.Start("http://www.instagram.com/adrired00");
        }

        private void adri_rojo_Load(object sender, EventArgs e)
        {
            string rutaFoto = "adri_rojo.jpg";
            pic_foto_face.ImageLocation = Application.StartupPath + "\\fotos_project\\" + rutaFoto;
        }
    }
}