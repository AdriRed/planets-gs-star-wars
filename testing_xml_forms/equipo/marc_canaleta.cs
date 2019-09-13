using System;
using System.Windows.Forms;

namespace testing_xml_forms
{
    public partial class marc_canaleta : Form
    {
        public marc_canaleta()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string rutaFoto = "marc_canaleta.jpg";
            pic_foto_face.ImageLocation = Application.StartupPath + "\\fotos_project\\" + rutaFoto;
        }

        private void lbl_url_marc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            obrirLink();
        }

        private void obrirLink()
        {
            lbl_url_marc.LinkVisited = true;

            System.Diagnostics.Process.Start("http://www.instagram.com/marc_canaleta");
        }

        private void pic_foto_face_Click(object sender, EventArgs e)
        {
        }

        private void lbl_instagram_Click(object sender, EventArgs e)
        {
        }

        private void pic_insta_logo_Click(object sender, EventArgs e)
        {
        }
    }
}