namespace HardwareStoreApp
{
    partial class EmployeeEditor
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
            this.lbEmployeeDisplay = new System.Windows.Forms.ListBox();
            this.cbEmpRole = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.tbEmpPassword = new System.Windows.Forms.TextBox();
            this.tbEmpID = new System.Windows.Forms.TextBox();
            this.tbEmpAddress = new System.Windows.Forms.TextBox();
            this.tbEmpLastName = new System.Windows.Forms.TextBox();
            this.tbEmpBSN = new System.Windows.Forms.TextBox();
            this.tbEmpPhoneNr = new System.Windows.Forms.TextBox();
            this.tbEmpEmail = new System.Windows.Forms.TextBox();
            this.tbEmpHourlyPay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmpFirstName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnSaveEmployee = new System.Windows.Forms.Button();
            this.lbl69 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEmpDepartment = new System.Windows.Forms.ComboBox();
            this.label1000 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbContract = new System.Windows.Forms.DomainUpDown();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEmployeeDisplay
            // 
            this.lbEmployeeDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.lbEmployeeDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.lbEmployeeDisplay.FormattingEnabled = true;
            this.lbEmployeeDisplay.HorizontalScrollbar = true;
            this.lbEmployeeDisplay.ItemHeight = 22;
            this.lbEmployeeDisplay.Location = new System.Drawing.Point(19, 52);
            this.lbEmployeeDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.lbEmployeeDisplay.Name = "lbEmployeeDisplay";
            this.lbEmployeeDisplay.Size = new System.Drawing.Size(374, 488);
            this.lbEmployeeDisplay.TabIndex = 1;
            this.lbEmployeeDisplay.SelectedIndexChanged += new System.EventHandler(this.lbEmployeeDisplay_SelectedIndexChanged);
            // 
            // cbEmpRole
            // 
            this.cbEmpRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.cbEmpRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.cbEmpRole.FormattingEnabled = true;
            this.cbEmpRole.Location = new System.Drawing.Point(700, 367);
            this.cbEmpRole.Name = "cbEmpRole";
            this.cbEmpRole.Size = new System.Drawing.Size(327, 30);
            this.cbEmpRole.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(642, 370);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 22);
            this.label5.TabIndex = 60;
            this.label5.Text = "Role:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 331);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 59;
            this.label3.Text = "Date of Birth:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.dtpDateOfBirth.Location = new System.Drawing.Point(700, 326);
            this.dtpDateOfBirth.MaxDate = new System.DateTime(2005, 12, 30, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(325, 29);
            this.dtpDateOfBirth.TabIndex = 58;
            this.dtpDateOfBirth.Value = new System.DateTime(2005, 12, 30, 0, 0, 0, 0);
            // 
            // tbEmpPassword
            // 
            this.tbEmpPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.tbEmpPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.tbEmpPassword.Location = new System.Drawing.Point(700, 263);
            this.tbEmpPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmpPassword.Name = "tbEmpPassword";
            this.tbEmpPassword.Size = new System.Drawing.Size(325, 29);
            this.tbEmpPassword.TabIndex = 55;
            // 
            // tbEmpID
            // 
            this.tbEmpID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.tbEmpID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.tbEmpID.Location = new System.Drawing.Point(700, 231);
            this.tbEmpID.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmpID.Name = "tbEmpID";
            this.tbEmpID.ReadOnly = true;
            this.tbEmpID.Size = new System.Drawing.Size(325, 29);
            this.tbEmpID.TabIndex = 54;
            // 
            // tbEmpAddress
            // 
            this.tbEmpAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.tbEmpAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.tbEmpAddress.Location = new System.Drawing.Point(700, 168);
            this.tbEmpAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmpAddress.Name = "tbEmpAddress";
            this.tbEmpAddress.Size = new System.Drawing.Size(325, 29);
            this.tbEmpAddress.TabIndex = 52;
            // 
            // tbEmpLastName
            // 
            this.tbEmpLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.tbEmpLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.tbEmpLastName.Location = new System.Drawing.Point(700, 72);
            this.tbEmpLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmpLastName.Name = "tbEmpLastName";
            this.tbEmpLastName.Size = new System.Drawing.Size(323, 29);
            this.tbEmpLastName.TabIndex = 51;
            // 
            // tbEmpBSN
            // 
            this.tbEmpBSN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.tbEmpBSN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.tbEmpBSN.Location = new System.Drawing.Point(700, 199);
            this.tbEmpBSN.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmpBSN.Name = "tbEmpBSN";
            this.tbEmpBSN.Size = new System.Drawing.Size(325, 29);
            this.tbEmpBSN.TabIndex = 47;
            // 
            // tbEmpPhoneNr
            // 
            this.tbEmpPhoneNr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.tbEmpPhoneNr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.tbEmpPhoneNr.Location = new System.Drawing.Point(700, 135);
            this.tbEmpPhoneNr.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmpPhoneNr.Name = "tbEmpPhoneNr";
            this.tbEmpPhoneNr.Size = new System.Drawing.Size(325, 29);
            this.tbEmpPhoneNr.TabIndex = 46;
            // 
            // tbEmpEmail
            // 
            this.tbEmpEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.tbEmpEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.tbEmpEmail.Location = new System.Drawing.Point(700, 104);
            this.tbEmpEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmpEmail.Name = "tbEmpEmail";
            this.tbEmpEmail.Size = new System.Drawing.Size(322, 29);
            this.tbEmpEmail.TabIndex = 44;
            // 
            // tbEmpHourlyPay
            // 
            this.tbEmpHourlyPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.tbEmpHourlyPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.tbEmpHourlyPay.Location = new System.Drawing.Point(700, 295);
            this.tbEmpHourlyPay.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmpHourlyPay.Name = "tbEmpHourlyPay";
            this.tbEmpHourlyPay.Size = new System.Drawing.Size(325, 29);
            this.tbEmpHourlyPay.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 298);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "Hourly pay:";
            // 
            // tbEmpFirstName
            // 
            this.tbEmpFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.tbEmpFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.tbEmpFirstName.Location = new System.Drawing.Point(700, 40);
            this.tbEmpFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmpFirstName.Name = "tbEmpFirstName";
            this.tbEmpFirstName.Size = new System.Drawing.Size(323, 29);
            this.tbEmpFirstName.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(600, 266);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 22);
            this.label13.TabIndex = 57;
            this.label13.Text = "Password:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(574, 234);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 22);
            this.label12.TabIndex = 56;
            this.label12.Text = "Employee ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(562, 138);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 22);
            this.label11.TabIndex = 53;
            this.label11.Text = "Phone number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(595, 75);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 22);
            this.label10.TabIndex = 50;
            this.label10.Text = "Last name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(632, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 22);
            this.label6.TabIndex = 45;
            this.label6.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 40;
            this.label1.Text = "First name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(614, 171);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 22);
            this.label8.TabIndex = 48;
            this.label8.Text = "Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(642, 202);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 22);
            this.label9.TabIndex = 49;
            this.label9.Text = "BSN:";
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.btnDeleteEmployee.Location = new System.Drawing.Point(401, 476);
            this.btnDeleteEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(117, 64);
            this.btnDeleteEmployee.TabIndex = 62;
            this.btnDeleteEmployee.Text = "Fire ";
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnSaveEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.btnSaveEmployee.Location = new System.Drawing.Point(526, 476);
            this.btnSaveEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new System.Drawing.Size(502, 64);
            this.btnSaveEmployee.TabIndex = 63;
            this.btnSaveEmployee.Text = "Save Edit";
            this.btnSaveEmployee.UseVisualStyleBackColor = false;
            this.btnSaveEmployee.Click += new System.EventHandler(this.btnSaveEmployee_Click);
            // 
            // lbl69
            // 
            this.lbl69.AutoSize = true;
            this.lbl69.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl69.Location = new System.Drawing.Point(613, 41);
            this.lbl69.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl69.Name = "lbl69";
            this.lbl69.Size = new System.Drawing.Size(341, 34);
            this.lbl69.TabIndex = 65;
            this.lbl69.Text = "Edit/delete Employees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 22);
            this.label4.TabIndex = 66;
            this.label4.Text = "Select an employee to edit their info";
            // 
            // cbEmpDepartment
            // 
            this.cbEmpDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.cbEmpDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.cbEmpDepartment.FormattingEnabled = true;
            this.cbEmpDepartment.Location = new System.Drawing.Point(700, 438);
            this.cbEmpDepartment.Name = "cbEmpDepartment";
            this.cbEmpDepartment.Size = new System.Drawing.Size(328, 30);
            this.cbEmpDepartment.TabIndex = 68;
            // 
            // label1000
            // 
            this.label1000.AutoSize = true;
            this.label1000.Location = new System.Drawing.Point(583, 441);
            this.label1000.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1000.Name = "label1000";
            this.label1000.Size = new System.Drawing.Size(112, 22);
            this.label1000.TabIndex = 69;
            this.label1000.Text = "Department:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.btnBack.Location = new System.Drawing.Point(13, 634);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(124, 42);
            this.btnBack.TabIndex = 70;
            this.btnBack.Text = "Back To Add ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HardwareStoreApp.Properties.Resources.Logo_no_PC;
            this.pictureBox1.Location = new System.Drawing.Point(1262, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rtbContract);
            this.groupBox1.Controls.Add(this.tbEmpPhoneNr);
            this.groupBox1.Controls.Add(this.tbEmpFirstName);
            this.groupBox1.Controls.Add(this.cbEmpDepartment);
            this.groupBox1.Controls.Add(this.dtpDateOfBirth);
            this.groupBox1.Controls.Add(this.tbEmpHourlyPay);
            this.groupBox1.Controls.Add(this.tbEmpPassword);
            this.groupBox1.Controls.Add(this.tbEmpID);
            this.groupBox1.Controls.Add(this.lbEmployeeDisplay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1000);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnSaveEmployee);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnDeleteEmployee);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbEmpRole);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbEmpEmail);
            this.groupBox1.Controls.Add(this.tbEmpAddress);
            this.groupBox1.Controls.Add(this.tbEmpBSN);
            this.groupBox1.Controls.Add(this.tbEmpLastName);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.groupBox1.Location = new System.Drawing.Point(206, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1046, 569);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(642, 405);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 22);
            this.label7.TabIndex = 71;
            this.label7.Text = "FTE:";
            // 
            // rtbContract
            // 
            this.rtbContract.Items.Add("1.0");
            this.rtbContract.Items.Add("0.9");
            this.rtbContract.Items.Add("0.8");
            this.rtbContract.Items.Add("0.7");
            this.rtbContract.Items.Add("0.6");
            this.rtbContract.Items.Add("0.5");
            this.rtbContract.Items.Add("0.4");
            this.rtbContract.Items.Add("0.3");
            this.rtbContract.Items.Add("0.2");
            this.rtbContract.Items.Add("0.1");
            this.rtbContract.Location = new System.Drawing.Point(700, 403);
            this.rtbContract.Name = "rtbContract";
            this.rtbContract.Size = new System.Drawing.Size(328, 29);
            this.rtbContract.TabIndex = 70;
            this.rtbContract.Text = "0.1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 9);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(175, 34);
            this.label14.TabIndex = 73;
            this.label14.Text = "Employees";
            // 
            // EmployeeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1497, 709);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbl69);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeEditor";
            this.Text = "EmployeeEditor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbEmployeeDisplay;
        private System.Windows.Forms.ComboBox cbEmpRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox tbEmpPassword;
        private System.Windows.Forms.TextBox tbEmpID;
        private System.Windows.Forms.TextBox tbEmpAddress;
        private System.Windows.Forms.TextBox tbEmpLastName;
        private System.Windows.Forms.TextBox tbEmpBSN;
        private System.Windows.Forms.TextBox tbEmpPhoneNr;
        private System.Windows.Forms.TextBox tbEmpEmail;
        private System.Windows.Forms.TextBox tbEmpHourlyPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmpFirstName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnSaveEmployee;
        private System.Windows.Forms.Label lbl69;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEmpDepartment;
        private System.Windows.Forms.Label label1000;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DomainUpDown rtbContract;
    }
}