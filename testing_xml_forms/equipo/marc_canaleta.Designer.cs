namespace testing_xml_forms
{
    partial class marc_canaleta
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
            this.lbl_Nom = new System.Windows.Forms.Label();
            this.lbl_cognom = new System.Windows.Forms.Label();
            this.lbl_instagram = new System.Windows.Forms.Label();
            this.lbl_url_marc = new System.Windows.Forms.LinkLabel();
            this.pic_insta_logo = new System.Windows.Forms.PictureBox();
            this.pic_foto_face = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_insta_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto_face)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Nom
            // 
            this.lbl_Nom.AutoSize = true;
            this.lbl_Nom.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Nom.Font = new System.Drawing.Font("Nasalization Rg", 8.25F, System.Drawing.FontStyle.Underline);
            this.lbl_Nom.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Nom.Location = new System.Drawing.Point(12, 33);
            this.lbl_Nom.Name = "lbl_Nom";
            this.lbl_Nom.Size = new System.Drawing.Size(41, 13);
            this.lbl_Nom.TabIndex = 1;
            this.lbl_Nom.Text = "Nom: ";
            // 
            // lbl_cognom
            // 
            this.lbl_cognom.AutoSize = true;
            this.lbl_cognom.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cognom.Font = new System.Drawing.Font("Nasalization Rg", 8.25F, System.Drawing.FontStyle.Underline);
            this.lbl_cognom.ForeColor = System.Drawing.Color.Gold;
            this.lbl_cognom.Location = new System.Drawing.Point(12, 82);
            this.lbl_cognom.Name = "lbl_cognom";
            this.lbl_cognom.Size = new System.Drawing.Size(62, 13);
            this.lbl_cognom.TabIndex = 2;
            this.lbl_cognom.Text = "Cognom: ";
            // 
            // lbl_instagram
            // 
            this.lbl_instagram.AutoSize = true;
            this.lbl_instagram.BackColor = System.Drawing.Color.Transparent;
            this.lbl_instagram.Font = new System.Drawing.Font("Nasalization Rg", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instagram.ForeColor = System.Drawing.Color.Gold;
            this.lbl_instagram.Location = new System.Drawing.Point(53, 190);
            this.lbl_instagram.Name = "lbl_instagram";
            this.lbl_instagram.Size = new System.Drawing.Size(69, 13);
            this.lbl_instagram.TabIndex = 6;
            this.lbl_instagram.Text = "Instagram:";
            this.lbl_instagram.Click += new System.EventHandler(this.lbl_instagram_Click);
            // 
            // lbl_url_marc
            // 
            this.lbl_url_marc.AutoSize = true;
            this.lbl_url_marc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_url_marc.Font = new System.Drawing.Font("Nasalization Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_url_marc.LinkColor = System.Drawing.Color.DarkGoldenrod;
            this.lbl_url_marc.Location = new System.Drawing.Point(129, 190);
            this.lbl_url_marc.Name = "lbl_url_marc";
            this.lbl_url_marc.Size = new System.Drawing.Size(101, 13);
            this.lbl_url_marc.TabIndex = 8;
            this.lbl_url_marc.TabStop = true;
            this.lbl_url_marc.Text = "@marc_canaleta";
            this.lbl_url_marc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_url_marc_LinkClicked);
            // 
            // pic_insta_logo
            // 
            this.pic_insta_logo.BackColor = System.Drawing.Color.Transparent;
            this.pic_insta_logo.Image = global::testing_xml_forms.Properties.Resources.logo_insta;
            this.pic_insta_logo.Location = new System.Drawing.Point(12, 178);
            this.pic_insta_logo.Name = "pic_insta_logo";
            this.pic_insta_logo.Size = new System.Drawing.Size(26, 25);
            this.pic_insta_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_insta_logo.TabIndex = 7;
            this.pic_insta_logo.TabStop = false;
            this.pic_insta_logo.Click += new System.EventHandler(this.pic_insta_logo_Click);
            // 
            // pic_foto_face
            // 
            this.pic_foto_face.BackColor = System.Drawing.Color.Transparent;
            this.pic_foto_face.ImageLocation = "";
            this.pic_foto_face.Location = new System.Drawing.Point(277, 22);
            this.pic_foto_face.Name = "pic_foto_face";
            this.pic_foto_face.Size = new System.Drawing.Size(111, 104);
            this.pic_foto_face.TabIndex = 5;
            this.pic_foto_face.TabStop = false;
            this.pic_foto_face.Click += new System.EventHandler(this.pic_foto_face_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nasalization Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(77, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Marc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nasalization Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(77, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Canaleta";
            // 
            // marc_canaleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::testing_xml_forms.Properties.Resources.fons_app;
            this.ClientSize = new System.Drawing.Size(414, 377);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_url_marc);
            this.Controls.Add(this.pic_insta_logo);
            this.Controls.Add(this.lbl_instagram);
            this.Controls.Add(this.pic_foto_face);
            this.Controls.Add(this.lbl_cognom);
            this.Controls.Add(this.lbl_Nom);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "marc_canaleta";
            this.Text = "Marc Canaleta";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_insta_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto_face)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nom;
        private System.Windows.Forms.Label lbl_cognom;
        private System.Windows.Forms.PictureBox pic_foto_face;
        private System.Windows.Forms.Label lbl_instagram;
        private System.Windows.Forms.PictureBox pic_insta_logo;
        private System.Windows.Forms.LinkLabel lbl_url_marc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}