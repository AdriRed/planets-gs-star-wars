namespace Planetes
{
    partial class Frm_dadesPlanetes
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_dadesPlanetes));
            this.btn_llegir = new System.Windows.Forms.Button();
            this.cbx_planetes = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbx_imatge = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_rutes = new System.Windows.Forms.DataGridView();
            this.txb_sector = new System.Windows.Forms.Label();
            this.txt_sector = new System.Windows.Forms.Label();
            this.txt_nafiliacio = new System.Windows.Forms.Label();
            this.txt_nativos = new System.Windows.Forms.Label();
            this.txb_nativos = new System.Windows.Forms.Label();
            this.txb_nafiliacio = new System.Windows.Forms.Label();
            this.txt_coordenades = new System.Windows.Forms.Label();
            this.txt_longitud = new System.Windows.Forms.Label();
            this.txt_latitud = new System.Windows.Forms.Label();
            this.txt_parsecs = new System.Windows.Forms.Label();
            this.txb_parsecs = new System.Windows.Forms.Label();
            this.txb_latitud = new System.Windows.Forms.Label();
            this.txb_longitud = new System.Windows.Forms.Label();
            this.pnl_imagen = new System.Windows.Forms.Panel();
            this.txt_regio = new System.Windows.Forms.Label();
            this.txb_regio = new System.Windows.Forms.Label();
            this.pnl_info = new System.Windows.Forms.Panel();
            this.pnl_coordenades = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_imatge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rutes)).BeginInit();
            this.pnl_imagen.SuspendLayout();
            this.pnl_info.SuspendLayout();
            this.pnl_coordenades.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_llegir
            // 
            this.btn_llegir.BackColor = System.Drawing.Color.Transparent;
            this.btn_llegir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_llegir.FlatAppearance.BorderSize = 2;
            this.btn_llegir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_llegir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_llegir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_llegir.Font = new System.Drawing.Font("Nasalization Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_llegir.ForeColor = System.Drawing.Color.White;
            this.btn_llegir.Location = new System.Drawing.Point(152, 111);
            this.btn_llegir.Name = "btn_llegir";
            this.btn_llegir.Size = new System.Drawing.Size(148, 39);
            this.btn_llegir.TabIndex = 0;
            this.btn_llegir.Text = "LLegir Planetes";
            this.btn_llegir.UseVisualStyleBackColor = false;
            this.btn_llegir.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbx_planetes
            // 
            this.cbx_planetes.BackColor = System.Drawing.Color.Black;
            this.cbx_planetes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_planetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_planetes.Font = new System.Drawing.Font("Nasalization Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_planetes.ForeColor = System.Drawing.Color.White;
            this.cbx_planetes.FormattingEnabled = true;
            this.cbx_planetes.IntegralHeight = false;
            this.cbx_planetes.Location = new System.Drawing.Point(322, 111);
            this.cbx_planetes.MaxDropDownItems = 12;
            this.cbx_planetes.Name = "cbx_planetes";
            this.cbx_planetes.Size = new System.Drawing.Size(313, 31);
            this.cbx_planetes.TabIndex = 0;
            this.cbx_planetes.Text = "No hi han planetes";
            this.cbx_planetes.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Archivos de texto (*.xml)|*.xml\"";
            // 
            // pbx_imatge
            // 
            this.pbx_imatge.BackColor = System.Drawing.Color.Transparent;
            this.pbx_imatge.ErrorImage = null;
            this.pbx_imatge.InitialImage = null;
            this.pbx_imatge.Location = new System.Drawing.Point(7, 8);
            this.pbx_imatge.Name = "pbx_imatge";
            this.pbx_imatge.Size = new System.Drawing.Size(277, 277);
            this.pbx_imatge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_imatge.TabIndex = 3;
            this.pbx_imatge.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 76);
            this.label1.TabIndex = 4;
            // 
            // dgv_rutes
            // 
            this.dgv_rutes.AllowUserToAddRows = false;
            this.dgv_rutes.AllowUserToDeleteRows = false;
            this.dgv_rutes.AllowUserToResizeColumns = false;
            this.dgv_rutes.AllowUserToResizeRows = false;
            this.dgv_rutes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_rutes.BackgroundColor = System.Drawing.Color.Black;
            this.dgv_rutes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv_rutes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nasalization Rg", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_rutes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_rutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_rutes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_rutes.Enabled = false;
            this.dgv_rutes.EnableHeadersVisualStyles = false;
            this.dgv_rutes.GridColor = System.Drawing.Color.Black;
            this.dgv_rutes.Location = new System.Drawing.Point(47, 473);
            this.dgv_rutes.Name = "dgv_rutes";
            this.dgv_rutes.ReadOnly = true;
            this.dgv_rutes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_rutes.RowHeadersVisible = false;
            this.dgv_rutes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_rutes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Soloist", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_rutes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_rutes.RowTemplate.ReadOnly = true;
            this.dgv_rutes.Size = new System.Drawing.Size(1017, 81);
            this.dgv_rutes.TabIndex = 10;
            this.dgv_rutes.Visible = false;
            // 
            // txb_sector
            // 
            this.txb_sector.AutoSize = true;
            this.txb_sector.BackColor = System.Drawing.Color.Transparent;
            this.txb_sector.Font = new System.Drawing.Font("Nasalization Rg", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_sector.ForeColor = System.Drawing.Color.White;
            this.txb_sector.Location = new System.Drawing.Point(133, 17);
            this.txb_sector.Name = "txb_sector";
            this.txb_sector.Size = new System.Drawing.Size(0, 25);
            this.txb_sector.TabIndex = 11;
            // 
            // txt_sector
            // 
            this.txt_sector.AutoSize = true;
            this.txt_sector.BackColor = System.Drawing.Color.Transparent;
            this.txt_sector.Font = new System.Drawing.Font("Nasalization Rg", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sector.ForeColor = System.Drawing.Color.White;
            this.txt_sector.Location = new System.Drawing.Point(24, 17);
            this.txt_sector.Name = "txt_sector";
            this.txt_sector.Size = new System.Drawing.Size(92, 25);
            this.txt_sector.TabIndex = 12;
            this.txt_sector.Text = "Sector:";
            // 
            // txt_nafiliacio
            // 
            this.txt_nafiliacio.AutoSize = true;
            this.txt_nafiliacio.BackColor = System.Drawing.Color.Transparent;
            this.txt_nafiliacio.Font = new System.Drawing.Font("Nasalization Rg", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nafiliacio.ForeColor = System.Drawing.Color.White;
            this.txt_nafiliacio.Location = new System.Drawing.Point(24, 139);
            this.txt_nafiliacio.Name = "txt_nafiliacio";
            this.txt_nafiliacio.Size = new System.Drawing.Size(103, 25);
            this.txt_nafiliacio.TabIndex = 13;
            this.txt_nafiliacio.Text = "Afiliacio:";
            // 
            // txt_nativos
            // 
            this.txt_nativos.AutoSize = true;
            this.txt_nativos.BackColor = System.Drawing.Color.Transparent;
            this.txt_nativos.Font = new System.Drawing.Font("Nasalization Rg", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nativos.ForeColor = System.Drawing.Color.White;
            this.txt_nativos.Location = new System.Drawing.Point(24, 97);
            this.txt_nativos.Name = "txt_nativos";
            this.txt_nativos.Size = new System.Drawing.Size(90, 25);
            this.txt_nativos.TabIndex = 14;
            this.txt_nativos.Text = "Natius:";
            // 
            // txb_nativos
            // 
            this.txb_nativos.AutoSize = true;
            this.txb_nativos.BackColor = System.Drawing.Color.Transparent;
            this.txb_nativos.Font = new System.Drawing.Font("Nasalization Rg", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_nativos.ForeColor = System.Drawing.Color.White;
            this.txb_nativos.Location = new System.Drawing.Point(133, 97);
            this.txb_nativos.Name = "txb_nativos";
            this.txb_nativos.Size = new System.Drawing.Size(0, 25);
            this.txb_nativos.TabIndex = 15;
            // 
            // txb_nafiliacio
            // 
            this.txb_nafiliacio.AutoSize = true;
            this.txb_nafiliacio.BackColor = System.Drawing.Color.Transparent;
            this.txb_nafiliacio.Font = new System.Drawing.Font("Nasalization Rg", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_nafiliacio.ForeColor = System.Drawing.Color.White;
            this.txb_nafiliacio.Location = new System.Drawing.Point(133, 139);
            this.txb_nafiliacio.Name = "txb_nafiliacio";
            this.txb_nafiliacio.Size = new System.Drawing.Size(0, 25);
            this.txb_nafiliacio.TabIndex = 16;
            // 
            // txt_coordenades
            // 
            this.txt_coordenades.AutoSize = true;
            this.txt_coordenades.BackColor = System.Drawing.Color.Transparent;
            this.txt_coordenades.Font = new System.Drawing.Font("Nasalization Rg", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coordenades.ForeColor = System.Drawing.Color.White;
            this.txt_coordenades.Location = new System.Drawing.Point(3, 14);
            this.txt_coordenades.Name = "txt_coordenades";
            this.txt_coordenades.Size = new System.Drawing.Size(163, 25);
            this.txt_coordenades.TabIndex = 17;
            this.txt_coordenades.Text = "Coordenades";
            // 
            // txt_longitud
            // 
            this.txt_longitud.AutoSize = true;
            this.txt_longitud.BackColor = System.Drawing.Color.Transparent;
            this.txt_longitud.Font = new System.Drawing.Font("Nasalization Rg", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_longitud.ForeColor = System.Drawing.Color.White;
            this.txt_longitud.Location = new System.Drawing.Point(5, 44);
            this.txt_longitud.Name = "txt_longitud";
            this.txt_longitud.Size = new System.Drawing.Size(79, 18);
            this.txt_longitud.TabIndex = 18;
            this.txt_longitud.Text = "Longitud";
            this.txt_longitud.UseMnemonic = false;
            // 
            // txt_latitud
            // 
            this.txt_latitud.AutoSize = true;
            this.txt_latitud.BackColor = System.Drawing.Color.Transparent;
            this.txt_latitud.Font = new System.Drawing.Font("Nasalization Rg", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_latitud.ForeColor = System.Drawing.Color.White;
            this.txt_latitud.Location = new System.Drawing.Point(5, 70);
            this.txt_latitud.Name = "txt_latitud";
            this.txt_latitud.Size = new System.Drawing.Size(64, 18);
            this.txt_latitud.TabIndex = 19;
            this.txt_latitud.Text = "Latitud";
            this.txt_latitud.UseMnemonic = false;
            // 
            // txt_parsecs
            // 
            this.txt_parsecs.AutoSize = true;
            this.txt_parsecs.BackColor = System.Drawing.Color.Transparent;
            this.txt_parsecs.Font = new System.Drawing.Font("Nasalization Rg", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_parsecs.ForeColor = System.Drawing.Color.White;
            this.txt_parsecs.Location = new System.Drawing.Point(5, 96);
            this.txt_parsecs.Name = "txt_parsecs";
            this.txt_parsecs.Size = new System.Drawing.Size(71, 18);
            this.txt_parsecs.TabIndex = 20;
            this.txt_parsecs.Text = "Parsecs";
            this.txt_parsecs.UseMnemonic = false;
            // 
            // txb_parsecs
            // 
            this.txb_parsecs.AutoSize = true;
            this.txb_parsecs.BackColor = System.Drawing.Color.Transparent;
            this.txb_parsecs.Font = new System.Drawing.Font("Nasalization Rg", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_parsecs.ForeColor = System.Drawing.Color.White;
            this.txb_parsecs.Location = new System.Drawing.Point(89, 96);
            this.txb_parsecs.Name = "txb_parsecs";
            this.txb_parsecs.Size = new System.Drawing.Size(0, 18);
            this.txb_parsecs.TabIndex = 23;
            this.txb_parsecs.UseMnemonic = false;
            // 
            // txb_latitud
            // 
            this.txb_latitud.AutoSize = true;
            this.txb_latitud.BackColor = System.Drawing.Color.Transparent;
            this.txb_latitud.Font = new System.Drawing.Font("Nasalization Rg", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_latitud.ForeColor = System.Drawing.Color.White;
            this.txb_latitud.Location = new System.Drawing.Point(89, 70);
            this.txb_latitud.Name = "txb_latitud";
            this.txb_latitud.Size = new System.Drawing.Size(0, 18);
            this.txb_latitud.TabIndex = 22;
            this.txb_latitud.UseMnemonic = false;
            // 
            // txb_longitud
            // 
            this.txb_longitud.AutoSize = true;
            this.txb_longitud.BackColor = System.Drawing.Color.Transparent;
            this.txb_longitud.Font = new System.Drawing.Font("Nasalization Rg", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_longitud.ForeColor = System.Drawing.Color.White;
            this.txb_longitud.Location = new System.Drawing.Point(89, 44);
            this.txb_longitud.Name = "txb_longitud";
            this.txb_longitud.Size = new System.Drawing.Size(0, 18);
            this.txb_longitud.TabIndex = 21;
            this.txb_longitud.UseMnemonic = false;
            // 
            // pnl_imagen
            // 
            this.pnl_imagen.BackColor = System.Drawing.Color.Transparent;
            this.pnl_imagen.Controls.Add(this.pbx_imatge);
            this.pnl_imagen.Location = new System.Drawing.Point(769, 111);
            this.pnl_imagen.Name = "pnl_imagen";
            this.pnl_imagen.Size = new System.Drawing.Size(292, 292);
            this.pnl_imagen.TabIndex = 24;
            this.pnl_imagen.Visible = false;
            this.pnl_imagen.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_regio
            // 
            this.txt_regio.AutoSize = true;
            this.txt_regio.BackColor = System.Drawing.Color.Transparent;
            this.txt_regio.Font = new System.Drawing.Font("Nasalization Rg", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regio.ForeColor = System.Drawing.Color.White;
            this.txt_regio.Location = new System.Drawing.Point(24, 55);
            this.txt_regio.Name = "txt_regio";
            this.txt_regio.Size = new System.Drawing.Size(80, 25);
            this.txt_regio.TabIndex = 25;
            this.txt_regio.Text = "Regió:";
            // 
            // txb_regio
            // 
            this.txb_regio.AutoSize = true;
            this.txb_regio.BackColor = System.Drawing.Color.Transparent;
            this.txb_regio.Font = new System.Drawing.Font("Nasalization Rg", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_regio.ForeColor = System.Drawing.Color.White;
            this.txb_regio.Location = new System.Drawing.Point(133, 55);
            this.txb_regio.Name = "txb_regio";
            this.txb_regio.Size = new System.Drawing.Size(0, 25);
            this.txb_regio.TabIndex = 26;
            // 
            // pnl_info
            // 
            this.pnl_info.BackColor = System.Drawing.Color.Transparent;
            this.pnl_info.Controls.Add(this.txb_sector);
            this.pnl_info.Controls.Add(this.txt_sector);
            this.pnl_info.Controls.Add(this.txb_regio);
            this.pnl_info.Controls.Add(this.txt_nafiliacio);
            this.pnl_info.Controls.Add(this.txt_regio);
            this.pnl_info.Controls.Add(this.txt_nativos);
            this.pnl_info.Controls.Add(this.txb_nativos);
            this.pnl_info.Controls.Add(this.txb_nafiliacio);
            this.pnl_info.Location = new System.Drawing.Point(62, 230);
            this.pnl_info.Name = "pnl_info";
            this.pnl_info.Size = new System.Drawing.Size(454, 173);
            this.pnl_info.TabIndex = 27;
            this.pnl_info.Visible = false;
            // 
            // pnl_coordenades
            // 
            this.pnl_coordenades.BackColor = System.Drawing.Color.Transparent;
            this.pnl_coordenades.Controls.Add(this.txt_coordenades);
            this.pnl_coordenades.Controls.Add(this.txt_longitud);
            this.pnl_coordenades.Controls.Add(this.txt_latitud);
            this.pnl_coordenades.Controls.Add(this.txt_parsecs);
            this.pnl_coordenades.Controls.Add(this.txb_parsecs);
            this.pnl_coordenades.Controls.Add(this.txb_longitud);
            this.pnl_coordenades.Controls.Add(this.txb_latitud);
            this.pnl_coordenades.Location = new System.Drawing.Point(565, 285);
            this.pnl_coordenades.Name = "pnl_coordenades";
            this.pnl_coordenades.Size = new System.Drawing.Size(198, 118);
            this.pnl_coordenades.TabIndex = 28;
            this.pnl_coordenades.Visible = false;
            // 
            // Frm_dadesPlanetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1144, 615);
            this.Controls.Add(this.pnl_coordenades);
            this.Controls.Add(this.pnl_info);
            this.Controls.Add(this.btn_llegir);
            this.Controls.Add(this.pnl_imagen);
            this.Controls.Add(this.dgv_rutes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_planetes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1160, 653);
            this.MinimumSize = new System.Drawing.Size(1160, 653);
            this.Name = "Frm_dadesPlanetes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planetes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_imatge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rutes)).EndInit();
            this.pnl_imagen.ResumeLayout(false);
            this.pnl_info.ResumeLayout(false);
            this.pnl_info.PerformLayout();
            this.pnl_coordenades.ResumeLayout(false);
            this.pnl_coordenades.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_llegir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbx_imatge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_rutes;
        private System.Windows.Forms.Label txb_sector;
        private System.Windows.Forms.Label txt_sector;
        private System.Windows.Forms.Label txt_nafiliacio;
        private System.Windows.Forms.Label txt_nativos;
        private System.Windows.Forms.Label txb_nativos;
        private System.Windows.Forms.Label txb_nafiliacio;
        private System.Windows.Forms.Label txt_coordenades;
        private System.Windows.Forms.Label txt_longitud;
        private System.Windows.Forms.Label txt_latitud;
        private System.Windows.Forms.Label txt_parsecs;
        private System.Windows.Forms.Label txb_parsecs;
        private System.Windows.Forms.Label txb_latitud;
        private System.Windows.Forms.Label txb_longitud;
        private System.Windows.Forms.Panel pnl_imagen;
        private System.Windows.Forms.Label txt_regio;
        private System.Windows.Forms.Label txb_regio;
        private System.Windows.Forms.Panel pnl_info;
        private System.Windows.Forms.Panel pnl_coordenades;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.ComboBox cbx_planetes;
    }
}

