using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SdSData;

namespace Planetes
{
    public partial class Form3 : Form
    {
        public string planeta;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SdSData.SQL db = new SQL();
            db.Conexion();
            DataTable dt = new DataTable();
            dt = db.PortarPerConsulta("SELECT DescPlanet, idPlanet FROM Planets");
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "DescPlanet";
            comboBox1.ValueMember = "idPlanet";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            planeta = comboBox1.Text;
            Console.WriteLine(planeta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Llista rpt = new Llista();
            rpt.RecordSelectionFormula = "{Planets.DescPlanet} = \"" + planeta + "\"";
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
            //Llista1.RecordSelectionFormula = "{Planets.DescPlanet} = \"" + planeta + "\"";
            Llista1.Refresh();
        }
    }
}