
namespace HardwareStoreApp
{
    partial class ProductsForm
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
            this.lwAllProducts = new System.Windows.Forms.ListView();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btAddRemove = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.cbStockCategory = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStockSearch = new System.Windows.Forms.TextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btHideUnavailable = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
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
            this.groupBox2.Controls.Add(this.btHideUnavailable);
            this.groupBox2.Controls.Add(this.lwAllProducts);
            this.groupBox2.Controls.Add(this.btUpdate);
            this.groupBox2.Controls.Add(this.btAddRemove);
            this.groupBox2.Controls.Add(this.btnShowAll);
            this.groupBox2.Controls.Add(this.cbStockCategory);
            this.groupBox2.Controls.Add(this.lblDepartment);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbStockSearch);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.groupBox2.Location = new System.Drawing.Point(130, 69);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.groupBox2.Size = new System.Drawing.Size(958, 616);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock";
            // 
            // lwAllProducts
            // 
            this.lwAllProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.lwAllProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.lwAllProducts.HideSelection = false;
            this.lwAllProducts.Location = new System.Drawing.Point(46, 143);
            this.lwAllProducts.Name = "lwAllProducts";
            this.lwAllProducts.Size = new System.Drawing.Size(869, 361);
            this.lwAllProducts.TabIndex = 61;
            this.lwAllProducts.UseCompatibleStateImageBehavior = false;
            this.lwAllProducts.View = System.Windows.Forms.View.List;
            this.lwAllProducts.MouseHover += new System.EventHandler(this.lwAllProducts_MouseHover);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btUpdate.Location = new System.Drawing.Point(722, 36);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(166, 77);
            this.btUpdate.TabIndex = 60;
            this.btUpdate.Text = "Update Products";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            this.btUpdate.MouseHover += new System.EventHandler(this.btUpdate_MouseHover);
            // 
            // btAddRemove
            // 
            this.btAddRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btAddRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btAddRemove.Location = new System.Drawing.Point(464, 36);
            this.btAddRemove.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btAddRemove.Name = "btAddRemove";
            this.btAddRemove.Size = new System.Drawing.Size(174, 77);
            this.btAddRemove.TabIndex = 50;
            this.btAddRemove.Text = "Add or Remove Products";
            this.btAddRemove.UseVisualStyleBackColor = false;
            this.btAddRemove.Click += new System.EventHandler(this.btAddRemove_Click);
            this.btAddRemove.MouseHover += new System.EventHandler(this.btAddRemove_MouseHover);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnShowAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btnShowAll.Location = new System.Drawing.Point(778, 530);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(137, 60);
            this.btnShowAll.TabIndex = 48;
            this.btnShowAll.Text = "Display All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click_1);
            // 
            // cbStockCategory
            // 
            this.cbStockCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.cbStockCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.cbStockCategory.FormattingEnabled = true;
            this.cbStockCategory.Location = new System.Drawing.Point(131, 80);
            this.cbStockCategory.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cbStockCategory.Name = "cbStockCategory";
            this.cbStockCategory.Size = new System.Drawing.Size(296, 25);
            this.cbStockCategory.TabIndex = 33;
            this.cbStockCategory.TextChanged += new System.EventHandler(this.cbStockCategory_SelectedValueChanged);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(28, 83);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(91, 17);
            this.lblDepartment.TabIndex = 32;
            this.lblDepartment.Text = "Department:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 48);
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
            this.tbStockSearch.Location = new System.Drawing.Point(131, 45);
            this.tbStockSearch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbStockSearch.Name = "tbStockSearch";
            this.tbStockSearch.Size = new System.Drawing.Size(296, 25);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 22);
            this.label5.TabIndex = 60;
            this.label5.Text = "Stock";
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
            // btHideUnavailable
            // 
            this.btHideUnavailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btHideUnavailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btHideUnavailable.Location = new System.Drawing.Point(46, 530);
            this.btHideUnavailable.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btHideUnavailable.Name = "btHideUnavailable";
            this.btHideUnavailable.Size = new System.Drawing.Size(137, 60);
            this.btHideUnavailable.TabIndex = 62;
            this.btHideUnavailable.Text = "Hide unavailable ";
            this.btHideUnavailable.UseVisualStyleBackColor = false;
            this.btHideUnavailable.Click += new System.EventHandler(this.btHideUnavailable_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1272, 771);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnToMenu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button btAddRemove;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ComboBox cbStockCategory;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbStockSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.ListView lwAllProducts;
        private System.Windows.Forms.Button btHideUnavailable;
    }
}