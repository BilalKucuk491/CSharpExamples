namespace AracKiralama
{
    partial class frmAraclar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAraclar));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAracNoBK = new System.Windows.Forms.TextBox();
            this.txtMarkaBK = new System.Windows.Forms.TextBox();
            this.txtModelBK = new System.Windows.Forms.TextBox();
            this.txtPlakaBK = new System.Windows.Forms.TextBox();
            this.dGridAraclarBK = new System.Windows.Forms.DataGridView();
            this.btnKayitEkleBK = new System.Windows.Forms.Button();
            this.btnKayitGuncelleBK = new System.Windows.Forms.Button();
            this.btnKayitSilBK = new System.Windows.Forms.Button();
            this.txtBoxMarkaSearchBK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGridAraclarBK)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Plaka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Marka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Araç No";
            // 
            // txtAracNoBK
            // 
            this.txtAracNoBK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAracNoBK.Location = new System.Drawing.Point(117, 29);
            this.txtAracNoBK.Name = "txtAracNoBK";
            this.txtAracNoBK.Size = new System.Drawing.Size(152, 30);
            this.txtAracNoBK.TabIndex = 3;
            // 
            // txtMarkaBK
            // 
            this.txtMarkaBK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMarkaBK.Location = new System.Drawing.Point(117, 77);
            this.txtMarkaBK.Name = "txtMarkaBK";
            this.txtMarkaBK.Size = new System.Drawing.Size(239, 30);
            this.txtMarkaBK.TabIndex = 3;
            // 
            // txtModelBK
            // 
            this.txtModelBK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtModelBK.Location = new System.Drawing.Point(117, 128);
            this.txtModelBK.Name = "txtModelBK";
            this.txtModelBK.Size = new System.Drawing.Size(239, 30);
            this.txtModelBK.TabIndex = 3;
            // 
            // txtPlakaBK
            // 
            this.txtPlakaBK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlakaBK.Location = new System.Drawing.Point(117, 168);
            this.txtPlakaBK.Name = "txtPlakaBK";
            this.txtPlakaBK.Size = new System.Drawing.Size(152, 30);
            this.txtPlakaBK.TabIndex = 3;
            // 
            // dGridAraclarBK
            // 
            this.dGridAraclarBK.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dGridAraclarBK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridAraclarBK.Location = new System.Drawing.Point(22, 310);
            this.dGridAraclarBK.Name = "dGridAraclarBK";
            this.dGridAraclarBK.ReadOnly = true;
            this.dGridAraclarBK.RowHeadersWidth = 51;
            this.dGridAraclarBK.RowTemplate.Height = 24;
            this.dGridAraclarBK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridAraclarBK.Size = new System.Drawing.Size(1026, 365);
            this.dGridAraclarBK.TabIndex = 4;
            this.dGridAraclarBK.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridAraclar_RowEnter);
            this.dGridAraclarBK.DoubleClick += new System.EventHandler(this.dGridAraclar_DoubleClick);
            // 
            // btnKayitEkleBK
            // 
            this.btnKayitEkleBK.Location = new System.Drawing.Point(117, 215);
            this.btnKayitEkleBK.Name = "btnKayitEkleBK";
            this.btnKayitEkleBK.Size = new System.Drawing.Size(118, 48);
            this.btnKayitEkleBK.TabIndex = 5;
            this.btnKayitEkleBK.Text = "Kayıt Ekle";
            this.btnKayitEkleBK.UseVisualStyleBackColor = true;
            this.btnKayitEkleBK.Click += new System.EventHandler(this.btnKayitEkle_Click);
            // 
            // btnKayitGuncelleBK
            // 
            this.btnKayitGuncelleBK.Location = new System.Drawing.Point(241, 215);
            this.btnKayitGuncelleBK.Name = "btnKayitGuncelleBK";
            this.btnKayitGuncelleBK.Size = new System.Drawing.Size(115, 48);
            this.btnKayitGuncelleBK.TabIndex = 6;
            this.btnKayitGuncelleBK.Text = "Kayıt Güncelle";
            this.btnKayitGuncelleBK.UseVisualStyleBackColor = true;
            this.btnKayitGuncelleBK.Click += new System.EventHandler(this.btnKayitGuncelle_Click);
            // 
            // btnKayitSilBK
            // 
            this.btnKayitSilBK.Location = new System.Drawing.Point(362, 215);
            this.btnKayitSilBK.Name = "btnKayitSilBK";
            this.btnKayitSilBK.Size = new System.Drawing.Size(115, 48);
            this.btnKayitSilBK.TabIndex = 7;
            this.btnKayitSilBK.Text = "Kayıt Sil";
            this.btnKayitSilBK.UseVisualStyleBackColor = true;
            this.btnKayitSilBK.Click += new System.EventHandler(this.btnKayitSil_Click);
            // 
            // txtBoxMarkaSearchBK
            // 
            this.txtBoxMarkaSearchBK.Location = new System.Drawing.Point(117, 270);
            this.txtBoxMarkaSearchBK.Multiline = true;
            this.txtBoxMarkaSearchBK.Name = "txtBoxMarkaSearchBK";
            this.txtBoxMarkaSearchBK.Size = new System.Drawing.Size(931, 34);
            this.txtBoxMarkaSearchBK.TabIndex = 8;
            this.txtBoxMarkaSearchBK.TextChanged += new System.EventHandler(this.txtBoxMarkaSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(22, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Marka";
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblClock.Location = new System.Drawing.Point(819, 13);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(164, 36);
            this.lblClock.TabIndex = 10;
            this.lblClock.Text = "Bilal Küçük";
            // 
            // frmAraclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1076, 697);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxMarkaSearchBK);
            this.Controls.Add(this.btnKayitSilBK);
            this.Controls.Add(this.btnKayitGuncelleBK);
            this.Controls.Add(this.btnKayitEkleBK);
            this.Controls.Add(this.dGridAraclarBK);
            this.Controls.Add(this.txtPlakaBK);
            this.Controls.Add(this.txtModelBK);
            this.Controls.Add(this.txtMarkaBK);
            this.Controls.Add(this.txtAracNoBK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAraclar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araçlar";
            this.Load += new System.EventHandler(this.frmAraclar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridAraclarBK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAracNoBK;
        private System.Windows.Forms.TextBox txtMarkaBK;
        private System.Windows.Forms.TextBox txtModelBK;
        private System.Windows.Forms.TextBox txtPlakaBK;
        private System.Windows.Forms.DataGridView dGridAraclarBK;
        private System.Windows.Forms.Button btnKayitEkleBK;
        private System.Windows.Forms.Button btnKayitGuncelleBK;
        private System.Windows.Forms.Button btnKayitSilBK;
        private System.Windows.Forms.TextBox txtBoxMarkaSearchBK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClock;
    }
}