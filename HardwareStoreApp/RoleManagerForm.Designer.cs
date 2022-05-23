namespace HardwareStoreApp
{
    partial class RoleManagerForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.dudAcessLevel = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRoleName = new System.Windows.Forms.TextBox();
            this.lbRoleDisplay = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.btnUpdateRole = new System.Windows.Forms.Button();
            this.dudAcessLevelUp = new System.Windows.Forms.DomainUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbRoleNameUp = new System.Windows.Forms.TextBox();
            this.btnToMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbAdd.SuspendLayout();
            this.gbEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HardwareStoreApp.Properties.Resources.Logo_no_PC;
            this.pictureBox1.Location = new System.Drawing.Point(357, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // gbAdd
            // 
            this.gbAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.gbAdd.Controls.Add(this.label3);
            this.gbAdd.Controls.Add(this.btnAddRole);
            this.gbAdd.Controls.Add(this.dudAcessLevel);
            this.gbAdd.Controls.Add(this.label2);
            this.gbAdd.Controls.Add(this.label1);
            this.gbAdd.Controls.Add(this.tbRoleName);
            this.gbAdd.Location = new System.Drawing.Point(260, 72);
            this.gbAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbAdd.Size = new System.Drawing.Size(236, 167);
            this.gbAdd.TabIndex = 51;
            this.gbAdd.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 60;
            this.label3.Text = "Adding a Role:";
            // 
            // btnAddRole
            // 
            this.btnAddRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnAddRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btnAddRole.Location = new System.Drawing.Point(31, 96);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(181, 43);
            this.btnAddRole.TabIndex = 59;
            this.btnAddRole.Text = "Add";
            this.btnAddRole.UseVisualStyleBackColor = false;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // dudAcessLevel
            // 
            this.dudAcessLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.dudAcessLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.dudAcessLevel.Items.Add("4");
            this.dudAcessLevel.Items.Add("3");
            this.dudAcessLevel.Items.Add("2");
            this.dudAcessLevel.Items.Add("1");
            this.dudAcessLevel.Location = new System.Drawing.Point(105, 72);
            this.dudAcessLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dudAcessLevel.Name = "dudAcessLevel";
            this.dudAcessLevel.Size = new System.Drawing.Size(106, 20);
            this.dudAcessLevel.TabIndex = 58;
            this.dudAcessLevel.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Access Level:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Role Name:";
            // 
            // tbRoleName
            // 
            this.tbRoleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.tbRoleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.tbRoleName.Location = new System.Drawing.Point(105, 49);
            this.tbRoleName.Name = "tbRoleName";
            this.tbRoleName.Size = new System.Drawing.Size(108, 20);
            this.tbRoleName.TabIndex = 53;
            // 
            // lbRoleDisplay
            // 
            this.lbRoleDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.lbRoleDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.lbRoleDisplay.FormattingEnabled = true;
            this.lbRoleDisplay.Location = new System.Drawing.Point(5, 72);
            this.lbRoleDisplay.Name = "lbRoleDisplay";
            this.lbRoleDisplay.ScrollAlwaysVisible = true;
            this.lbRoleDisplay.Size = new System.Drawing.Size(250, 342);
            this.lbRoleDisplay.TabIndex = 52;
            this.lbRoleDisplay.SelectedIndexChanged += new System.EventHandler(this.lbRoleDisplay_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 24);
            this.label4.TabIndex = 61;
            this.label4.Text = "Editing Roles:";
            // 
            // gbEdit
            // 
            this.gbEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.gbEdit.Controls.Add(this.btnUpdateRole);
            this.gbEdit.Controls.Add(this.dudAcessLevelUp);
            this.gbEdit.Controls.Add(this.label6);
            this.gbEdit.Controls.Add(this.label4);
            this.gbEdit.Controls.Add(this.label7);
            this.gbEdit.Controls.Add(this.tbRoleNameUp);
            this.gbEdit.Location = new System.Drawing.Point(260, 244);
            this.gbEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEdit.Size = new System.Drawing.Size(236, 167);
            this.gbEdit.TabIndex = 61;
            this.gbEdit.TabStop = false;
            // 
            // btnUpdateRole
            // 
            this.btnUpdateRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnUpdateRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btnUpdateRole.Location = new System.Drawing.Point(31, 96);
            this.btnUpdateRole.Name = "btnUpdateRole";
            this.btnUpdateRole.Size = new System.Drawing.Size(181, 43);
            this.btnUpdateRole.TabIndex = 59;
            this.btnUpdateRole.Text = "Save Edit";
            this.btnUpdateRole.UseVisualStyleBackColor = false;
            this.btnUpdateRole.Click += new System.EventHandler(this.btnUpdateRole_Click);
            // 
            // dudAcessLevelUp
            // 
            this.dudAcessLevelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.dudAcessLevelUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.dudAcessLevelUp.Items.Add("4");
            this.dudAcessLevelUp.Items.Add("3");
            this.dudAcessLevelUp.Items.Add("2");
            this.dudAcessLevelUp.Items.Add("1");
            this.dudAcessLevelUp.Location = new System.Drawing.Point(105, 72);
            this.dudAcessLevelUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dudAcessLevelUp.Name = "dudAcessLevelUp";
            this.dudAcessLevelUp.Size = new System.Drawing.Size(106, 20);
            this.dudAcessLevelUp.TabIndex = 58;
            this.dudAcessLevelUp.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Access Level:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Role Name:";
            // 
            // tbRoleNameUp
            // 
            this.tbRoleNameUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.tbRoleNameUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.tbRoleNameUp.Location = new System.Drawing.Point(105, 49);
            this.tbRoleNameUp.Name = "tbRoleNameUp";
            this.tbRoleNameUp.Size = new System.Drawing.Size(108, 20);
            this.tbRoleNameUp.TabIndex = 53;
            // 
            // btnToMenu
            // 
            this.btnToMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnToMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btnToMenu.Location = new System.Drawing.Point(5, 11);
            this.btnToMenu.Name = "btnToMenu";
            this.btnToMenu.Size = new System.Drawing.Size(119, 37);
            this.btnToMenu.TabIndex = 65;
            this.btnToMenu.Text = "Back to menu";
            this.btnToMenu.UseVisualStyleBackColor = false;
            this.btnToMenu.Click += new System.EventHandler(this.btnToMenu_Click);
            // 
            // RoleManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(504, 423);
            this.Controls.Add(this.btnToMenu);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.gbAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbRoleDisplay);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RoleManagerForm";
            this.Text = "RoleManagerForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.ListBox lbRoleDisplay;
        private System.Windows.Forms.DomainUpDown dudAcessLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRoleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.Button btnUpdateRole;
        private System.Windows.Forms.DomainUpDown dudAcessLevelUp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbRoleNameUp;
        private System.Windows.Forms.Button btnToMenu;
    }
}