namespace EmlakKayıt
{
    partial class AddProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chxKDV = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBarcode = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.chxKDV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBarcode);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.quantity);
            this.panel1.Controls.Add(this.txtCategory);
            this.panel1.Controls.Add(this.txtModel);
            this.panel1.Controls.Add(this.txtBrand);
            this.panel1.Controls.Add(this.txtBarcode);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtCode);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 607);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(265, 512);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 44);
            this.button3.TabIndex = 16;
            this.button3.Text = "İPTAL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(85, 512);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 44);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // chxKDV
            // 
            this.chxKDV.AutoSize = true;
            this.chxKDV.Location = new System.Drawing.Point(205, 467);
            this.chxKDV.Name = "chxKDV";
            this.chxKDV.Size = new System.Drawing.Size(67, 17);
            this.chxKDV.TabIndex = 14;
            this.chxKDV.Text = "kdv ekle";
            this.chxKDV.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Adet";
            // 
            // btnBarcode
            // 
            this.btnBarcode.Location = new System.Drawing.Point(351, 224);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(105, 23);
            this.btnBarcode.TabIndex = 12;
            this.btnBarcode.Text = "Barkod oluştur";
            this.btnBarcode.UseVisualStyleBackColor = true;
            this.btnBarcode.Click += new System.EventHandler(this.BtnBarcode_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(37, 436);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(235, 25);
            this.txtPrice.TabIndex = 11;
            this.txtPrice.Text = "Satış fiyatı giriniz";
            this.txtPrice.Enter += new System.EventHandler(this.TxtPrice_Enter);
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.quantity.Location = new System.Drawing.Point(339, 437);
            this.quantity.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(117, 24);
            this.quantity.TabIndex = 10;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(37, 379);
            this.txtCategory.Multiline = true;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(419, 30);
            this.txtCategory.TabIndex = 6;
            this.txtCategory.Text = "Kategori giriniz";
            this.txtCategory.Enter += new System.EventHandler(this.TxtCategory_Enter);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(37, 325);
            this.txtModel.Multiline = true;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(419, 30);
            this.txtModel.TabIndex = 5;
            this.txtModel.Text = "Model adı giriniz";
            this.txtModel.Enter += new System.EventHandler(this.TxtModel_Enter);
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(37, 268);
            this.txtBrand.Multiline = true;
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(419, 30);
            this.txtBrand.TabIndex = 4;
            this.txtBrand.Text = "Marka adı giriniz";
            this.txtBrand.Enter += new System.EventHandler(this.TxtBrand_Enter);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(37, 188);
            this.txtBarcode.Multiline = true;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(419, 30);
            this.txtBarcode.TabIndex = 3;
            this.txtBarcode.Text = "Barkod no giriniz veya okutunuz";
            this.txtBarcode.Enter += new System.EventHandler(this.TxtBarcode_Enter);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(37, 128);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(419, 30);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Ürün adı giriniz";
            this.txtName.Enter += new System.EventHandler(this.TxtName_Enter);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(37, 71);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(419, 30);
            this.txtCode.TabIndex = 1;
            this.txtCode.Text = "Ürün kodu giriniz";
            this.txtCode.Click += new System.EventHandler(this.TxtCode_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 46);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stok Kartı Oluştur";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 639);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox chxKDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBarcode;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}