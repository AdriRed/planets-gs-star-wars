namespace Frm_crystal
{
    partial class frm_crystal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_crystal));
            this.cbx_planetes = new System.Windows.Forms.ComboBox();
            this.crv_Informe = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Llista1 = new Frm_crystal.Llista();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbx_planetes
            // 
            this.cbx_planetes.BackColor = System.Drawing.Color.Black;
            this.cbx_planetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_planetes.Font = new System.Drawing.Font("Nasalization Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_planetes.ForeColor = System.Drawing.Color.White;
            this.cbx_planetes.FormattingEnabled = true;
            this.cbx_planetes.Location = new System.Drawing.Point(26, 12);
            this.cbx_planetes.Name = "cbx_planetes";
            this.cbx_planetes.Size = new System.Drawing.Size(315, 31);
            this.cbx_planetes.TabIndex = 0;
            this.cbx_planetes.SelectedIndexChanged += new System.EventHandler(this.cbx_planetes_SelectedIndexChanged);
            // 
            // crv_Informe
            // 
            this.crv_Informe.ActiveViewIndex = 0;
            this.crv_Informe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Informe.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Informe.DisplayStatusBar = false;
            this.crv_Informe.EnableToolTips = false;
            this.crv_Informe.Font = new System.Drawing.Font("Nasalization Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crv_Informe.Location = new System.Drawing.Point(12, 65);
            this.crv_Informe.Name = "crv_Informe";
            this.crv_Informe.ReportSource = this.Llista1;
            this.crv_Informe.ShowCloseButton = false;
            this.crv_Informe.ShowExportButton = false;
            this.crv_Informe.ShowGroupTreeButton = false;
            this.crv_Informe.ShowLogo = false;
            this.crv_Informe.ShowParameterPanelButton = false;
            this.crv_Informe.Size = new System.Drawing.Size(1060, 642);
            this.crv_Informe.TabIndex = 1;
            this.crv_Informe.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.Transparent;
            this.btn_enviar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_enviar.FlatAppearance.BorderSize = 2;
            this.btn_enviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_enviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enviar.Font = new System.Drawing.Font("Nasalization Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.ForeColor = System.Drawing.Color.White;
            this.btn_enviar.Location = new System.Drawing.Point(369, 9);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(92, 35);
            this.btn_enviar.TabIndex = 2;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // frm_crystal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 719);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.crv_Informe);
            this.Controls.Add(this.cbx_planetes);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 757);
            this.MinimumSize = new System.Drawing.Size(1100, 757);
            this.Name = "frm_crystal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crystal Report";
            this.Load += new System.EventHandler(this.Frm_crystal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_planetes;
        private Llista Llista1;
        private System.Windows.Forms.Button btn_enviar;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Informe;
    }
}