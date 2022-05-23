namespace HardwareStoreApp
{
    partial class MenuForm
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnToStock = new System.Windows.Forms.Button();
            this.btnToSchedule = new System.Windows.Forms.Button();
            this.btnToEmployeeManager = new System.Windows.Forms.Button();
            this.btnToEmployee = new System.Windows.Forms.Button();
            this.lblEmpInfo = new System.Windows.Forms.Label();
            this.btnStockRequest = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSellProduct = new System.Windows.Forms.Button();
            this.btnToRoleManager = new System.Windows.Forms.Button();
            this.btnRequest = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btnLogOut.Location = new System.Drawing.Point(13, 595);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(150, 37);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnToStock
            // 
            this.btnToStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnToStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btnToStock.Location = new System.Drawing.Point(200, 150);
            this.btnToStock.Margin = new System.Windows.Forms.Padding(4);
            this.btnToStock.Name = "btnToStock";
            this.btnToStock.Size = new System.Drawing.Size(294, 51);
            this.btnToStock.TabIndex = 1;
            this.btnToStock.Text = "Stock";
            this.btnToStock.UseVisualStyleBackColor = false;
            this.btnToStock.Click += new System.EventHandler(this.btnToStock_Click);
            // 
            // btnToSchedule
            // 
            this.btnToSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnToSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btnToSchedule.Location = new System.Drawing.Point(200, 91);
            this.btnToSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.btnToSchedule.Name = "btnToSchedule";
            this.btnToSchedule.Size = new System.Drawing.Size(294, 51);
            this.btnToSchedule.TabIndex = 2;
            this.btnToSchedule.Text = "Schedule";
            this.btnToSchedule.UseVisualStyleBackColor = false;
            this.btnToSchedule.Click += new System.EventHandler(this.btnToSchedule_Click);
            // 
            // btnToEmployeeManager
            // 
            this.btnToEmployeeManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnToEmployeeManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btnToEmployeeManager.Location = new System.Drawing.Point(200, 209);
            this.btnToEmployeeManager.Margin = new System.Windows.Forms.Padding(4);
            this.btnToEmployeeManager.Name = "btnToEmployeeManager";
            this.btnToEmployeeManager.Size = new System.Drawing.Size(294, 51);
            this.btnToEmployeeManager.TabIndex = 3;
            this.btnToEmployeeManager.Text = "Employee Manager";
            this.btnToEmployeeManager.UseVisualStyleBackColor = false;
            this.btnToEmployeeManager.Click += new System.EventHandler(this.btnToEmployeeManager_Click);
            // 
            // btnToEmployee
            // 
            this.btnToEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnToEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btnToEmployee.Location = new System.Drawing.Point(200, 30);
            this.btnToEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnToEmployee.Name = "btnToEmployee";
            this.btnToEmployee.Size = new System.Drawing.Size(294, 53);
            this.btnToEmployee.TabIndex = 4;
            this.btnToEmployee.Text = "My Info";
            this.btnToEmployee.UseVisualStyleBackColor = false;
            this.btnToEmployee.Click += new System.EventHandler(this.btnToEmployee_Click);
            // 
            // lblEmpInfo
            // 
            this.lblEmpInfo.AutoSize = true;
            this.lblEmpInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblEmpInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.lblEmpInfo.Location = new System.Drawing.Point(24, 13);
            this.lblEmpInfo.Name = "lblEmpInfo";
            this.lblEmpInfo.Size = new System.Drawing.Size(57, 22);
            this.lblEmpInfo.TabIndex = 5;
            this.lblEmpInfo.Text = "Menu";
            // 
            // btnStockRequest
            // 
            this.btnStockRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnStockRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btnStockRequest.Location = new System.Drawing.Point(200, 327);
            this.btnStockRequest.Margin = new System.Windows.Forms.Padding(4);
            this.btnStockRequest.Name = "btnStockRequest";
            this.btnStockRequest.Size = new System.Drawing.Size(294, 51);
            this.btnStockRequest.TabIndex = 6;
            this.btnStockRequest.Text = "Department";
            this.btnStockRequest.UseVisualStyleBackColor = false;
            this.btnStockRequest.Click += new System.EventHandler(this.btnStockRequest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.groupBox1.Controls.Add(this.btSellProduct);
            this.groupBox1.Controls.Add(this.btnToRoleManager);
            this.groupBox1.Controls.Add(this.btnRequest);
            this.groupBox1.Controls.Add(this.btnStockRequest);
            this.groupBox1.Controls.Add(this.btnToEmployee);
            this.groupBox1.Controls.Add(this.btnToSchedule);
            this.groupBox1.Controls.Add(this.btnToEmployeeManager);
            this.groupBox1.Controls.Add(this.btnToStock);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.groupBox1.Location = new System.Drawing.Point(288, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(681, 524);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btSellProduct
            // 
            this.btSellProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btSellProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btSellProduct.Location = new System.Drawing.Point(200, 445);
            this.btSellProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btSellProduct.Name = "btSellProduct";
            this.btSellProduct.Size = new System.Drawing.Size(294, 51);
            this.btSellProduct.TabIndex = 11;
            this.btSellProduct.Text = "Sell Products";
            this.btSellProduct.UseVisualStyleBackColor = false;
            this.btSellProduct.Click += new System.EventHandler(this.btSellProduct_Click);
            // 
            // btnToRoleManager
            // 
            this.btnToRoleManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnToRoleManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btnToRoleManager.Location = new System.Drawing.Point(200, 268);
            this.btnToRoleManager.Margin = new System.Windows.Forms.Padding(4);
            this.btnToRoleManager.Name = "btnToRoleManager";
            this.btnToRoleManager.Size = new System.Drawing.Size(294, 51);
            this.btnToRoleManager.TabIndex = 10;
            this.btnToRoleManager.Text = "Role Manager";
            this.btnToRoleManager.UseVisualStyleBackColor = false;
            this.btnToRoleManager.Click += new System.EventHandler(this.btnToRoleManager_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btnRequest.Location = new System.Drawing.Point(200, 386);
            this.btnRequest.Margin = new System.Windows.Forms.Padding(4);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(294, 51);
            this.btnRequest.TabIndex = 9;
            this.btnRequest.Text = "Stock Request";
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HardwareStoreApp.Properties.Resources.Logo_no_PC;
            this.pictureBox1.Location = new System.Drawing.Point(1050, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1248, 645);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEmpInfo);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuForm";
            this.Text = "Media Bazaar";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnToStock;
        private System.Windows.Forms.Button btnToSchedule;
        private System.Windows.Forms.Button btnToEmployeeManager;
        private System.Windows.Forms.Button btnToEmployee;
        private System.Windows.Forms.Label lblEmpInfo;
        private System.Windows.Forms.Button btnStockRequest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnToRoleManager;
        private System.Windows.Forms.Button btSellProduct;
    }
}