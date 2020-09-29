namespace ProductMetroListView
{
    partial class Form1
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
            this.productsListView = new MetroFramework.Controls.MetroListView();
            this.productsLoadBtn = new MetroFramework.Controls.MetroButton();
            this.productID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.producName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitInStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // productsListView
            // 
            this.productsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productID,
            this.producName,
            this.unitPrice,
            this.unitInStock});
            this.productsListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.productsListView.FullRowSelect = true;
            this.productsListView.Location = new System.Drawing.Point(23, 63);
            this.productsListView.Name = "productsListView";
            this.productsListView.OwnerDraw = true;
            this.productsListView.Size = new System.Drawing.Size(754, 333);
            this.productsListView.TabIndex = 0;
            this.productsListView.UseCompatibleStateImageBehavior = false;
            this.productsListView.UseSelectable = true;
            this.productsListView.View = System.Windows.Forms.View.Details;
            // 
            // productsLoadBtn
            // 
            this.productsLoadBtn.Location = new System.Drawing.Point(668, 404);
            this.productsLoadBtn.Name = "productsLoadBtn";
            this.productsLoadBtn.Size = new System.Drawing.Size(109, 33);
            this.productsLoadBtn.TabIndex = 1;
            this.productsLoadBtn.Text = "Ürünleri Yükle";
            this.productsLoadBtn.UseSelectable = true;
            this.productsLoadBtn.Click += new System.EventHandler(this.productsLoadBtn_Click);
            // 
            // productID
            // 
            this.productID.Text = "Ürün ID";
            this.productID.Width = 150;
            // 
            // producName
            // 
            this.producName.Text = "Ürün İsmi";
            this.producName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.producName.Width = 200;
            // 
            // unitPrice
            // 
            this.unitPrice.Text = "Birim Fiyatı";
            this.unitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.unitPrice.Width = 200;
            // 
            // unitInStock
            // 
            this.unitInStock.Text = "Stokta Kalan Adet";
            this.unitInStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.unitInStock.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productsLoadBtn);
            this.Controls.Add(this.productsListView);
            this.Name = "Form1";
            this.Text = "Products";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView productsListView;
        private System.Windows.Forms.ColumnHeader productID;
        private System.Windows.Forms.ColumnHeader producName;
        private System.Windows.Forms.ColumnHeader unitPrice;
        private System.Windows.Forms.ColumnHeader unitInStock;
        private MetroFramework.Controls.MetroButton productsLoadBtn;
    }
}

