namespace Formlar
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbNereden = new System.Windows.Forms.ComboBox();
            this.cmbNereye = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkTekYon = new System.Windows.Forms.CheckBox();
            this.chkCiftYon = new System.Windows.Forms.CheckBox();
            this.dtGidisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtDonusTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblGidis = new System.Windows.Forms.Label();
            this.lblDonus = new System.Windows.Forms.Label();
            this.nmrYetiskinSayisi = new System.Windows.Forms.NumericUpDown();
            this.nmrCocukSayisi = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrYetiskinSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCocukSayisi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNereden
            // 
            this.cmbNereden.FormattingEnabled = true;
            this.cmbNereden.Location = new System.Drawing.Point(51, 60);
            this.cmbNereden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNereden.Name = "cmbNereden";
            this.cmbNereden.Size = new System.Drawing.Size(160, 24);
            this.cmbNereden.TabIndex = 0;
            // 
            // cmbNereye
            // 
            this.cmbNereye.FormattingEnabled = true;
            this.cmbNereye.Location = new System.Drawing.Point(296, 60);
            this.cmbNereye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.Size = new System.Drawing.Size(160, 24);
            this.cmbNereye.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nereden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nereye";
            // 
            // chkTekYon
            // 
            this.chkTekYon.AutoSize = true;
            this.chkTekYon.Location = new System.Drawing.Point(50, 113);
            this.chkTekYon.Name = "chkTekYon";
            this.chkTekYon.Size = new System.Drawing.Size(80, 21);
            this.chkTekYon.TabIndex = 2;
            this.chkTekYon.Text = "Tek Yön";
            this.chkTekYon.UseVisualStyleBackColor = true;
            // 
            // chkCiftYon
            // 
            this.chkCiftYon.AutoSize = true;
            this.chkCiftYon.Location = new System.Drawing.Point(164, 113);
            this.chkCiftYon.Name = "chkCiftYon";
            this.chkCiftYon.Size = new System.Drawing.Size(76, 21);
            this.chkCiftYon.TabIndex = 3;
            this.chkCiftYon.Text = "Çift Yön";
            this.chkCiftYon.UseVisualStyleBackColor = true;
            // 
            // dtGidisTarihi
            // 
            this.dtGidisTarihi.Location = new System.Drawing.Point(51, 191);
            this.dtGidisTarihi.Name = "dtGidisTarihi";
            this.dtGidisTarihi.Size = new System.Drawing.Size(200, 23);
            this.dtGidisTarihi.TabIndex = 4;
            // 
            // dtDonusTarihi
            // 
            this.dtDonusTarihi.Location = new System.Drawing.Point(296, 191);
            this.dtDonusTarihi.Name = "dtDonusTarihi";
            this.dtDonusTarihi.Size = new System.Drawing.Size(200, 23);
            this.dtDonusTarihi.TabIndex = 5;
            // 
            // lblGidis
            // 
            this.lblGidis.AutoSize = true;
            this.lblGidis.Location = new System.Drawing.Point(52, 162);
            this.lblGidis.Name = "lblGidis";
            this.lblGidis.Size = new System.Drawing.Size(80, 17);
            this.lblGidis.TabIndex = 5;
            this.lblGidis.Text = "Gidiş Tarihi";
            // 
            // lblDonus
            // 
            this.lblDonus.AutoSize = true;
            this.lblDonus.Location = new System.Drawing.Point(293, 162);
            this.lblDonus.Name = "lblDonus";
            this.lblDonus.Size = new System.Drawing.Size(89, 17);
            this.lblDonus.TabIndex = 5;
            this.lblDonus.Text = "Dönüş Tarihi";
            // 
            // nmrYetiskinSayisi
            // 
            this.nmrYetiskinSayisi.Location = new System.Drawing.Point(13, 20);
            this.nmrYetiskinSayisi.Name = "nmrYetiskinSayisi";
            this.nmrYetiskinSayisi.Size = new System.Drawing.Size(120, 23);
            this.nmrYetiskinSayisi.TabIndex = 6;
            // 
            // nmrCocukSayisi
            // 
            this.nmrCocukSayisi.Location = new System.Drawing.Point(13, 57);
            this.nmrCocukSayisi.Name = "nmrCocukSayisi";
            this.nmrCocukSayisi.Size = new System.Drawing.Size(120, 23);
            this.nmrCocukSayisi.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(137, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yetişkin Sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(137, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Çocuk Sayısı";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(309, 270);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sınıf";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nmrCocukSayisi);
            this.groupBox1.Controls.Add(this.nmrYetiskinSayisi);
            this.groupBox1.Location = new System.Drawing.Point(51, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 93);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "ARA";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(449, 348);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 441);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblDonus);
            this.Controls.Add(this.lblGidis);
            this.Controls.Add(this.dtDonusTarihi);
            this.Controls.Add(this.dtGidisTarihi);
            this.Controls.Add(this.chkCiftYon);
            this.Controls.Add(this.chkTekYon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNereye);
            this.Controls.Add(this.cmbNereden);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrYetiskinSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCocukSayisi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNereden;
        private System.Windows.Forms.ComboBox cmbNereye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkTekYon;
        private System.Windows.Forms.CheckBox chkCiftYon;
        private System.Windows.Forms.DateTimePicker dtGidisTarihi;
        private System.Windows.Forms.DateTimePicker dtDonusTarihi;
        private System.Windows.Forms.Label lblGidis;
        private System.Windows.Forms.Label lblDonus;
        private System.Windows.Forms.NumericUpDown nmrYetiskinSayisi;
        private System.Windows.Forms.NumericUpDown nmrCocukSayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

