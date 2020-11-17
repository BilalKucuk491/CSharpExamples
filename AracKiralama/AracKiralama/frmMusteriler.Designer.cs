namespace AracKiralama
{
    partial class frmMusteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriler));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxTCSearchBK = new System.Windows.Forms.TextBox();
            this.btnKayitSilBK = new System.Windows.Forms.Button();
            this.btnKayitGuncelleBK = new System.Windows.Forms.Button();
            this.btnKayitEkleBK = new System.Windows.Forms.Button();
            this.dGridMusterilerBK = new System.Windows.Forms.DataGridView();
            this.txtPhoneBK = new System.Windows.Forms.TextBox();
            this.txtAdressBK = new System.Windows.Forms.TextBox();
            this.txtSoyadBK = new System.Windows.Forms.TextBox();
            this.txtAdBK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTCBK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMKodBK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGridMusterilerBK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(22, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ad";
            // 
            // txtBoxTCSearchBK
            // 
            this.txtBoxTCSearchBK.Location = new System.Drawing.Point(120, 316);
            this.txtBoxTCSearchBK.Multiline = true;
            this.txtBoxTCSearchBK.Name = "txtBoxTCSearchBK";
            this.txtBoxTCSearchBK.Size = new System.Drawing.Size(931, 34);
            this.txtBoxTCSearchBK.TabIndex = 22;
            this.txtBoxTCSearchBK.TextChanged += new System.EventHandler(this.txtBoxTCSearchBK_TextChanged);
            // 
            // btnKayitSilBK
            // 
            this.btnKayitSilBK.Location = new System.Drawing.Point(366, 262);
            this.btnKayitSilBK.Name = "btnKayitSilBK";
            this.btnKayitSilBK.Size = new System.Drawing.Size(115, 48);
            this.btnKayitSilBK.TabIndex = 21;
            this.btnKayitSilBK.Text = "Kayıt Sil";
            this.btnKayitSilBK.UseVisualStyleBackColor = true;
            this.btnKayitSilBK.Click += new System.EventHandler(this.btnKayitSilBK_Click);
            // 
            // btnKayitGuncelleBK
            // 
            this.btnKayitGuncelleBK.Location = new System.Drawing.Point(245, 262);
            this.btnKayitGuncelleBK.Name = "btnKayitGuncelleBK";
            this.btnKayitGuncelleBK.Size = new System.Drawing.Size(115, 48);
            this.btnKayitGuncelleBK.TabIndex = 20;
            this.btnKayitGuncelleBK.Text = "Kayıt Güncelle";
            this.btnKayitGuncelleBK.UseVisualStyleBackColor = true;
            this.btnKayitGuncelleBK.Click += new System.EventHandler(this.btnKayitGuncelleBK_Click);
            // 
            // btnKayitEkleBK
            // 
            this.btnKayitEkleBK.Location = new System.Drawing.Point(121, 262);
            this.btnKayitEkleBK.Name = "btnKayitEkleBK";
            this.btnKayitEkleBK.Size = new System.Drawing.Size(118, 48);
            this.btnKayitEkleBK.TabIndex = 19;
            this.btnKayitEkleBK.Text = "Kayıt Ekle";
            this.btnKayitEkleBK.UseVisualStyleBackColor = true;
            this.btnKayitEkleBK.Click += new System.EventHandler(this.btnKayitEkleBK_Click);
            // 
            // dGridMusterilerBK
            // 
            this.dGridMusterilerBK.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dGridMusterilerBK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridMusterilerBK.Location = new System.Drawing.Point(25, 356);
            this.dGridMusterilerBK.Name = "dGridMusterilerBK";
            this.dGridMusterilerBK.ReadOnly = true;
            this.dGridMusterilerBK.RowHeadersWidth = 51;
            this.dGridMusterilerBK.RowTemplate.Height = 24;
            this.dGridMusterilerBK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridMusterilerBK.Size = new System.Drawing.Size(1026, 315);
            this.dGridMusterilerBK.TabIndex = 18;
            this.dGridMusterilerBK.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridMusterilerBK_RowEnter);
            this.dGridMusterilerBK.DoubleClick += new System.EventHandler(this.dGridMusterilerBK_DoubleClick);
            // 
            // txtPhoneBK
            // 
            this.txtPhoneBK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPhoneBK.Location = new System.Drawing.Point(120, 227);
            this.txtPhoneBK.Name = "txtPhoneBK";
            this.txtPhoneBK.Size = new System.Drawing.Size(152, 30);
            this.txtPhoneBK.TabIndex = 14;
            // 
            // txtAdressBK
            // 
            this.txtAdressBK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdressBK.Location = new System.Drawing.Point(120, 187);
            this.txtAdressBK.Name = "txtAdressBK";
            this.txtAdressBK.Size = new System.Drawing.Size(239, 30);
            this.txtAdressBK.TabIndex = 15;
            // 
            // txtSoyadBK
            // 
            this.txtSoyadBK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyadBK.Location = new System.Drawing.Point(119, 149);
            this.txtSoyadBK.Name = "txtSoyadBK";
            this.txtSoyadBK.Size = new System.Drawing.Size(239, 30);
            this.txtSoyadBK.TabIndex = 16;
            // 
            // txtAdBK
            // 
            this.txtAdBK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdBK.Location = new System.Drawing.Point(120, 113);
            this.txtAdBK.Name = "txtAdBK";
            this.txtAdBK.Size = new System.Drawing.Size(152, 30);
            this.txtAdBK.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Adres";
            // 
            // txtTCBK
            // 
            this.txtTCBK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTCBK.Location = new System.Drawing.Point(119, 77);
            this.txtTCBK.Name = "txtTCBK";
            this.txtTCBK.Size = new System.Drawing.Size(239, 30);
            this.txtTCBK.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "TcNo";
            // 
            // txtMKodBK
            // 
            this.txtMKodBK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMKodBK.Location = new System.Drawing.Point(120, 43);
            this.txtMKodBK.Name = "txtMKodBK";
            this.txtMKodBK.Size = new System.Drawing.Size(152, 30);
            this.txtMKodBK.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "MKod";
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblClock.Location = new System.Drawing.Point(819, 13);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(164, 36);
            this.lblClock.TabIndex = 28;
            this.lblClock.Text = "Bilal Küçük";
            // 
            // frmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1076, 697);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.txtMKodBK);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTCBK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxTCSearchBK);
            this.Controls.Add(this.btnKayitSilBK);
            this.Controls.Add(this.btnKayitGuncelleBK);
            this.Controls.Add(this.btnKayitEkleBK);
            this.Controls.Add(this.dGridMusterilerBK);
            this.Controls.Add(this.txtPhoneBK);
            this.Controls.Add(this.txtAdressBK);
            this.Controls.Add(this.txtSoyadBK);
            this.Controls.Add(this.txtAdBK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMusteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.frmMusteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridMusterilerBK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxTCSearchBK;
        private System.Windows.Forms.Button btnKayitSilBK;
        private System.Windows.Forms.Button btnKayitGuncelleBK;
        private System.Windows.Forms.Button btnKayitEkleBK;
        private System.Windows.Forms.DataGridView dGridMusterilerBK;
        private System.Windows.Forms.TextBox txtPhoneBK;
        private System.Windows.Forms.TextBox txtAdressBK;
        private System.Windows.Forms.TextBox txtSoyadBK;
        private System.Windows.Forms.TextBox txtAdBK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTCBK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMKodBK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblClock;
    }
}