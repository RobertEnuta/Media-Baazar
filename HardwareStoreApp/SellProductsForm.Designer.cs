
namespace HardwareStoreApp
{
    partial class SellProductsForm
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
            this.btnToMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbItemsSelling = new System.Windows.Forms.ListBox();
            this.btRemove = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btSell = new System.Windows.Forms.Button();
            this.nmSell = new System.Windows.Forms.NumericUpDown();
            this.lblSell = new System.Windows.Forms.Label();
            this.allStock = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStockSearch = new System.Windows.Forms.TextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblSellProduct = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbSold = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToMenu
            // 
            this.btnToMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnToMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btnToMenu.Location = new System.Drawing.Point(-386, 711);
            this.btnToMenu.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnToMenu.Name = "btnToMenu";
            this.btnToMenu.Size = new System.Drawing.Size(212, 51);
            this.btnToMenu.TabIndex = 54;
            this.btnToMenu.Text = "Back to menu";
            this.btnToMenu.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-386, -163);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 53;
            this.label1.Text = "All stock";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.groupBox2.Controls.Add(this.lbSold);
            this.groupBox2.Controls.Add(this.lbItemsSelling);
            this.groupBox2.Controls.Add(this.btRemove);
            this.groupBox2.Controls.Add(this.btAdd);
            this.groupBox2.Controls.Add(this.btSell);
            this.groupBox2.Controls.Add(this.nmSell);
            this.groupBox2.Controls.Add(this.lblSell);
            this.groupBox2.Controls.Add(this.allStock);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbStockSearch);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.groupBox2.Location = new System.Drawing.Point(130, 69);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.groupBox2.Size = new System.Drawing.Size(958, 630);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock";
            // 
            // lbItemsSelling
            // 
            this.lbItemsSelling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.lbItemsSelling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.lbItemsSelling.FormattingEnabled = true;
            this.lbItemsSelling.ItemHeight = 17;
            this.lbItemsSelling.Location = new System.Drawing.Point(104, 381);
            this.lbItemsSelling.Name = "lbItemsSelling";
            this.lbItemsSelling.Size = new System.Drawing.Size(814, 191);
            this.lbItemsSelling.TabIndex = 67;
            this.lbItemsSelling.SelectedIndexChanged += new System.EventHandler(this.SyncSelected);
            this.lbItemsSelling.MouseHover += new System.EventHandler(this.lbItemsSelling_MouseHover);
            // 
            // btRemove
            // 
            this.btRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btRemove.Location = new System.Drawing.Point(104, 581);
            this.btRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(136, 38);
            this.btRemove.TabIndex = 65;
            this.btRemove.Text = "Remove Products";
            this.btRemove.UseVisualStyleBackColor = false;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            this.btRemove.MouseHover += new System.EventHandler(this.btRemove_MouseHover);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btAdd.Location = new System.Drawing.Point(796, 292);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(122, 38);
            this.btAdd.TabIndex = 63;
            this.btAdd.Text = "Add Products";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            this.btAdd.MouseHover += new System.EventHandler(this.btAdd_MouseHover);
            // 
            // btSell
            // 
            this.btSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btSell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btSell.Location = new System.Drawing.Point(796, 581);
            this.btSell.Margin = new System.Windows.Forms.Padding(4);
            this.btSell.Name = "btSell";
            this.btSell.Size = new System.Drawing.Size(122, 38);
            this.btSell.TabIndex = 61;
            this.btSell.Text = "Sell Products";
            this.btSell.UseVisualStyleBackColor = false;
            this.btSell.Click += new System.EventHandler(this.btSell_Click);
            this.btSell.MouseHover += new System.EventHandler(this.btSell_MouseHover);
            // 
            // nmSell
            // 
            this.nmSell.Location = new System.Drawing.Point(92, 301);
            this.nmSell.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nmSell.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmSell.Name = "nmSell";
            this.nmSell.Size = new System.Drawing.Size(148, 25);
            this.nmSell.TabIndex = 51;
            this.nmSell.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSell
            // 
            this.lblSell.AutoSize = true;
            this.lblSell.Location = new System.Drawing.Point(46, 303);
            this.lblSell.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(37, 17);
            this.lblSell.TabIndex = 50;
            this.lblSell.Text = "Sell:";
            // 
            // allStock
            // 
            this.allStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.allStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.allStock.FormattingEnabled = true;
            this.allStock.ItemHeight = 17;
            this.allStock.Location = new System.Drawing.Point(49, 80);
            this.allStock.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.allStock.Name = "allStock";
            this.allStock.Size = new System.Drawing.Size(869, 191);
            this.allStock.TabIndex = 49;
            this.allStock.MouseHover += new System.EventHandler(this.allStock_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Search:";
            // 
            // tbStockSearch
            // 
            this.tbStockSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.tbStockSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.tbStockSearch.Location = new System.Drawing.Point(115, 45);
            this.tbStockSearch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbStockSearch.Name = "tbStockSearch";
            this.tbStockSearch.Size = new System.Drawing.Size(724, 25);
            this.tbStockSearch.TabIndex = 23;
            this.tbStockSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbStockSearch_KeyUp);
            this.tbStockSearch.MouseHover += new System.EventHandler(this.tbStockSearch_MouseHover);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btnMenu.Location = new System.Drawing.Point(13, 710);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(136, 48);
            this.btnMenu.TabIndex = 59;
            this.btnMenu.Text = "Back To Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            this.btnMenu.MouseHover += new System.EventHandler(this.btnMenu_MouseHover);
            // 
            // lblSellProduct
            // 
            this.lblSellProduct.AutoSize = true;
            this.lblSellProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.lblSellProduct.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.lblSellProduct.Location = new System.Drawing.Point(13, 13);
            this.lblSellProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSellProduct.Name = "lblSellProduct";
            this.lblSellProduct.Size = new System.Drawing.Size(118, 22);
            this.lblSellProduct.TabIndex = 60;
            this.lblSellProduct.Text = "Sell Products";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HardwareStoreApp.Properties.Resources.Logo_no_PC;
            this.pictureBox2.Location = new System.Drawing.Point(1088, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HardwareStoreApp.Properties.Resources.Logo_no_PC;
            this.pictureBox1.Location = new System.Drawing.Point(1317, -174);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // lbSold
            // 
            this.lbSold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.lbSold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.lbSold.FormattingEnabled = true;
            this.lbSold.ItemHeight = 17;
            this.lbSold.Location = new System.Drawing.Point(49, 381);
            this.lbSold.Name = "lbSold";
            this.lbSold.Size = new System.Drawing.Size(61, 191);
            this.lbSold.TabIndex = 68;
            // 
            // SellProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1272, 771);
            this.Controls.Add(this.lblSellProduct);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnToMenu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SellProductsForm";
            this.Text = "ProductsForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnToMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox allStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbStockSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblSellProduct;
        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btSell;
        private System.Windows.Forms.NumericUpDown nmSell;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.ListBox lbItemsSelling;
        private System.Windows.Forms.ListBox lbSold;
    }
}