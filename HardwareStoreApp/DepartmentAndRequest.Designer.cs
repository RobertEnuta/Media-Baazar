
namespace HardwareStoreApp
{
    partial class DepartmentAndRequest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbManagerID = new System.Windows.Forms.ComboBox();
            this.btnDisplayDepartments = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDepartment = new System.Windows.Forms.ListBox();
            this.btnAddNewDepartment = new System.Windows.Forms.Button();
            this.tbxDescriptionDepart = new System.Windows.Forms.TextBox();
            this.tbxNameOfDepartment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.groupBox1.Controls.Add(this.cbManagerID);
            this.groupBox1.Controls.Add(this.btnDisplayDepartments);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbDepartment);
            this.groupBox1.Controls.Add(this.btnAddNewDepartment);
            this.groupBox1.Controls.Add(this.tbxDescriptionDepart);
            this.groupBox1.Controls.Add(this.tbxNameOfDepartment);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.groupBox1.Location = new System.Drawing.Point(315, 165);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(675, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Department Managment";
            // 
            // cbManagerID
            // 
            this.cbManagerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.cbManagerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.cbManagerID.FormattingEnabled = true;
            this.cbManagerID.Location = new System.Drawing.Point(51, 95);
            this.cbManagerID.Margin = new System.Windows.Forms.Padding(4);
            this.cbManagerID.Name = "cbManagerID";
            this.cbManagerID.Size = new System.Drawing.Size(180, 25);
            this.cbManagerID.TabIndex = 16;
            // 
            // btnDisplayDepartments
            // 
            this.btnDisplayDepartments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnDisplayDepartments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btnDisplayDepartments.Location = new System.Drawing.Point(384, 289);
            this.btnDisplayDepartments.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplayDepartments.Name = "btnDisplayDepartments";
            this.btnDisplayDepartments.Size = new System.Drawing.Size(180, 30);
            this.btnDisplayDepartments.TabIndex = 14;
            this.btnDisplayDepartments.Text = "Display Departments";
            this.btnDisplayDepartments.UseVisualStyleBackColor = false;
            this.btnDisplayDepartments.Click += new System.EventHandler(this.btnDisplayDepartments_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Department:";
            // 
            // lbDepartment
            // 
            this.lbDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.lbDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.lbDepartment.FormattingEnabled = true;
            this.lbDepartment.ItemHeight = 17;
            this.lbDepartment.Location = new System.Drawing.Point(321, 55);
            this.lbDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(316, 225);
            this.lbDepartment.TabIndex = 12;
            // 
            // btnAddNewDepartment
            // 
            this.btnAddNewDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnAddNewDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btnAddNewDepartment.Location = new System.Drawing.Point(52, 285);
            this.btnAddNewDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewDepartment.Name = "btnAddNewDepartment";
            this.btnAddNewDepartment.Size = new System.Drawing.Size(180, 30);
            this.btnAddNewDepartment.TabIndex = 11;
            this.btnAddNewDepartment.Text = "Add New Department";
            this.btnAddNewDepartment.UseVisualStyleBackColor = false;
            this.btnAddNewDepartment.Click += new System.EventHandler(this.btnAddNewDepartment_Click_1);
            // 
            // tbxDescriptionDepart
            // 
            this.tbxDescriptionDepart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.tbxDescriptionDepart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.tbxDescriptionDepart.Location = new System.Drawing.Point(51, 195);
            this.tbxDescriptionDepart.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDescriptionDepart.Name = "tbxDescriptionDepart";
            this.tbxDescriptionDepart.Size = new System.Drawing.Size(180, 25);
            this.tbxDescriptionDepart.TabIndex = 10;
            // 
            // tbxNameOfDepartment
            // 
            this.tbxNameOfDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.tbxNameOfDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.tbxNameOfDepartment.Location = new System.Drawing.Point(51, 145);
            this.tbxNameOfDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNameOfDepartment.Name = "tbxNameOfDepartment";
            this.tbxNameOfDepartment.Size = new System.Drawing.Size(180, 25);
            this.tbxNameOfDepartment.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Manager ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name of Department";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btnMenu.Location = new System.Drawing.Point(19, 594);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(136, 48);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Back To Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.label9.Location = new System.Drawing.Point(15, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "Department";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HardwareStoreApp.Properties.Resources.Logo_no_PC;
            this.pictureBox1.Location = new System.Drawing.Point(1118, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // DepartmentAndRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1320, 655);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DepartmentAndRequest";
            this.Text = "DepartmentAndRequest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDisplayDepartments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbDepartment;
        private System.Windows.Forms.Button btnAddNewDepartment;
        private System.Windows.Forms.TextBox tbxDescriptionDepart;
        private System.Windows.Forms.TextBox tbxNameOfDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenu;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbManagerID;
    }
}