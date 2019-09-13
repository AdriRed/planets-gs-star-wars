namespace Planetes
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_regio = new System.Windows.Forms.Label();
            this.txb_regio = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(152, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "LLegir Planetes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Black;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Goldenrod;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(322, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(313, 32);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "No hi han planetes";
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Archivos de texto (*.xml)|*.xml\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(7, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(12, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 76);
            this.label1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(44, 477);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1017, 81);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Visible = false;
            // 
            // txb_sector
            // 
            this.txb_sector.AutoSize = true;
            this.txb_sector.BackColor = System.Drawing.Color.Transparent;
            this.txb_sector.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_sector.ForeColor = System.Drawing.Color.Gold;
            this.txb_sector.Location = new System.Drawing.Point(133, 17);
            this.txb_sector.Name = "txb_sector";
            this.txb_sector.Size = new System.Drawing.Size(0, 25);
            this.txb_sector.TabIndex = 11;
            // 
            // txt_sector
            // 
            this.txt_sector.AutoSize = true;
            this.txt_sector.BackColor = System.Drawing.Color.Transparent;
            this.txt_sector.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sector.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_sector.Location = new System.Drawing.Point(24, 17);
            this.txt_sector.Name = "txt_sector";
            this.txt_sector.Size = new System.Drawing.Size(80, 25);
            this.txt_sector.TabIndex = 12;
            this.txt_sector.Text = "Sector:";
            // 
            // txt_nafiliacio
            // 
            this.txt_nafiliacio.AutoSize = true;
            this.txt_nafiliacio.BackColor = System.Drawing.Color.Transparent;
            this.txt_nafiliacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nafiliacio.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_nafiliacio.Location = new System.Drawing.Point(24, 139);
            this.txt_nafiliacio.Name = "txt_nafiliacio";
            this.txt_nafiliacio.Size = new System.Drawing.Size(93, 25);
            this.txt_nafiliacio.TabIndex = 13;
            this.txt_nafiliacio.Text = "Afiliacio:";
            // 
            // txt_nativos
            // 
            this.txt_nativos.AutoSize = true;
            this.txt_nativos.BackColor = System.Drawing.Color.Transparent;
            this.txt_nativos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nativos.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_nativos.Location = new System.Drawing.Point(24, 97);
            this.txt_nativos.Name = "txt_nativos";
            this.txt_nativos.Size = new System.Drawing.Size(79, 25);
            this.txt_nativos.TabIndex = 14;
            this.txt_nativos.Text = "Natius:";
            // 
            // txb_nativos
            // 
            this.txb_nativos.AutoSize = true;
            this.txb_nativos.BackColor = System.Drawing.Color.Transparent;
            this.txb_nativos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_nativos.ForeColor = System.Drawing.Color.Gold;
            this.txb_nativos.Location = new System.Drawing.Point(133, 97);
            this.txb_nativos.Name = "txb_nativos";
            this.txb_nativos.Size = new System.Drawing.Size(0, 25);
            this.txb_nativos.TabIndex = 15;
            // 
            // txb_nafiliacio
            // 
            this.txb_nafiliacio.AutoSize = true;
            this.txb_nafiliacio.BackColor = System.Drawing.Color.Transparent;
            this.txb_nafiliacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_nafiliacio.ForeColor = System.Drawing.Color.Gold;
            this.txb_nafiliacio.Location = new System.Drawing.Point(133, 139);
            this.txb_nafiliacio.Name = "txb_nafiliacio";
            this.txb_nafiliacio.Size = new System.Drawing.Size(0, 25);
            this.txb_nafiliacio.TabIndex = 16;
            // 
            // txt_coordenades
            // 
            this.txt_coordenades.AutoSize = true;
            this.txt_coordenades.BackColor = System.Drawing.Color.Transparent;
            this.txt_coordenades.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coordenades.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_coordenades.Location = new System.Drawing.Point(3, 14);
            this.txt_coordenades.Name = "txt_coordenades";
            this.txt_coordenades.Size = new System.Drawing.Size(141, 25);
            this.txt_coordenades.TabIndex = 17;
            this.txt_coordenades.Text = "Coordenades";
            // 
            // txt_longitud
            // 
            this.txt_longitud.AutoSize = true;
            this.txt_longitud.BackColor = System.Drawing.Color.Transparent;
            this.txt_longitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_longitud.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_longitud.Location = new System.Drawing.Point(5, 44);
            this.txt_longitud.Name = "txt_longitud";
            this.txt_longitud.Size = new System.Drawing.Size(64, 18);
            this.txt_longitud.TabIndex = 18;
            this.txt_longitud.Text = "Longitud";
            this.txt_longitud.UseMnemonic = false;
            // 
            // txt_latitud
            // 
            this.txt_latitud.AutoSize = true;
            this.txt_latitud.BackColor = System.Drawing.Color.Transparent;
            this.txt_latitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_latitud.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_latitud.Location = new System.Drawing.Point(5, 70);
            this.txt_latitud.Name = "txt_latitud";
            this.txt_latitud.Size = new System.Drawing.Size(51, 18);
            this.txt_latitud.TabIndex = 19;
            this.txt_latitud.Text = "Latitud";
            this.txt_latitud.UseMnemonic = false;
            // 
            // txt_parsecs
            // 
            this.txt_parsecs.AutoSize = true;
            this.txt_parsecs.BackColor = System.Drawing.Color.Transparent;
            this.txt_parsecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_parsecs.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_parsecs.Location = new System.Drawing.Point(5, 96);
            this.txt_parsecs.Name = "txt_parsecs";
            this.txt_parsecs.Size = new System.Drawing.Size(63, 18);
            this.txt_parsecs.TabIndex = 20;
            this.txt_parsecs.Text = "Parsecs";
            this.txt_parsecs.UseMnemonic = false;
            // 
            // txb_parsecs
            // 
            this.txb_parsecs.AutoSize = true;
            this.txb_parsecs.BackColor = System.Drawing.Color.Transparent;
            this.txb_parsecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_parsecs.ForeColor = System.Drawing.Color.Gold;
            this.txb_parsecs.Location = new System.Drawing.Point(70, 96);
            this.txb_parsecs.Name = "txb_parsecs";
            this.txb_parsecs.Size = new System.Drawing.Size(0, 18);
            this.txb_parsecs.TabIndex = 23;
            this.txb_parsecs.UseMnemonic = false;
            // 
            // txb_latitud
            // 
            this.txb_latitud.AutoSize = true;
            this.txb_latitud.BackColor = System.Drawing.Color.Transparent;
            this.txb_latitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_latitud.ForeColor = System.Drawing.Color.Gold;
            this.txb_latitud.Location = new System.Drawing.Point(70, 70);
            this.txb_latitud.Name = "txb_latitud";
            this.txb_latitud.Size = new System.Drawing.Size(0, 18);
            this.txb_latitud.TabIndex = 22;
            this.txb_latitud.UseMnemonic = false;
            // 
            // txb_longitud
            // 
            this.txb_longitud.AutoSize = true;
            this.txb_longitud.BackColor = System.Drawing.Color.Transparent;
            this.txb_longitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_longitud.ForeColor = System.Drawing.Color.Gold;
            this.txb_longitud.Location = new System.Drawing.Point(70, 44);
            this.txb_longitud.Name = "txb_longitud";
            this.txb_longitud.Size = new System.Drawing.Size(0, 18);
            this.txb_longitud.TabIndex = 21;
            this.txb_longitud.UseMnemonic = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(769, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 292);
            this.panel1.TabIndex = 24;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_regio
            // 
            this.txt_regio.AutoSize = true;
            this.txt_regio.BackColor = System.Drawing.Color.Transparent;
            this.txt_regio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regio.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_regio.Location = new System.Drawing.Point(24, 55);
            this.txt_regio.Name = "txt_regio";
            this.txt_regio.Size = new System.Drawing.Size(74, 25);
            this.txt_regio.TabIndex = 25;
            this.txt_regio.Text = "Regió:";
            // 
            // txb_regio
            // 
            this.txb_regio.AutoSize = true;
            this.txb_regio.BackColor = System.Drawing.Color.Transparent;
            this.txb_regio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_regio.ForeColor = System.Drawing.Color.Gold;
            this.txb_regio.Location = new System.Drawing.Point(133, 55);
            this.txb_regio.Name = "txb_regio";
            this.txb_regio.Size = new System.Drawing.Size(0, 25);
            this.txb_regio.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txb_sector);
            this.panel2.Controls.Add(this.txt_sector);
            this.panel2.Controls.Add(this.txb_regio);
            this.panel2.Controls.Add(this.txt_nafiliacio);
            this.panel2.Controls.Add(this.txt_regio);
            this.panel2.Controls.Add(this.txt_nativos);
            this.panel2.Controls.Add(this.txb_nativos);
            this.panel2.Controls.Add(this.txb_nafiliacio);
            this.panel2.Location = new System.Drawing.Point(62, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 173);
            this.panel2.TabIndex = 27;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.txt_coordenades);
            this.panel3.Controls.Add(this.txt_longitud);
            this.panel3.Controls.Add(this.txt_latitud);
            this.panel3.Controls.Add(this.txt_parsecs);
            this.panel3.Controls.Add(this.txb_parsecs);
            this.panel3.Controls.Add(this.txb_longitud);
            this.panel3.Controls.Add(this.txb_latitud);
            this.panel3.Location = new System.Drawing.Point(592, 285);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 118);
            this.panel3.TabIndex = 28;
            this.panel3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1144, 615);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Planetes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt_regio;
        private System.Windows.Forms.Label txb_regio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}

