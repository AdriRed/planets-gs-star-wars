using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Threading;

namespace Planetes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Tipus","Tipus");
            dataGridView1.Columns.Add("Nom ruta","Nom ruta");
            dataGridView1.Columns.Add("Inici","Inici");
            dataGridView1.Columns.Add("Final","Final");
            dataGridView1.Columns.Add("Afiliacio", "Afiliacio");
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Red;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

                    rutas = XML.obtenerDadesXML(sr, "hyperspaceRoutes", "Route", "nameRoute");
                    planetas = XML.obtenerDadesXML(sr, "planets", "planet", "name");
                    planetas = Dades.dadesTotalsPlanetes(planetas);


                    foreach (string val in planetas.Keys)
                    {
                        comboBox1.Items.Add(val);
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
            Dictionary<string, string> dadesPlaneta = planetas[comboBox1.Text];
            string[][] dadesRuta = Dades.infoRutas(comboBox1.Text, planetas, rutas);
            dataGridView1.Rows.Clear();
            foreach (string[] ruta in dadesRuta)
            {
                dataGridView1.Rows.Add(ruta);
                if (ruta[5].Equals("1"))
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Green;
                }
                i++;
            }
            dataGridView1.ClearSelection();
            dataGridView1.Refresh();
            dataGridView1.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            Escriure esc1 = new Escriure();
            Escriure esc2 = new Escriure();
            Escriure esc3 = new Escriure();
            Escriure esc4 = new Escriure();
            Escriure esc5 = new Escriure();
            Escriure esc6 = new Escriure();
            Escriure esc7 = new Escriure();
            Escriure esc8 = new Escriure();
            esc8.path = dadesPlaneta["planetImage"];
            esc8.pictbox = pictureBox1;
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
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Goldenrod, ButtonBorderStyle.Solid);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Goldenrod, ButtonBorderStyle.Solid);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}
