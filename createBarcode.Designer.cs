namespace EmlakKayıt
{
    partial class createBarcode
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
            this.txtCountryCode = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtCompanyCode = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblBarcodeNo = new System.Windows.Forms.Label();
            this.picBarcode = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCountryCode
            // 
            this.txtCountryCode.Location = new System.Drawing.Point(15, 21);
            this.txtCountryCode.Name = "txtCountryCode";
            this.txtCountryCode.Size = new System.Drawing.Size(260, 20);
            this.txtCountryCode.TabIndex = 1;
            this.txtCountryCode.Text = "Ülke kodu giriniz";
            this.txtCountryCode.Click += new System.EventHandler(this.TxtCountryCode_Click);
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(15, 109);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(260, 20);
            this.txtProductCode.TabIndex = 3;
            this.txtProductCode.Text = "Ürün kodu giriniz";
            this.txtProductCode.Enter += new System.EventHandler(this.TxtProductCode_Enter);
            // 
            // txtCompanyCode
            // 
            this.txtCompanyCode.Location = new System.Drawing.Point(15, 66);
            this.txtCompanyCode.Name = "txtCompanyCode";
            this.txtCompanyCode.Size = new System.Drawing.Size(260, 20);
            this.txtCompanyCode.TabIndex = 4;
            this.txtCompanyCode.Text = "Firma kodu giriniz";
            this.txtCompanyCode.Enter += new System.EventHandler(this.TxtCompanyCode_Enter);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreate.Location = new System.Drawing.Point(15, 154);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(145, 43);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Oluştur";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.txtCountryCode);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.txtCompanyCode);
            this.panel1.Controls.Add(this.txtProductCode);
            this.panel1.Location = new System.Drawing.Point(388, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 217);
            this.panel1.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Location = new System.Drawing.Point(172, 154);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 43);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBarcode.Location = new System.Drawing.Point(62, 199);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(101, 24);
            this.lblBarcode.TabIndex = 7;
            this.lblBarcode.Text = "Barkod no:";
            // 
            // lblBarcodeNo
            // 
            this.lblBarcodeNo.AutoSize = true;
            this.lblBarcodeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBarcodeNo.Location = new System.Drawing.Point(169, 199);
            this.lblBarcodeNo.Name = "lblBarcodeNo";
            this.lblBarcodeNo.Size = new System.Drawing.Size(150, 24);
            this.lblBarcodeNo.TabIndex = 8;
            this.lblBarcodeNo.Text = "............................";
            // 
            // picBarcode
            // 
            this.picBarcode.Location = new System.Drawing.Point(12, 26);
            this.picBarcode.Name = "picBarcode";
            this.picBarcode.Size = new System.Drawing.Size(370, 128);
            this.picBarcode.TabIndex = 0;
            this.picBarcode.TabStop = false;
            // 
            // createBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 255);
            this.Controls.Add(this.lblBarcodeNo);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picBarcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "createBarcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "createBarcode";
            this.Load += new System.EventHandler(this.CreateBarcode_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBarcode;
        private System.Windows.Forms.TextBox txtCountryCode;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtCompanyCode;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblBarcodeNo;
    }
}