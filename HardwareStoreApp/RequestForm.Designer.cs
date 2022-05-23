
namespace HardwareStoreApp
{
    partial class RequestForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxQuantityRequest = new System.Windows.Forms.NumericUpDown();
            this.btRemove = new System.Windows.Forms.Button();
            this.lwProducts = new System.Windows.Forms.ListView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnAddProductRefill = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.brnConfirmRequest = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbRequested = new System.Windows.Forms.ListBox();
            this.lbSold = new System.Windows.Forms.ListBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxQuantityRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Product Request";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btnMenu.Location = new System.Drawing.Point(15, 640);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(146, 50);
            this.btnMenu.TabIndex = 12;
            this.btnMenu.Text = "Back To Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.groupBox2.Controls.Add(this.lblProduct);
            this.groupBox2.Controls.Add(this.lblQuantity);
            this.groupBox2.Controls.Add(this.lbSold);
            this.groupBox2.Controls.Add(this.lbRequested);
            this.groupBox2.Controls.Add(this.tbxQuantityRequest);
            this.groupBox2.Controls.Add(this.btRemove);
            this.groupBox2.Controls.Add(this.lwProducts);
            this.groupBox2.Controls.Add(this.tbSearch);
            this.groupBox2.Controls.Add(this.btnAddProductRefill);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblSearch);
            this.groupBox2.Controls.Add(this.brnConfirmRequest);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.groupBox2.Location = new System.Drawing.Point(129, 67);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Size = new System.Drawing.Size(956, 563);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Make a request";
            // 
            // tbxQuantityRequest
            // 
            this.tbxQuantityRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.tbxQuantityRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.tbxQuantityRequest.Location = new System.Drawing.Point(549, 72);
            this.tbxQuantityRequest.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbxQuantityRequest.Name = "tbxQuantityRequest";
            this.tbxQuantityRequest.Size = new System.Drawing.Size(268, 25);
            this.tbxQuantityRequest.TabIndex = 67;
            this.tbxQuantityRequest.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btRemove
            // 
            this.btRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btRemove.Location = new System.Drawing.Point(826, 330);
            this.btRemove.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(118, 49);
            this.btRemove.TabIndex = 66;
            this.btRemove.Text = "Remove selected";
            this.btRemove.UseVisualStyleBackColor = false;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            this.btRemove.MouseHover += new System.EventHandler(this.btRemove_MouseHover);
            // 
            // lwProducts
            // 
            this.lwProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.lwProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.lwProducts.HideSelection = false;
            this.lwProducts.Location = new System.Drawing.Point(36, 105);
            this.lwProducts.Name = "lwProducts";
            this.lwProducts.Size = new System.Drawing.Size(781, 163);
            this.lwProducts.TabIndex = 62;
            this.lwProducts.UseCompatibleStateImageBehavior = false;
            this.lwProducts.View = System.Windows.Forms.View.List;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.tbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.tbSearch.Location = new System.Drawing.Point(36, 72);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(483, 25);
            this.tbSearch.TabIndex = 23;
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // btnAddProductRefill
            // 
            this.btnAddProductRefill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnAddProductRefill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btnAddProductRefill.Location = new System.Drawing.Point(826, 105);
            this.btnAddProductRefill.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAddProductRefill.Name = "btnAddProductRefill";
            this.btnAddProductRefill.Size = new System.Drawing.Size(118, 52);
            this.btnAddProductRefill.TabIndex = 22;
            this.btnAddProductRefill.Text = "Add Product";
            this.btnAddProductRefill.UseVisualStyleBackColor = false;
            this.btnAddProductRefill.Click += new System.EventHandler(this.btnAddProductRefill_Click);
            this.btnAddProductRefill.MouseHover += new System.EventHandler(this.btnAddProductRefill_MouseHover);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(546, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Quantity";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(33, 46);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(139, 17);
            this.lblSearch.TabIndex = 15;
            this.lblSearch.Text = "Search for a product";
            // 
            // brnConfirmRequest
            // 
            this.brnConfirmRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.brnConfirmRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.brnConfirmRequest.Location = new System.Drawing.Point(826, 491);
            this.brnConfirmRequest.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.brnConfirmRequest.Name = "brnConfirmRequest";
            this.brnConfirmRequest.Size = new System.Drawing.Size(118, 47);
            this.brnConfirmRequest.TabIndex = 16;
            this.brnConfirmRequest.Text = "Confirm Request";
            this.brnConfirmRequest.UseVisualStyleBackColor = false;
            this.brnConfirmRequest.Click += new System.EventHandler(this.brnConfirmRequest_Click);
            this.brnConfirmRequest.MouseHover += new System.EventHandler(this.brnConfirmRequest_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HardwareStoreApp.Properties.Resources.Logo_no_PC;
            this.pictureBox1.Location = new System.Drawing.Point(1019, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lbRequested
            // 
            this.lbRequested.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.lbRequested.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.lbRequested.FormattingEnabled = true;
            this.lbRequested.ItemHeight = 17;
            this.lbRequested.Location = new System.Drawing.Point(91, 330);
            this.lbRequested.Name = "lbRequested";
            this.lbRequested.Size = new System.Drawing.Size(726, 208);
            this.lbRequested.TabIndex = 70;
            this.lbRequested.SelectedIndexChanged += new System.EventHandler(this.SyncLists);
            // 
            // lbSold
            // 
            this.lbSold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.lbSold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.lbSold.FormattingEnabled = true;
            this.lbSold.ItemHeight = 17;
            this.lbSold.Location = new System.Drawing.Point(36, 330);
            this.lbSold.Name = "lbSold";
            this.lbSold.Size = new System.Drawing.Size(59, 208);
            this.lbSold.TabIndex = 71;
            this.lbSold.SelectedIndexChanged += new System.EventHandler(this.SyncLists);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(33, 310);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(69, 17);
            this.lblQuantity.TabIndex = 72;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(114, 310);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(71, 17);
            this.lblProduct.TabIndex = 73;
            this.lblProduct.Text = "Products:";
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1207, 704);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RequestForm";
            this.Text = "RequestForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxQuantityRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddProductRefill;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button brnConfirmRequest;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ListView lwProducts;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.NumericUpDown tbxQuantityRequest;
        private System.Windows.Forms.ListBox lbSold;
        private System.Windows.Forms.ListBox lbRequested;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblQuantity;
    }
}