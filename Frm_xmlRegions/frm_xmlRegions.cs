using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Planetes
{
    public partial class Frm_xmlRegions : Form
    {
        public string directori, path;
        public Boolean tancar = false;
        public Dictionary<string, Dictionary<string, string>> regions, planetas;

        public Frm_xmlRegions()
        {
            InitializeComponent();
        }

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

        public void frm_xmlRegions_Load(object sender, EventArgs e)
        {
            directori = SolicitarDirectori();
            if (directori != null)
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(directori))
                {
                    try
                    {
                        OmplirDiccionaris(sr);
                        AfegirItemsCbx(regions.Keys);
                        sr.Close();
                    }
                    catch (System.IO.FileNotFoundException exc)
                    {
                        MessageBox.Show("S'ha perdut la conexió amb l'arxiu");
                        tancar = true;
                    }
                }
            }
            else
            {
                tancar = true;
            }
        }

        private void AfegirItemsCbx(Dictionary<string, Dictionary<string, string>>.KeyCollection keys)
        {
            foreach (string val in keys)
            {
                cbx_regions.Items.Add(val);
            }
        }

        private void OmplirDiccionaris(System.IO.StreamReader sr)
        {
            regions = XML.obtenerDadesXML(sr, "regions", "Region", "nameRegion");
            planetas = XML.obtenerDadesXML(sr, "planets", "planet", "name");
            planetas = Dades.dadesTotalsPlanetes(planetas);
        }

        private void cbx_regions_SelectedValueChanged(object sender, EventArgs e)
        {
            rtb_desc.Text = regions[cbx_regions.Text]["descriptionRegion"];
            rtb_desc.Size = rtb_desc.PreferredSize;
            rsh_descripcio.Size = rtb_desc.Size;
            rsh_descripcio.Width = rsh_descripcio.Width + 4;
            rsh_descripcio.Height = rsh_descripcio.Height + 4;
            btn_guardarXML.Enabled = true;
        }

        public void btn_guardarXML_Click(object sender, EventArgs e)
        {
            string xml = Dades.dadesXMLPlanetesRegio(cbx_regions.Text, regions, planetas);

            path = Application.StartupPath + "\\XMLRegions\\" + cbx_regions.Text + ".xml";
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(path, false))
            {
                sw.WriteLine(xml);
            }
        }

        private void btn_carregarXML_Click(object sender, EventArgs e)
        {
            path = SolicitarDirectori();
            using (System.IO.StreamReader sr = new System.IO.StreamReader(path, false))
            {
                rtb_xml.Text = sr.ReadToEnd();
            }
        }

        private void Frm_xmlRegions_VisibleChanged(object sender, EventArgs e)
        {
            if (tancar)
            {
                Close();
            }
        }
    }
}