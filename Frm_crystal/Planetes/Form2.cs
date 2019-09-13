using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planetes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public String directori;
        public String path;
        public Dictionary<string, Dictionary<string, string>> regions, planetas;
        private string SolicitarDirectori()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "XML files (*.xml)|*.xml";
            openFileDialog1.Title = "Obre un fitxer XML";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                directori = openFileDialog1.FileName;
            }
            return directori;
        }
        public void Form2_Load(object sender, EventArgs e)
        {
            directori = SolicitarDirectori();
            if (directori != null)
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(directori))
                {

                    regions = XML.obtenerDadesXML(sr, "regions", "Region", "nameRegion");
                    planetas = XML.obtenerDadesXML(sr, "planets", "planet", "name");
                    planetas = Dades.dadesTotalsPlanetes(planetas);


                    foreach (string val in regions.Keys)
                    {
                        comboBox1.Items.Add(val);
                    }
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = regions[comboBox1.Text]["descriptionRegion"];
            richTextBox1.Size = richTextBox1.PreferredSize;
            rectangleShape2.Size = richTextBox1.PreferredSize;
            rectangleShape2.Width = (rectangleShape2.Width + 4);
            rectangleShape2.Height = (rectangleShape2.Height + 4);
            button1.Enabled = true;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string xml = Dades.dadesXMLPlanetesRegio(comboBox1.Text, regions, planetas);
            string path = @"E:\\Planetes\\" + comboBox1.Text + ".xml";
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(path, false))
            {
                sw.WriteLine(xml);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            path = SolicitarDirectori();
            using (System.IO.StreamReader sr = new System.IO.StreamReader(path, false))
            {
                richTextBox2.Text = sr.ReadToEnd();
            }
        }

    }
}
