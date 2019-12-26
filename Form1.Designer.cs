namespace EmlakKayıt
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHead = new System.Windows.Forms.Label();
            this.FlatPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.WeatherPanel = new System.Windows.Forms.Panel();
            this.CustomerPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ClockPanel = new System.Windows.Forms.Panel();
            this.FinancePanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pnlAna = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnCurrent = new System.Windows.Forms.Button();
            this.btnCasa = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.FlatPanel.SuspendLayout();
            this.CustomerPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.pnlAna.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnCurrent);
            this.panel1.Controls.Add(this.btnCasa);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 814);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnMin);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblHead);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(185, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1322, 100);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(371, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "V 1.1";
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHead.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHead.Location = new System.Drawing.Point(32, 25);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(334, 42);
            this.lblHead.TabIndex = 0;
            this.lblHead.Text = "Ticari Takip Uygulması";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlatPanel
            // 
            this.FlatPanel.BackColor = System.Drawing.Color.ForestGreen;
            this.FlatPanel.Controls.Add(this.label8);
            this.FlatPanel.Controls.Add(this.label7);
            this.FlatPanel.Controls.Add(this.button6);
            this.FlatPanel.Location = new System.Drawing.Point(436, 46);
            this.FlatPanel.Name = "FlatPanel";
            this.FlatPanel.Size = new System.Drawing.Size(325, 135);
            this.FlatPanel.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(13, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Daire sayısı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(23, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 37);
            this.label7.TabIndex = 3;
            this.label7.Text = "110";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.Location = new System.Drawing.Point(246, 65);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(66, 58);
            this.button6.TabIndex = 2;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // WeatherPanel
            // 
            this.WeatherPanel.Location = new System.Drawing.Point(35, 334);
            this.WeatherPanel.Name = "WeatherPanel";
            this.WeatherPanel.Size = new System.Drawing.Size(295, 305);
            this.WeatherPanel.TabIndex = 6;
            // 
            // CustomerPanel
            // 
            this.CustomerPanel.BackColor = System.Drawing.Color.Coral;
            this.CustomerPanel.Controls.Add(this.label6);
            this.CustomerPanel.Controls.Add(this.button5);
            this.CustomerPanel.Controls.Add(this.label5);
            this.CustomerPanel.Location = new System.Drawing.Point(45, 46);
            this.CustomerPanel.Name = "CustomerPanel";
            this.CustomerPanel.Size = new System.Drawing.Size(285, 135);
            this.CustomerPanel.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(19, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 37);
            this.label6.TabIndex = 2;
            this.label6.Text = "64";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.Location = new System.Drawing.Point(202, 65);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 58);
            this.button5.TabIndex = 1;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(18, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kiracı sayısı";
            // 
            // ClockPanel
            // 
            this.ClockPanel.Location = new System.Drawing.Point(942, 67);
            this.ClockPanel.Name = "ClockPanel";
            this.ClockPanel.Size = new System.Drawing.Size(365, 106);
            this.ClockPanel.TabIndex = 4;
            // 
            // FinancePanel
            // 
            this.FinancePanel.Location = new System.Drawing.Point(942, 212);
            this.FinancePanel.Name = "FinancePanel";
            this.FinancePanel.Size = new System.Drawing.Size(370, 452);
            this.FinancePanel.TabIndex = 7;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.pnlAna);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(185, 100);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1322, 714);
            this.mainPanel.TabIndex = 5;
            // 
            // pnlAna
            // 
            this.pnlAna.Controls.Add(this.FlatPanel);
            this.pnlAna.Controls.Add(this.panel3);
            this.pnlAna.Controls.Add(this.WeatherPanel);
            this.pnlAna.Controls.Add(this.FinancePanel);
            this.pnlAna.Controls.Add(this.CustomerPanel);
            this.pnlAna.Controls.Add(this.ClockPanel);
            this.pnlAna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAna.Location = new System.Drawing.Point(0, 0);
            this.pnlAna.Name = "pnlAna";
            this.pnlAna.Size = new System.Drawing.Size(1322, 714);
            this.pnlAna.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(453, 334);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 305);
            this.panel3.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::EmlakKayıt.Properties.Resources.Close;
            this.btnClose.Location = new System.Drawing.Point(1248, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 42);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = global::EmlakKayıt.Properties.Resources.Minimize;
            this.btnMin.Location = new System.Drawing.Point(1194, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(62, 42);
            this.btnMin.TabIndex = 2;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // btnCurrent
            // 
            this.btnCurrent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCurrent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCurrent.Image = global::EmlakKayıt.Properties.Resources.safe;
            this.btnCurrent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurrent.Location = new System.Drawing.Point(13, 368);
            this.btnCurrent.Name = "btnCurrent";
            this.btnCurrent.Size = new System.Drawing.Size(161, 52);
            this.btnCurrent.TabIndex = 3;
            this.btnCurrent.Text = "KASA";
            this.btnCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCurrent.UseVisualStyleBackColor = true;
            this.btnCurrent.Click += new System.EventHandler(this.BtnCurrent_Click);
            // 
            // btnCasa
            // 
            this.btnCasa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCasa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCasa.Image = global::EmlakKayıt.Properties.Resources.Cari;
            this.btnCasa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCasa.Location = new System.Drawing.Point(12, 293);
            this.btnCasa.Name = "btnCasa";
            this.btnCasa.Size = new System.Drawing.Size(161, 52);
            this.btnCasa.TabIndex = 2;
            this.btnCasa.Text = "Cari Tablo";
            this.btnCasa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCasa.UseVisualStyleBackColor = true;
            this.btnCasa.Click += new System.EventHandler(this.BtnCasa_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Image = global::EmlakKayıt.Properties.Resources.House;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(13, 221);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 52);
            this.button4.TabIndex = 3;
            this.button4.Text = "Stok takip";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Image = global::EmlakKayıt.Properties.Resources.People;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(13, 446);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "Müşteriler";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = global::EmlakKayıt.Properties.Resources.Home;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(13, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ana Sayfa";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 814);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticari Takip";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.FlatPanel.ResumeLayout(false);
            this.FlatPanel.PerformLayout();
            this.CustomerPanel.ResumeLayout(false);
            this.CustomerPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.pnlAna.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Panel FlatPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel WeatherPanel;
        private System.Windows.Forms.Panel CustomerPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel ClockPanel;
        private System.Windows.Forms.Panel FinancePanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlAna;
        private System.Windows.Forms.Button btnCurrent;
        private System.Windows.Forms.Button btnCasa;
    }
}

