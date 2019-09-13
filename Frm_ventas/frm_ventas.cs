using SdSData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace selectDDBB
{
    public partial class Frm_ventas : Form
    {
        public List<string> noms;
        private SQL db;

        public Frm_ventas()
        {
            InitializeComponent();
        }

        private void Btn_Showdata_click(object sender, EventArgs e)
        {
            int val;
            string query = "SELECT        Categories.CategoryName, Planets.DescPlanet, sum(OrderDetails.quantity) as total FROM            Orders INNER JOIN OrderDetails ON Orders.OrderID = OrderDetails.OrderID INNER JOIN Planets ON Orders.PlanetID = Planets.idPlanet INNER JOIN Products ON OrderDetails.ProductID = Products.ProductID INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID INNER JOIN Sectors ON Planets.idSector = Sectors.idSector INNER JOIN Regions ON Sectors.idRegion = Regions.idRegion WHERE Regions.idRegion = " + cbx_regions.SelectedValue + " GROUP BY Categories.CategoryName, Planets.DescPlanet HAVING sum(OrderDetails.quantity) > " + tbx_limitofsales.Text;
            if (tbx_limitofsales.Text.Length > 0 && int.TryParse(tbx_limitofsales.Text, out val))
            {
                DataTable dt = db.PortarPerConsulta(query);
                dgv_select.DataSource = dt;
                dgv_select.MinimumSize = dgv_select.Size;
                dgv_select.Size = dgv_select.PreferredSize;
            }
        }

        private void Frm_ventas_Load(object sender, EventArgs e)
        {
            db = new SQL();
            db.Conexion();

            DataTable dt = db.PortarPerConsulta("SELECT descRegion, idRegion FROM regions ");

            cbx_regions.DataSource = dt;
            cbx_regions.DisplayMember = "descRegion";
            cbx_regions.ValueMember = "idRegion";

            dgv_select.RowHeadersVisible = false;
        }

        private void cbx_regions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_regions.Text != "No hi ha regions" && tbx_limitofsales.Text != null)
            {
                btn_showdata.Visible = true;
            }
            else
            {
                btn_showdata.Visible = false;
            }
        }

        private void tbx_limitofsales_TextChanged(object sender, EventArgs e)
        {
            if (cbx_regions.Text != "No hi ha regions" && tbx_limitofsales.Text != null)
            {
                btn_showdata.Visible = true;
            }
            else
            {
                btn_showdata.Visible = false;
            }
        }
    }
}