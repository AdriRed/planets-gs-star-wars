namespace selectDDBB
{
    partial class Frm_ventas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ventas));
            this.dgv_select = new System.Windows.Forms.DataGridView();
            this.btn_showdata = new System.Windows.Forms.Button();
            this.tbx_limitofsales = new System.Windows.Forms.TextBox();
            this.cbx_regions = new System.Windows.Forms.ComboBox();
            this.lbl_limit = new System.Windows.Forms.Label();
            this.lbl_regions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_select)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_select
            // 
            this.dgv_select.AllowUserToAddRows = false;
            this.dgv_select.AllowUserToDeleteRows = false;
            this.dgv_select.AllowUserToResizeColumns = false;
            this.dgv_select.AllowUserToResizeRows = false;
            this.dgv_select.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_select.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_select.BackgroundColor = System.Drawing.Color.Black;
            this.dgv_select.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_select.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_select.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nasalization Rg", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_select.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_select.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nasalization Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_select.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_select.EnableHeadersVisualStyles = false;
            this.dgv_select.GridColor = System.Drawing.Color.Black;
            this.dgv_select.Location = new System.Drawing.Point(12, 97);
            this.dgv_select.MaximumSize = new System.Drawing.Size(1168, 481);
            this.dgv_select.MultiSelect = false;
            this.dgv_select.Name = "dgv_select";
            this.dgv_select.ReadOnly = true;
            this.dgv_select.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_select.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_select.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_select.Size = new System.Drawing.Size(1168, 169);
            this.dgv_select.TabIndex = 0;
            // 
            // btn_showdata
            // 
            this.btn_showdata.BackColor = System.Drawing.Color.Transparent;
            this.btn_showdata.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_showdata.FlatAppearance.BorderSize = 2;
            this.btn_showdata.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_showdata.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_showdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showdata.Font = new System.Drawing.Font("Nasalization Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showdata.ForeColor = System.Drawing.Color.White;
            this.btn_showdata.Location = new System.Drawing.Point(882, 17);
            this.btn_showdata.Name = "btn_showdata";
            this.btn_showdata.Size = new System.Drawing.Size(169, 33);
            this.btn_showdata.TabIndex = 1;
            this.btn_showdata.Text = "Show data";
            this.btn_showdata.UseVisualStyleBackColor = false;
            this.btn_showdata.Click += new System.EventHandler(this.Btn_Showdata_click);
            // 
            // tbx_limitofsales
            // 
            this.tbx_limitofsales.BackColor = System.Drawing.Color.Black;
            this.tbx_limitofsales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_limitofsales.Font = new System.Drawing.Font("Nasalization Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_limitofsales.ForeColor = System.Drawing.Color.White;
            this.tbx_limitofsales.Location = new System.Drawing.Point(716, 20);
            this.tbx_limitofsales.Name = "tbx_limitofsales";
            this.tbx_limitofsales.Size = new System.Drawing.Size(95, 30);
            this.tbx_limitofsales.TabIndex = 2;
            this.tbx_limitofsales.TextChanged += new System.EventHandler(this.tbx_limitofsales_TextChanged);
            // 
            // cbx_regions
            // 
            this.cbx_regions.BackColor = System.Drawing.Color.Black;
            this.cbx_regions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_regions.Font = new System.Drawing.Font("Nasalization Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_regions.ForeColor = System.Drawing.Color.White;
            this.cbx_regions.FormattingEnabled = true;
            this.cbx_regions.Location = new System.Drawing.Point(217, 19);
            this.cbx_regions.Name = "cbx_regions";
            this.cbx_regions.Size = new System.Drawing.Size(286, 31);
            this.cbx_regions.TabIndex = 3;
            this.cbx_regions.Text = "No hi ha regions";
            this.cbx_regions.SelectedIndexChanged += new System.EventHandler(this.cbx_regions_SelectedIndexChanged);
            // 
            // lbl_limit
            // 
            this.lbl_limit.AutoSize = true;
            this.lbl_limit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_limit.Font = new System.Drawing.Font("Nasalization Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_limit.ForeColor = System.Drawing.Color.White;
            this.lbl_limit.Location = new System.Drawing.Point(564, 22);
            this.lbl_limit.Name = "lbl_limit";
            this.lbl_limit.Size = new System.Drawing.Size(146, 23);
            this.lbl_limit.TabIndex = 4;
            this.lbl_limit.Text = "Limit of sales:";
            // 
            // lbl_regions
            // 
            this.lbl_regions.AutoSize = true;
            this.lbl_regions.BackColor = System.Drawing.Color.Transparent;
            this.lbl_regions.Font = new System.Drawing.Font("Nasalization Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regions.ForeColor = System.Drawing.Color.White;
            this.lbl_regions.Location = new System.Drawing.Point(122, 22);
            this.lbl_regions.Name = "lbl_regions";
            this.lbl_regions.Size = new System.Drawing.Size(89, 23);
            this.lbl_regions.TabIndex = 5;
            this.lbl_regions.Text = "Region: ";
            // 
            // Frm_ventas
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1192, 590);
            this.Controls.Add(this.lbl_regions);
            this.Controls.Add(this.lbl_limit);
            this.Controls.Add(this.cbx_regions);
            this.Controls.Add(this.tbx_limitofsales);
            this.Controls.Add(this.btn_showdata);
            this.Controls.Add(this.dgv_select);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1208, 628);
            this.Name = "Frm_ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.TransparencyKey = System.Drawing.Color.Pink;
            this.Load += new System.EventHandler(this.Frm_ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_select)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.BindingSource regionsBindingSource;
        private System.Windows.Forms.DataGridView dgv_select;
        private System.Windows.Forms.Button btn_showdata;
        private System.Windows.Forms.TextBox tbx_limitofsales;
        private System.Windows.Forms.ComboBox cbx_regions;
        private System.Windows.Forms.Label lbl_limit;
        private System.Windows.Forms.Label lbl_regions;
    }
}

