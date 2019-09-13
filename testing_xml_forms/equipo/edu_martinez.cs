using System;
using System.Windows.Forms;

namespace testing_xml_forms
{
    public partial class edu_martinez : Form
    {
        public edu_martinez()
        {
            InitializeComponent();
        }

        private void lbl_url_edu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbl_url_edu.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.instagram.com/edumarexp99");
        }

        private void pic_foto_face_Click(object sender, EventArgs e)
        {
        }

        private void Edu_martinez_Load(object sender, EventArgs e)
        {
            string rutaFoto = "edu_martinez.jpg";
            pic_foto_face.ImageLocation = Application.StartupPath + "\\fotos_project\\" + rutaFoto;
        }
    }
}