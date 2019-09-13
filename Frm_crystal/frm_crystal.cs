using SdSData;
using System;
using System.Data;
using System.Windows.Forms;

namespace Frm_crystal
{
    public partial class frm_crystal : Form
    {
        public string planeta;

        public frm_crystal()
        {
            InitializeComponent();
        }

        private void Frm_crystal_Load(object sender, EventArgs e)
        {
            SdSData.SQL db = new SQL();
            db.Conexion();
            DataTable dt = new DataTable();
            dt = db.PortarPerConsulta("SELECT DISTINCT \"Planets\".\"DescPlanet\", \"Planets\".\"idPlanet\"  FROM   (((\"StarWarsOrders\".\"dbo\".\"OrderDetails\" \"OrderDetails\" INNER JOIN \"StarWarsOrders\".\"dbo\".\"Products\" \"Products\" ON \"OrderDetails\".\"ProductID\"=\"Products\".\"ProductID\") INNER JOIN \"StarWarsOrders\".\"dbo\".\"Orders\" \"Orders\" ON \"OrderDetails\".\"OrderID\"=\"Orders\".\"OrderID\") INNER JOIN \"StarWarsOrders\".\"dbo\".\"Categories\" \"Categories\" ON \"Products\".\"CategoryID\"=\"Categories\".\"CategoryID\") INNER JOIN \"StarWarsOrders\".\"dbo\".\"Planets\" \"Planets\" ON \"Orders\".\"PlanetID\"=\"Planets\".\"idPlanet\" ORDER BY \"Planets\".\"DescPlanet\"");
            cbx_planetes.DataSource = dt;
            cbx_planetes.DisplayMember = "DescPlanet";
            cbx_planetes.ValueMember = "idPlanet";
            Llista1.SetDatabaseLogon("sa", "123456aA!");
        }

        private void cbx_planetes_SelectedIndexChanged(object sender, EventArgs e)
        {
            planeta = cbx_planetes.Text;
            Console.WriteLine(planeta);
        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            Llista Informe_2 = new Llista();
            Informe_2.RecordSelectionFormula = "{Planets.DescPlanet} = \"" + planeta + "\"";
            Informe_2.SetDatabaseLogon("sa", "123456aA!");
            crv_Informe.ReportSource = Informe_2;
            crv_Informe.Refresh();
            Llista1.Refresh();
        }
    }
}