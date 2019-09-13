using Odisea_en_el_espacio;
using Planetes;
using System;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace testing_xml_forms
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        public SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\salesians\Desktop\planets-g3\STAR WARS _ HIMNO ESPAÑA-128.wav");
        public Thread carrega;

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            playSimpleSound();
            carrega = new Thread(new ThreadStart(carregaPunts));
            Application.DoEvents();
            carrega.Start();
        }

        private void playSimpleSound()
        {
            simpleSound.PlayLooping();
        }

        //////////////////// PESTAÑA DE EQUIPO DES DE AQUI ////////////////
        private void marcCanaleta_select_Click(object sender, EventArgs e)
        {
            marc_canaleta frm = new marc_canaleta();
            frm.MdiParent = this;
            frm.Show();
            pnl_fons.Controls.Add(frm);
            lbl_text_spain.Visible = false;
        }

        private void adriaRojo_select_Click(object sender, EventArgs e)
        {
            adri_rojo frm = new adri_rojo();
            frm.MdiParent = this;
            frm.Show();
            lbl_text_spain.Visible = false;
            pnl_fons.Controls.Add(frm);
        }

        private void albertoMuñoz_select_Click(object sender, EventArgs e)
        {
            alberto_muñoz frm = new alberto_muñoz();
            frm.MdiParent = this;
            frm.Show();
            lbl_text_spain.Visible = false;
            pnl_fons.Controls.Add(frm);
        }

        private void EduMartínez_select_Click(object sender, EventArgs e)
        {
            edu_martinez frm = new edu_martinez();
            frm.MdiParent = this;
            frm.Show();
            lbl_text_spain.Visible = false;
            pnl_fons.Controls.Add(frm);
        }

        //////////////////// FIN DE LA PESTAÑA DE EQUIPO ////////////////////
        //////////////////// PESTAÑA OPCIONES DE PROGRAMA ///////////////////
        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cerrar_program_Click(object sender, EventArgs e)
        {
            if (carrega.IsAlive)
            {
                carrega.Abort();
            }
            Application.Exit();
        }

        private void planetas_open_Click(object sender, EventArgs e)
        {
            Planetes.Frm_dadesPlanetes frm;
            frm = new Planetes.Frm_dadesPlanetes();
            frm.MdiParent = this;
            frm.Show();
            lbl_text_spain.Visible = false;
            pnl_fons.Controls.Add(frm);
        }

        private void regiones_open_Click(object sender, EventArgs e)
        {
            Frm_xmlRegions frm = new Frm_xmlRegions();
            frm.MdiParent = this;
            frm.Show();
            lbl_text_spain.Visible = false;
            pnl_fons.Controls.Add(frm);
        }

        private void ventas_open_Click(object sender, EventArgs e)
        {
            //selectDDBB.Frm_ventas frm = new selectDDBB.Frm_ventas();
            //frm.MdiParent = this;
            //frm.Show();
            //lbl_text_spain.Visible = false;
            //pnl_fons.Controls.Add(frm);
        }

        private void crystalreports_open_Click(object sender, EventArgs e)
        {
            //frm_crystal frm = new Frm_crystal.frm_crystal();
            //frm.MdiParent = this;
            //frm.Show();
            //lbl_text_spain.Visible = false;
            //pnl_fons.Controls.Add(frm);
        }

        /// FUNCIONES PARA MOSTRAR TEXTO EN EL MDI ///
        private void EscriureSpainWars()
        {
            char[] letras;
            letras = new char[] { 'S', 'p', 'a', 'i', 'n', ' ', 'W', 'a', 'r', 's', ' ' };

            foreach (char letra in letras)
            {
                Thread.Sleep(220);
                lbl_text_spain.Text += letra;
                lbl_text_spain.Refresh();
            }
        }

        private void carregaPunts()
        {
            EscriureSpainWars();
            do
            {
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(350);
                    lbl_text_spain.Text += '.';
                    lbl_text_spain.Refresh();
                }
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(350);
                    lbl_text_spain.Text = lbl_text_spain.Text.Substring(0, lbl_text_spain.Text.Length - 1);
                    lbl_text_spain.Refresh();
                }
            } while (lbl_text_spain.Visible == true);
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            simpleSound.PlayLooping();
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            simpleSound.Stop();
        }

        private void opcionesDeProgramaToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            this.opcionesDeProgramaToolStripMenuItem.ForeColor = Color.Black;
        }

        private void opcionesDeProgramaToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            this.opcionesDeProgramaToolStripMenuItem.ForeColor = Color.White;
        }

        private void windowsMenu_DropDownOpened(object sender, EventArgs e)
        {
            this.windowsMenu.ForeColor = Color.Black;
        }

        private void windowsMenu_DropDownClosed(object sender, EventArgs e)
        {
            this.windowsMenu.ForeColor = Color.White;
        }

        private void equipToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            this.equipToolStripMenuItem.ForeColor = Color.White;
        }

        private void equipToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            this.equipToolStripMenuItem.ForeColor = Color.Black;
        }

        private void operacionRescateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nave frm = new Nave();
            frm.MdiParent = this;
            frm.Show();
            lbl_text_spain.Visible = false;
            pnl_fons.Controls.Add(frm);
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            carrega.Abort();
        }
    }
}