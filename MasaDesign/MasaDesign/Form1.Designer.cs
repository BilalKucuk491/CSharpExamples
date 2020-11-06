namespace MasaDesign
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
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolSbtnFont = new System.Windows.Forms.ToolStripButton();
            this.toolSbtnMasaColor = new System.Windows.Forms.ToolStripButton();
            this.toolSbtnBackColor = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMGrey = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMBlack = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMSilver = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMBackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSbtnBackColor,
            this.toolSbtnFont,
            this.toolSbtnMasaColor,
            this.toolStripDropDownButton1});
            this.toolStrip2.Location = new System.Drawing.Point(9, 9);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(617, 132);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Merhaba";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 152);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // toolSbtnFont
            // 
            this.toolSbtnFont.Image = global::MasaDesign.Properties.Resources.iconfinder_ic_format_color_text_48px_352385;
            this.toolSbtnFont.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolSbtnFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSbtnFont.Name = "toolSbtnFont";
            this.toolSbtnFont.Size = new System.Drawing.Size(193, 129);
            this.toolSbtnFont.Text = "Yazı Tipi";
            this.toolSbtnFont.Click += new System.EventHandler(this.toolSbtnFont_Click);
            // 
            // toolSbtnMasaColor
            // 
            this.toolSbtnMasaColor.Image = global::MasaDesign.Properties.Resources.iconfinder_rectangle_page_home_square_user_interface_app_web_4567740;
            this.toolSbtnMasaColor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolSbtnMasaColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSbtnMasaColor.Name = "toolSbtnMasaColor";
            this.toolSbtnMasaColor.Size = new System.Drawing.Size(209, 129);
            this.toolSbtnMasaColor.Text = "Masa Renk";
            this.toolSbtnMasaColor.Click += new System.EventHandler(this.toolSbtnMasaColor_Click);
            // 
            // toolSbtnBackColor
            // 
            this.toolSbtnBackColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMGrey,
            this.toolStripMBlack,
            this.toolStripMSilver,
            this.toolStripMBackColor});
            this.toolSbtnBackColor.Image = global::MasaDesign.Properties.Resources.text;
            this.toolSbtnBackColor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolSbtnBackColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSbtnBackColor.Name = "toolSbtnBackColor";
            this.toolSbtnBackColor.Size = new System.Drawing.Size(139, 129);
            this.toolSbtnBackColor.Text = "Tema";
            this.toolSbtnBackColor.Click += new System.EventHandler(this.toolSbtnBackColor_Click_1);
            // 
            // toolStripMGrey
            // 
            this.toolStripMGrey.Name = "toolStripMGrey";
            this.toolStripMGrey.Size = new System.Drawing.Size(224, 26);
            this.toolStripMGrey.Text = "Gri Arkaplan";
            this.toolStripMGrey.Click += new System.EventHandler(this.toolStripMGrey_Click);
            // 
            // toolStripMBlack
            // 
            this.toolStripMBlack.Name = "toolStripMBlack";
            this.toolStripMBlack.Size = new System.Drawing.Size(224, 26);
            this.toolStripMBlack.Text = "Siyah Arkaplan";
            this.toolStripMBlack.Click += new System.EventHandler(this.toolStripMBlack_Click);
            // 
            // toolStripMSilver
            // 
            this.toolStripMSilver.Name = "toolStripMSilver";
            this.toolStripMSilver.Size = new System.Drawing.Size(224, 26);
            this.toolStripMSilver.Text = "Gümüş Arkaplan";
            this.toolStripMSilver.Click += new System.EventHandler(this.toolStripMSilver_Click);
            // 
            // toolStripMBackColor
            // 
            this.toolStripMBackColor.Name = "toolStripMBackColor";
            this.toolStripMBackColor.Size = new System.Drawing.Size(224, 26);
            this.toolStripMBackColor.Text = "Arkaplan Renk";
            this.toolStripMBackColor.Click += new System.EventHandler(this.toolStripMBackColor_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 129);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 730);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolSbtnFont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolSbtnMasaColor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripDropDownButton toolSbtnBackColor;
        private System.Windows.Forms.ToolStripMenuItem toolStripMGrey;
        private System.Windows.Forms.ToolStripMenuItem toolStripMBlack;
        private System.Windows.Forms.ToolStripMenuItem toolStripMSilver;
        private System.Windows.Forms.ToolStripMenuItem toolStripMBackColor;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
    }
}

