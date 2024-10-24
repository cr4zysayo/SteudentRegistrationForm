namespace SteudentRegistrationForm
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RegStudent = new System.Windows.Forms.Button();
            this.GenderMale = new System.Windows.Forms.RadioButton();
            this.GenderFemale = new System.Windows.Forms.RadioButton();
            this.Lname = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.TextBox();
            this.Mname = new System.Windows.Forms.TextBox();
            this.NumberDay = new System.Windows.Forms.ComboBox();
            this.NumberMonth = new System.Windows.Forms.ComboBox();
            this.NumberYear = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Program = new System.Windows.Forms.ComboBox();
            this.Bpicture = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registration Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "First name*";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Middle name*";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender*";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date of birth*";
            // 
            // RegStudent
            // 
            this.RegStudent.BackColor = System.Drawing.Color.Crimson;
            this.RegStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegStudent.ForeColor = System.Drawing.Color.White;
            this.RegStudent.Location = new System.Drawing.Point(21, 337);
            this.RegStudent.Name = "RegStudent";
            this.RegStudent.Size = new System.Drawing.Size(213, 34);
            this.RegStudent.TabIndex = 6;
            this.RegStudent.Text = "Register student";
            this.RegStudent.UseVisualStyleBackColor = false;
            this.RegStudent.Click += new System.EventHandler(this.RegStudent_Click);
            // 
            // GenderMale
            // 
            this.GenderMale.AutoSize = true;
            this.GenderMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderMale.Location = new System.Drawing.Point(99, 198);
            this.GenderMale.Name = "GenderMale";
            this.GenderMale.Size = new System.Drawing.Size(61, 24);
            this.GenderMale.TabIndex = 7;
            this.GenderMale.TabStop = true;
            this.GenderMale.Text = "Male";
            this.GenderMale.UseVisualStyleBackColor = true;
            this.GenderMale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // GenderFemale
            // 
            this.GenderFemale.AutoSize = true;
            this.GenderFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderFemale.Location = new System.Drawing.Point(163, 198);
            this.GenderFemale.Name = "GenderFemale";
            this.GenderFemale.Size = new System.Drawing.Size(80, 24);
            this.GenderFemale.TabIndex = 8;
            this.GenderFemale.TabStop = true;
            this.GenderFemale.Text = "Female";
            this.GenderFemale.UseVisualStyleBackColor = true;
            this.GenderFemale.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Lname
            // 
            this.Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.Location = new System.Drawing.Point(16, 62);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(236, 26);
            this.Lname.TabIndex = 9;
            // 
            // Fname
            // 
            this.Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname.Location = new System.Drawing.Point(16, 114);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(236, 26);
            this.Fname.TabIndex = 10;
            // 
            // Mname
            // 
            this.Mname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mname.Location = new System.Drawing.Point(16, 166);
            this.Mname.Name = "Mname";
            this.Mname.Size = new System.Drawing.Size(236, 26);
            this.Mname.TabIndex = 11;
            // 
            // NumberDay
            // 
            this.NumberDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberDay.FormattingEnabled = true;
            this.NumberDay.Location = new System.Drawing.Point(21, 249);
            this.NumberDay.Name = "NumberDay";
            this.NumberDay.Size = new System.Drawing.Size(72, 28);
            this.NumberDay.TabIndex = 12;
            this.NumberDay.Text = "-Day-";
            this.NumberDay.SelectedIndexChanged += new System.EventHandler(this.NumberDay_SelectedIndexChanged);
            // 
            // NumberMonth
            // 
            this.NumberMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberMonth.FormattingEnabled = true;
            this.NumberMonth.Location = new System.Drawing.Point(99, 248);
            this.NumberMonth.Name = "NumberMonth";
            this.NumberMonth.Size = new System.Drawing.Size(72, 28);
            this.NumberMonth.TabIndex = 13;
            this.NumberMonth.Text = "-Month-";
            // 
            // NumberYear
            // 
            this.NumberYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberYear.FormattingEnabled = true;
            this.NumberYear.Location = new System.Drawing.Point(180, 248);
            this.NumberYear.Name = "NumberYear";
            this.NumberYear.Size = new System.Drawing.Size(72, 28);
            this.NumberYear.TabIndex = 14;
            this.NumberYear.Text = "-Years-";
            this.NumberYear.SelectedIndexChanged += new System.EventHandler(this.NumberYear_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(291, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Program to apply*";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Program
            // 
            this.Program.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Program.FormattingEnabled = true;
            this.Program.Location = new System.Drawing.Point(21, 303);
            this.Program.Name = "Program";
            this.Program.Size = new System.Drawing.Size(334, 28);
            this.Program.TabIndex = 17;
            this.Program.SelectedIndexChanged += new System.EventHandler(this.Program_SelectedIndexChanged);
            // 
            // Bpicture
            // 
            this.Bpicture.BackColor = System.Drawing.SystemColors.Control;
            this.Bpicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bpicture.Location = new System.Drawing.Point(321, 224);
            this.Bpicture.Name = "Bpicture";
            this.Bpicture.Size = new System.Drawing.Size(139, 30);
            this.Bpicture.TabIndex = 18;
            this.Bpicture.Text = "Browse";
            this.Bpicture.UseVisualStyleBackColor = false;
            this.Bpicture.Click += new System.EventHandler(this.Bpicture_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "GPG files|*JPG|jpg files|.jpg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 395);
            this.Controls.Add(this.Bpicture);
            this.Controls.Add(this.Program);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NumberYear);
            this.Controls.Add(this.NumberMonth);
            this.Controls.Add(this.NumberDay);
            this.Controls.Add(this.Mname);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.GenderFemale);
            this.Controls.Add(this.GenderMale);
            this.Controls.Add(this.RegStudent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button RegStudent;
        private System.Windows.Forms.RadioButton GenderMale;
        private System.Windows.Forms.RadioButton GenderFemale;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox Mname;
        private System.Windows.Forms.ComboBox NumberDay;
        private System.Windows.Forms.ComboBox NumberMonth;
        private System.Windows.Forms.ComboBox NumberYear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Program;
        private System.Windows.Forms.Button Bpicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

