namespace Planetes
{
    partial class Frm_xmlRegions
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_xmlRegions));
            this.cbx_regions = new System.Windows.Forms.ComboBox();
            this.btn_guardarXML = new System.Windows.Forms.Button();
            this.rtb_desc = new System.Windows.Forms.RichTextBox();
            this.btn_carregarXML = new System.Windows.Forms.Button();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.rtb_xml = new System.Windows.Forms.RichTextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rsh = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rsh_descripcio = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.SuspendLayout();
            // 
            // cbx_regions
            // 
            this.cbx_regions.BackColor = System.Drawing.Color.Black;
            this.cbx_regions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_regions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_regions.Font = new System.Drawing.Font("Nasalization Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_regions.ForeColor = System.Drawing.Color.White;
            this.cbx_regions.FormattingEnabled = true;
            this.cbx_regions.Location = new System.Drawing.Point(58, 68);
            this.cbx_regions.Name = "cbx_regions";
            this.cbx_regions.Size = new System.Drawing.Size(313, 31);
            this.cbx_regions.TabIndex = 2;
            this.cbx_regions.Text = "No hi han regions";
            this.cbx_regions.SelectedIndexChanged += new System.EventHandler(this.cbx_regions_SelectedValueChanged);
            // 
            // btn_guardarXML
            // 
            this.btn_guardarXML.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardarXML.Enabled = false;
            this.btn_guardarXML.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_guardarXML.FlatAppearance.BorderSize = 2;
            this.btn_guardarXML.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_guardarXML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_guardarXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardarXML.Font = new System.Drawing.Font("Nasalization Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardarXML.ForeColor = System.Drawing.Color.White;
            this.btn_guardarXML.Location = new System.Drawing.Point(421, 64);
            this.btn_guardarXML.Name = "btn_guardarXML";
            this.btn_guardarXML.Size = new System.Drawing.Size(193, 39);
            this.btn_guardarXML.TabIndex = 3;
            this.btn_guardarXML.Text = "Guardar XML";
            this.btn_guardarXML.UseVisualStyleBackColor = false;
            this.btn_guardarXML.Click += new System.EventHandler(this.btn_guardarXML_Click);
            // 
            // rtb_desc
            // 
            this.rtb_desc.BackColor = System.Drawing.Color.Black;
            this.rtb_desc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_desc.Font = new System.Drawing.Font("Nasalization Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_desc.ForeColor = System.Drawing.Color.White;
            this.rtb_desc.Location = new System.Drawing.Point(52, 178);
            this.rtb_desc.MaximumSize = new System.Drawing.Size(559, 397);
            this.rtb_desc.MinimumSize = new System.Drawing.Size(559, 0);
            this.rtb_desc.Name = "rtb_desc";
            this.rtb_desc.ReadOnly = true;
            this.rtb_desc.Size = new System.Drawing.Size(559, 397);
            this.rtb_desc.TabIndex = 6;
            this.rtb_desc.Text = "";
            // 
            // btn_carregarXML
            // 
            this.btn_carregarXML.BackColor = System.Drawing.Color.Transparent;
            this.btn_carregarXML.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_carregarXML.FlatAppearance.BorderSize = 2;
            this.btn_carregarXML.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_carregarXML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_carregarXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_carregarXML.Font = new System.Drawing.Font("Nasalization Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_carregarXML.ForeColor = System.Drawing.Color.White;
            this.btn_carregarXML.Location = new System.Drawing.Point(644, 64);
            this.btn_carregarXML.Name = "btn_carregarXML";
            this.btn_carregarXML.Size = new System.Drawing.Size(193, 39);
            this.btn_carregarXML.TabIndex = 7;
            this.btn_carregarXML.Text = "Carregar XML";
            this.btn_carregarXML.UseVisualStyleBackColor = false;
            this.btn_carregarXML.Click += new System.EventHandler(this.btn_carregarXML_Click);
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_desc.Font = new System.Drawing.Font("Nasalization Rg", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc.ForeColor = System.Drawing.Color.White;
            this.lbl_desc.Location = new System.Drawing.Point(55, 145);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(119, 23);
            this.lbl_desc.TabIndex = 8;
            this.lbl_desc.Text = "Descripció:";
            // 
            // rtb_xml
            // 
            this.rtb_xml.BackColor = System.Drawing.Color.Black;
            this.rtb_xml.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_xml.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_xml.ForeColor = System.Drawing.Color.White;
            this.rtb_xml.Location = new System.Drawing.Point(646, 129);
            this.rtb_xml.Name = "rtb_xml";
            this.rtb_xml.ReadOnly = true;
            this.rtb_xml.Size = new System.Drawing.Size(462, 446);
            this.rtb_xml.TabIndex = 9;
            this.rtb_xml.Text = "";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rsh,
            this.rsh_descripcio});
            this.shapeContainer1.Size = new System.Drawing.Size(1144, 615);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // rsh
            // 
            this.rsh.BackColor = System.Drawing.Color.Transparent;
            this.rsh.BorderColor = System.Drawing.Color.White;
            this.rsh.BorderWidth = 2;
            this.rsh.Location = new System.Drawing.Point(644, 128);
            this.rsh.Name = "rsh";
            this.rsh.Size = new System.Drawing.Size(466, 448);
            // 
            // rsh_descripcio
            // 
            this.rsh_descripcio.BackColor = System.Drawing.Color.White;
            this.rsh_descripcio.BorderColor = System.Drawing.Color.White;
            this.rsh_descripcio.BorderWidth = 2;
            this.rsh_descripcio.Location = new System.Drawing.Point(51, 177);
            this.rsh_descripcio.Name = "rsh_descripcio";
            this.rsh_descripcio.Size = new System.Drawing.Size(562, 398);
            // 
            // Frm_xmlRegions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1144, 615);
            this.Controls.Add(this.rtb_xml);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.btn_carregarXML);
            this.Controls.Add(this.rtb_desc);
            this.Controls.Add(this.btn_guardarXML);
            this.Controls.Add(this.cbx_regions);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1160, 653);
            this.MinimumSize = new System.Drawing.Size(1160, 653);
            this.Name = "Frm_xmlRegions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regions";
            this.Load += new System.EventHandler(this.frm_xmlRegions_Load);
            this.VisibleChanged += new System.EventHandler(this.Frm_xmlRegions_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox cbx_regions;
        private System.Windows.Forms.Button btn_guardarXML;
        private System.Windows.Forms.RichTextBox rtb_desc;
        private System.Windows.Forms.Button btn_carregarXML;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.RichTextBox rtb_xml;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rsh_descripcio;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rsh;
    }
}