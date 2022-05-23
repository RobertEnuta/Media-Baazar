
namespace HardwareStoreApp
{
    partial class Schedule
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
            this.calendar = new Syncfusion.WinForms.Input.SfCalendar();
            this.lbMorningShifts = new System.Windows.Forms.ListBox();
            this.btnEditMorningShifts = new System.Windows.Forms.Button();
            this.lblMorningShift = new System.Windows.Forms.Label();
            this.lblAfternoonShift = new System.Windows.Forms.Label();
            this.btnEditAfternoonShifts = new System.Windows.Forms.Button();
            this.lbAfternoonShifts = new System.Windows.Forms.ListBox();
            this.lblEveningShift = new System.Windows.Forms.Label();
            this.btnEditEveningShifts = new System.Windows.Forms.Button();
            this.lbEveningShifts = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDay = new System.Windows.Forms.Button();
            this.btnWeek = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendar
            // 
            this.calendar.Culture = new System.Globalization.CultureInfo("en-US");
            this.calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.calendar.Location = new System.Drawing.Point(18, 35);
            this.calendar.MinimumSize = new System.Drawing.Size(252, 252);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(343, 519);
            this.calendar.TabIndex = 0;
            this.calendar.Text = "sfCalendar1";
            this.calendar.Click += new System.EventHandler(this.calendar_Click);
            // 
            // lbMorningShifts
            // 
            this.lbMorningShifts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.lbMorningShifts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMorningShifts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.lbMorningShifts.FormattingEnabled = true;
            this.lbMorningShifts.ItemHeight = 18;
            this.lbMorningShifts.Location = new System.Drawing.Point(386, 35);
            this.lbMorningShifts.Name = "lbMorningShifts";
            this.lbMorningShifts.Size = new System.Drawing.Size(351, 148);
            this.lbMorningShifts.TabIndex = 2;
            // 
            // btnEditMorningShifts
            // 
            this.btnEditMorningShifts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnEditMorningShifts.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMorningShifts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btnEditMorningShifts.Location = new System.Drawing.Point(633, 179);
            this.btnEditMorningShifts.Name = "btnEditMorningShifts";
            this.btnEditMorningShifts.Size = new System.Drawing.Size(104, 34);
            this.btnEditMorningShifts.TabIndex = 5;
            this.btnEditMorningShifts.Text = "Edit Shift";
            this.btnEditMorningShifts.UseVisualStyleBackColor = false;
            this.btnEditMorningShifts.Click += new System.EventHandler(this.btnEditMorning_Click);
            // 
            // lblMorningShift
            // 
            this.lblMorningShift.AutoSize = true;
            this.lblMorningShift.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblMorningShift.Location = new System.Drawing.Point(383, 10);
            this.lblMorningShift.Name = "lblMorningShift";
            this.lblMorningShift.Size = new System.Drawing.Size(124, 22);
            this.lblMorningShift.TabIndex = 6;
            this.lblMorningShift.Text = "Morning Shift";
            // 
            // lblAfternoonShift
            // 
            this.lblAfternoonShift.AutoSize = true;
            this.lblAfternoonShift.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblAfternoonShift.Location = new System.Drawing.Point(383, 199);
            this.lblAfternoonShift.Name = "lblAfternoonShift";
            this.lblAfternoonShift.Size = new System.Drawing.Size(135, 22);
            this.lblAfternoonShift.TabIndex = 9;
            this.lblAfternoonShift.Text = "Afternoon Shift";
            // 
            // btnEditAfternoonShifts
            // 
            this.btnEditAfternoonShifts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnEditAfternoonShifts.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAfternoonShifts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btnEditAfternoonShifts.Location = new System.Drawing.Point(633, 363);
            this.btnEditAfternoonShifts.Name = "btnEditAfternoonShifts";
            this.btnEditAfternoonShifts.Size = new System.Drawing.Size(104, 34);
            this.btnEditAfternoonShifts.TabIndex = 8;
            this.btnEditAfternoonShifts.Text = "Edit Shift";
            this.btnEditAfternoonShifts.UseVisualStyleBackColor = false;
            this.btnEditAfternoonShifts.Click += new System.EventHandler(this.btnEditAfternoonShifts_Click);
            // 
            // lbAfternoonShifts
            // 
            this.lbAfternoonShifts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.lbAfternoonShifts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAfternoonShifts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.lbAfternoonShifts.FormattingEnabled = true;
            this.lbAfternoonShifts.ItemHeight = 18;
            this.lbAfternoonShifts.Location = new System.Drawing.Point(386, 219);
            this.lbAfternoonShifts.Name = "lbAfternoonShifts";
            this.lbAfternoonShifts.Size = new System.Drawing.Size(351, 148);
            this.lbAfternoonShifts.TabIndex = 7;
            // 
            // lblEveningShift
            // 
            this.lblEveningShift.AutoSize = true;
            this.lblEveningShift.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblEveningShift.Location = new System.Drawing.Point(383, 386);
            this.lblEveningShift.Name = "lblEveningShift";
            this.lblEveningShift.Size = new System.Drawing.Size(119, 22);
            this.lblEveningShift.TabIndex = 12;
            this.lblEveningShift.Text = "Evening Shift";
            // 
            // btnEditEveningShifts
            // 
            this.btnEditEveningShifts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnEditEveningShifts.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEveningShifts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btnEditEveningShifts.Location = new System.Drawing.Point(633, 551);
            this.btnEditEveningShifts.Name = "btnEditEveningShifts";
            this.btnEditEveningShifts.Size = new System.Drawing.Size(104, 34);
            this.btnEditEveningShifts.TabIndex = 11;
            this.btnEditEveningShifts.Text = "Edit Shift";
            this.btnEditEveningShifts.UseVisualStyleBackColor = false;
            this.btnEditEveningShifts.Click += new System.EventHandler(this.btnEditEveningShifts_Click);
            // 
            // lbEveningShifts
            // 
            this.lbEveningShifts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.lbEveningShifts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEveningShifts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.lbEveningShifts.FormattingEnabled = true;
            this.lbEveningShifts.ItemHeight = 18;
            this.lbEveningShifts.Location = new System.Drawing.Point(386, 406);
            this.lbEveningShifts.Name = "lbEveningShifts";
            this.lbEveningShifts.Size = new System.Drawing.Size(351, 148);
            this.lbEveningShifts.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDay);
            this.groupBox1.Controls.Add(this.btnWeek);
            this.groupBox1.Controls.Add(this.lblEveningShift);
            this.groupBox1.Controls.Add(this.btnEditEveningShifts);
            this.groupBox1.Controls.Add(this.lblMorningShift);
            this.groupBox1.Controls.Add(this.lbEveningShifts);
            this.groupBox1.Controls.Add(this.lblAfternoonShift);
            this.groupBox1.Controls.Add(this.btnEditAfternoonShifts);
            this.groupBox1.Controls.Add(this.lbAfternoonShifts);
            this.groupBox1.Controls.Add(this.btnEditMorningShifts);
            this.groupBox1.Controls.Add(this.lbMorningShifts);
            this.groupBox1.Controls.Add(this.calendar);
            this.groupBox1.Location = new System.Drawing.Point(25, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 627);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 566);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Autoschedule:";
            this.label1.Visible = false;
            // 
            // btnDay
            // 
            this.btnDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnDay.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btnDay.Location = new System.Drawing.Point(147, 560);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(104, 34);
            this.btnDay.TabIndex = 14;
            this.btnDay.Text = "Day";
            this.btnDay.UseVisualStyleBackColor = false;
            this.btnDay.Visible = false;
            // 
            // btnWeek
            // 
            this.btnWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btnWeek.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.btnWeek.Location = new System.Drawing.Point(257, 560);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(104, 34);
            this.btnWeek.TabIndex = 13;
            this.btnWeek.Text = "Week";
            this.btnWeek.UseVisualStyleBackColor = false;
            this.btnWeek.Visible = false;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(800, 688);
            this.Controls.Add(this.groupBox1);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.Input.SfCalendar calendar;
        private System.Windows.Forms.ListBox lbMorningShifts;
        private System.Windows.Forms.Button btnEditMorningShifts;
        private System.Windows.Forms.Label lblMorningShift;
        private System.Windows.Forms.Label lblAfternoonShift;
        private System.Windows.Forms.Button btnEditAfternoonShifts;
        private System.Windows.Forms.ListBox lbAfternoonShifts;
        private System.Windows.Forms.Label lblEveningShift;
        private System.Windows.Forms.Button btnEditEveningShifts;
        private System.Windows.Forms.ListBox lbEveningShifts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Button btnWeek;
    }
}