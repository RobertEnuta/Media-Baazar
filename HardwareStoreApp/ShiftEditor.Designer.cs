
namespace HardwareStoreApp
{
    partial class ShiftEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblAvailableEmployees = new System.Windows.Forms.Label();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.btnEditEveningShifts = new System.Windows.Forms.Button();
            this.lbAvailableToAssign = new System.Windows.Forms.ListBox();
            this.lbAssignedToShift = new System.Windows.Forms.ListBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblShiftType = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblAvailableEmployees);
            this.groupBox1.Controls.Add(this.btnRemoveEmployee);
            this.groupBox1.Controls.Add(this.btnEditEveningShifts);
            this.groupBox1.Controls.Add(this.lbAvailableToAssign);
            this.groupBox1.Controls.Add(this.lbAssignedToShift);
            this.groupBox1.Location = new System.Drawing.Point(23, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(867, 445);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Shift:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvailableEmployees
            // 
            this.lblAvailableEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvailableEmployees.AutoSize = true;
            this.lblAvailableEmployees.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblAvailableEmployees.Location = new System.Drawing.Point(485, 19);
            this.lblAvailableEmployees.Name = "lblAvailableEmployees";
            this.lblAvailableEmployees.Size = new System.Drawing.Size(183, 22);
            this.lblAvailableEmployees.TabIndex = 16;
            this.lblAvailableEmployees.Text = "Available Employees:";
            this.lblAvailableEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnRemoveEmployee.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btnRemoveEmployee.Location = new System.Drawing.Point(126, 405);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(143, 34);
            this.btnRemoveEmployee.TabIndex = 12;
            this.btnRemoveEmployee.Text = "Remove Employee";
            this.btnRemoveEmployee.UseVisualStyleBackColor = false;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditEveningShifts
            // 
            this.btnEditEveningShifts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnEditEveningShifts.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEveningShifts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btnEditEveningShifts.Location = new System.Drawing.Point(592, 406);
            this.btnEditEveningShifts.Name = "btnEditEveningShifts";
            this.btnEditEveningShifts.Size = new System.Drawing.Size(143, 34);
            this.btnEditEveningShifts.TabIndex = 11;
            this.btnEditEveningShifts.Text = "Assign Employee";
            this.btnEditEveningShifts.UseVisualStyleBackColor = false;
            this.btnEditEveningShifts.Click += new System.EventHandler(this.btnEditEveningShifts_Click);
            // 
            // lbAvailableToAssign
            // 
            this.lbAvailableToAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.lbAvailableToAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvailableToAssign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.lbAvailableToAssign.FormattingEnabled = true;
            this.lbAvailableToAssign.ItemHeight = 18;
            this.lbAvailableToAssign.Location = new System.Drawing.Point(489, 44);
            this.lbAvailableToAssign.Name = "lbAvailableToAssign";
            this.lbAvailableToAssign.Size = new System.Drawing.Size(351, 346);
            this.lbAvailableToAssign.TabIndex = 7;
            // 
            // lbAssignedToShift
            // 
            this.lbAssignedToShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.lbAssignedToShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAssignedToShift.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.lbAssignedToShift.FormattingEnabled = true;
            this.lbAssignedToShift.ItemHeight = 18;
            this.lbAssignedToShift.Location = new System.Drawing.Point(22, 44);
            this.lbAssignedToShift.Name = "lbAssignedToShift";
            this.lbAssignedToShift.Size = new System.Drawing.Size(351, 346);
            this.lbAssignedToShift.TabIndex = 2;
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblInfo.Location = new System.Drawing.Point(662, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(105, 22);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.Text = "hidden stuff";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.Visible = false;
            // 
            // lblShiftType
            // 
            this.lblShiftType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShiftType.AutoSize = true;
            this.lblShiftType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblShiftType.Location = new System.Drawing.Point(19, 9);
            this.lblShiftType.Name = "lblShiftType";
            this.lblShiftType.Size = new System.Drawing.Size(134, 22);
            this.lblShiftType.TabIndex = 16;
            this.lblShiftType.Text = "Shift Type here";
            this.lblShiftType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(188, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(128, 22);
            this.lblDate.TabIndex = 20;
            this.lblDate.Text = "Date Info here";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShiftEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(913, 498);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblShiftType);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShiftEditor";
            this.Text = "ShiftEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShiftEditor_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAvailableEmployees;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Button btnEditEveningShifts;
        private System.Windows.Forms.ListBox lbAvailableToAssign;
        private System.Windows.Forms.ListBox lbAssignedToShift;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblShiftType;
        private System.Windows.Forms.Label lblDate;
    }
}