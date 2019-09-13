using System;
using System.Windows.Forms;

namespace testing_xml_forms
{
    public partial class alberto_muñoz : Form
    {
        public alberto_muñoz()
        {
            InitializeComponent();
        }

        private void pic_foto_face_Click(object sender, EventArgs e)
        {
        }

        private void lbl_url_alberto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbl_url_alberto.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.instagram.com/alberto_m_d");
        }

        private void alberto_muñoz_Load(object sender, EventArgs e)
        {
            string rutaFoto = "alberto_muñoz.jpg";
            pic_foto_face.ImageLocation = Application.StartupPath + "\\fotos_project\\" + rutaFoto;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void lbl_Nom_Click(object sender, EventArgs e)
        {
        }

        private void lbl_cognom_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void pic_insta_logo_Click(object sender, EventArgs e)
        {
        }

        private void lbl_instagram_Click(object sender, EventArgs e)
        {
        }
    }
}