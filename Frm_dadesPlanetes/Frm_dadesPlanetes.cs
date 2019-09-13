using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Planetes
{
    public partial class Frm_dadesPlanetes : Form
    {
        public Frm_dadesPlanetes()
        {
            InitializeComponent();
            dgv_rutes.Columns.Add("Tipus", "Tipus");
            dgv_rutes.Columns.Add("Nom ruta", "Nom ruta");
            dgv_rutes.Columns.Add("Inici", "Inici");
            dgv_rutes.Columns.Add("Final", "Final");
            dgv_rutes.Columns.Add("Afiliacio", "Afiliacio");
            dgv_rutes.RowsDefaultCellStyle.BackColor = Color.Red;
            dgv_rutes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public String directori;
        public Dictionary<string, Dictionary<string, string>> rutas, planetas;

        private void button1_Click(object sender, EventArgs e)
        {
            SolicitarDirectori();
            if (directori != null)
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(directori))
                {
                    try
                    {
                        rutas = XML.obtenerDadesXML(sr, "hyperspaceRoutes", "Route", "nameRoute");
                        planetas = XML.obtenerDadesXML(sr, "planets", "planet", "name");
                        planetas = Dades.dadesTotalsPlanetes(planetas);
                        sr.Close();
                    }
                    catch (FileNotFoundException exc)
                    {
                        MessageBox.Show("S'ha perdut la conexió amb l'arxiu");
                        Close();
                    }
                    cbx_planetes.Items.Clear();
                    foreach (string val in planetas.Keys)
                    {
                        cbx_planetes.Items.Add(val);
                    }
                }
            }
        }

        private void SolicitarDirectori()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "XML files (*.xml)|*.xml";
            openFileDialog1.Title = "Obre un fitxer XML";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                directori = openFileDialog1.FileName;
            }
        }

        //COMBO BOX
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            //BORRAR ABANS DE TORNAR A CARREGAR
            int i = 0;
            Dictionary<string, string> dadesPlaneta = planetas[cbx_planetes.Text];
            string[][] dadesRuta = Dades.infoRutas(cbx_planetes.Text, planetas, rutas);
            dgv_rutes.Rows.Clear();
            foreach (string[] ruta in dadesRuta)
            {
                dgv_rutes.Rows.Add(ruta);
                if (ruta[5].Equals("1"))
                {
                    dgv_rutes.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dgv_rutes.DefaultCellStyle.SelectionBackColor = Color.Green;
                }
                i++;
            }
            dgv_rutes.ClearSelection();
            dgv_rutes.Refresh();
            dgv_rutes.Visible = true;
            pnl_imagen.Visible = true;
            pnl_info.Visible = true;
            pnl_coordenades.Visible = true;
            Escriure esc1 = new Escriure();
            Escriure esc2 = new Escriure();
            Escriure esc3 = new Escriure();
            Escriure esc4 = new Escriure();
            Escriure esc5 = new Escriure();
            Escriure esc6 = new Escriure();
            Escriure esc7 = new Escriure();
            Escriure esc8 = new Escriure();
            esc8.path = dadesPlaneta["planetImage"];
            esc8.pictbox = pbx_imatge;
            Thread th_imagen = new Thread(new ThreadStart(esc8.canviImatge));
            esc1.misatge = obtenirLletres(dadesPlaneta["sector"]);
            esc1.label = txb_sector;
            Thread th_sector = new Thread(new ThreadStart(esc1.EscriureFuncio));
            esc2.misatge = obtenirLletres(dadesPlaneta["filiation"]);
            esc2.label = txb_nafiliacio;
            Thread th_filiation = new Thread(new ThreadStart(esc2.EscriureFuncio));
            esc3.misatge = obtenirLletres(dadesPlaneta["lat"]);
            esc3.label = txb_latitud;
            Thread th_lat = new Thread(new ThreadStart(esc3.EscriureFuncio));
            esc4.misatge = obtenirLletres(dadesPlaneta["long"]);
            esc4.label = txb_longitud;
            Thread th_long = new Thread(new ThreadStart(esc4.EscriureFuncio));
            esc5.misatge = obtenirLletres(dadesPlaneta["parsecs"]);
            esc5.label = txb_parsecs;
            Thread th_parsecs = new Thread(new ThreadStart(esc5.EscriureFuncio));
            esc6.misatge = obtenirLletres(dadesPlaneta["natives"]);
            esc6.label = txb_nativos;
            Thread th_natives = new Thread(new ThreadStart(esc6.EscriureFuncio));
            esc7.misatge = obtenirLletres(dadesPlaneta["region"]);
            esc7.label = txb_regio;
            Thread th_region = new Thread(new ThreadStart(esc7.EscriureFuncio));
            //COMPROVAR QUE ELS PLANETES NO ESTIGUIN DUPLICATS
            //COMPROVAR QUE LA IMATGE EXISTEIX
            th_imagen.Start();
            th_imagen.Join();
            th_sector.Start();
            th_filiation.Start();
            th_lat.Start();
            th_long.Start();
            th_parsecs.Start();
            th_natives.Start();
            th_region.Start();
            Application.DoEvents();
            th_sector.Join();
            th_filiation.Join();
            th_lat.Join();
            th_long.Join();
            th_parsecs.Join();
            th_natives.Join();
            th_region.Join();
        }

        public static List<char> obtenirLletres(string text)
        {
            List<char> lletres = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                lletres.Add(text[i]);
            }
            return lletres;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}