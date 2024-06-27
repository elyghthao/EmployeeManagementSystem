namespace EmployeeManagementSystem
{
    partial class Employee
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            label1 = new Label();
            panel1 = new Panel();
            EmpDGV = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            EmpGenCb = new ComboBox();
            label9 = new Label();
            EmpEduCb = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            EmpDob = new DateTimePicker();
            label6 = new Label();
            EmpPosCb = new ComboBox();
            EmpPhoneTb = new TextBox();
            label4 = new Label();
            EmpAddTb = new TextBox();
            label5 = new Label();
            EmpNameTb = new TextBox();
            label3 = new Label();
            EmpIdTb = new TextBox();
            label2 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmpDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(87, 24);
            label1.Name = "label1";
            label1.Size = new Size(236, 35);
            label1.TabIndex = 3;
            label1.Text = "Manage Employee";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(EmpDGV);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(EmpGenCb);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(EmpEduCb);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(EmpDob);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(EmpPosCb);
            panel1.Controls.Add(EmpPhoneTb);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(EmpAddTb);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(EmpNameTb);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(EmpIdTb);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-2, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 515);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // EmpDGV
            // 
            EmpDGV.AllowUserToAddRows = false;
            EmpDGV.AllowUserToDeleteRows = false;
            EmpDGV.AllowUserToResizeColumns = false;
            EmpDGV.AllowUserToResizeRows = false;
            EmpDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            EmpDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            EmpDGV.BackgroundColor = Color.White;
            EmpDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            EmpDGV.DefaultCellStyle = dataGridViewCellStyle1;
            EmpDGV.GridColor = Color.White;
            EmpDGV.ImeMode = ImeMode.Off;
            EmpDGV.Location = new Point(414, 72);
            EmpDGV.MultiSelect = false;
            EmpDGV.Name = "EmpDGV";
            EmpDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            EmpDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmpDGV.ShowCellToolTips = false;
            EmpDGV.ShowEditingIcon = false;
            EmpDGV.ShowRowErrors = false;
            EmpDGV.Size = new Size(531, 396);
            EmpDGV.TabIndex = 31;
            EmpDGV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(300, 421);
            button4.Name = "button4";
            button4.Size = new Size(86, 37);
            button4.TabIndex = 30;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(208, 421);
            button3.Name = "button3";
            button3.Size = new Size(86, 37);
            button3.TabIndex = 29;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(116, 421);
            button2.Name = "button2";
            button2.Size = new Size(86, 37);
            button2.TabIndex = 28;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(24, 421);
            button1.Name = "button1";
            button1.Size = new Size(86, 37);
            button1.TabIndex = 27;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EmpGenCb
            // 
            EmpGenCb.ForeColor = Color.Red;
            EmpGenCb.FormattingEnabled = true;
            EmpGenCb.ItemHeight = 20;
            EmpGenCb.Items.AddRange(new object[] { "Male", "Female", "NonBinary" });
            EmpGenCb.Location = new Point(218, 159);
            EmpGenCb.Name = "EmpGenCb";
            EmpGenCb.Size = new Size(185, 28);
            EmpGenCb.TabIndex = 26;
            EmpGenCb.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(218, 132);
            label9.Name = "label9";
            label9.Size = new Size(161, 24);
            label9.TabIndex = 25;
            label9.Text = "Employee Gender";
            label9.Click += label9_Click;
            // 
            // EmpEduCb
            // 
            EmpEduCb.ForeColor = Color.Red;
            EmpEduCb.FormattingEnabled = true;
            EmpEduCb.Items.AddRange(new object[] { "BTech", "MTech", "BBA", "BCA", "MBA", "BCom", "MCom" });
            EmpEduCb.Location = new Point(218, 358);
            EmpEduCb.Name = "EmpEduCb";
            EmpEduCb.Size = new Size(185, 28);
            EmpEduCb.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(218, 331);
            label8.Name = "label8";
            label8.Size = new Size(185, 24);
            label8.TabIndex = 23;
            label8.Text = "Employee Education";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(24, 331);
            label7.Name = "label7";
            label7.Size = new Size(153, 24);
            label7.TabIndex = 21;
            label7.Text = "Employee Phone";
            // 
            // EmpDob
            // 
            EmpDob.CalendarFont = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmpDob.Location = new Point(218, 266);
            EmpDob.Name = "EmpDob";
            EmpDob.Size = new Size(185, 27);
            EmpDob.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(218, 239);
            label6.Name = "label6";
            label6.Size = new Size(138, 24);
            label6.TabIndex = 19;
            label6.Text = "Employee DOB";
            label6.Click += label6_Click;
            // 
            // EmpPosCb
            // 
            EmpPosCb.ForeColor = Color.Red;
            EmpPosCb.FormattingEnabled = true;
            EmpPosCb.Items.AddRange(new object[] { "Mangager", "Senior Developer", "Junior Developer", "Accountant", "Receptionist" });
            EmpPosCb.Location = new Point(24, 266);
            EmpPosCb.Name = "EmpPosCb";
            EmpPosCb.Size = new Size(168, 28);
            EmpPosCb.TabIndex = 18;
            // 
            // EmpPhoneTb
            // 
            EmpPhoneTb.AllowDrop = true;
            EmpPhoneTb.BackColor = Color.White;
            EmpPhoneTb.BorderStyle = BorderStyle.FixedSingle;
            EmpPhoneTb.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpPhoneTb.ForeColor = Color.Red;
            EmpPhoneTb.ImeMode = ImeMode.Off;
            EmpPhoneTb.Location = new Point(24, 358);
            EmpPhoneTb.Name = "EmpPhoneTb";
            EmpPhoneTb.Size = new Size(168, 32);
            EmpPhoneTb.TabIndex = 17;
            EmpPhoneTb.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(24, 239);
            label4.Name = "label4";
            label4.Size = new Size(168, 24);
            label4.TabIndex = 16;
            label4.Text = "Employee Position";
            label4.Click += label4_Click;
            // 
            // EmpAddTb
            // 
            EmpAddTb.AllowDrop = true;
            EmpAddTb.BackColor = Color.White;
            EmpAddTb.BorderStyle = BorderStyle.FixedSingle;
            EmpAddTb.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpAddTb.ForeColor = Color.Red;
            EmpAddTb.ImeMode = ImeMode.Off;
            EmpAddTb.Location = new Point(24, 159);
            EmpAddTb.Name = "EmpAddTb";
            EmpAddTb.Size = new Size(168, 32);
            EmpAddTb.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(24, 132);
            label5.Name = "label5";
            label5.Size = new Size(168, 24);
            label5.TabIndex = 14;
            label5.Text = "Employee Address";
            // 
            // EmpNameTb
            // 
            EmpNameTb.AllowDrop = true;
            EmpNameTb.BackColor = Color.White;
            EmpNameTb.BorderStyle = BorderStyle.FixedSingle;
            EmpNameTb.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpNameTb.ForeColor = Color.Red;
            EmpNameTb.ImeMode = ImeMode.Off;
            EmpNameTb.Location = new Point(218, 62);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(185, 32);
            EmpNameTb.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(218, 35);
            label3.Name = "label3";
            label3.Size = new Size(149, 24);
            label3.TabIndex = 12;
            label3.Text = "Employee Name";
            // 
            // EmpIdTb
            // 
            EmpIdTb.AllowDrop = true;
            EmpIdTb.BackColor = Color.White;
            EmpIdTb.BorderStyle = BorderStyle.FixedSingle;
            EmpIdTb.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpIdTb.ForeColor = Color.Red;
            EmpIdTb.ImeMode = ImeMode.Off;
            EmpIdTb.Location = new Point(24, 62);
            EmpIdTb.Name = "EmpIdTb";
            EmpIdTb.Size = new Size(168, 32);
            EmpIdTb.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(24, 35);
            label2.Name = "label2";
            label2.Size = new Size(118, 24);
            label2.TabIndex = 10;
            label2.Text = "Employee ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(921, 11);
            label10.Name = "label10";
            label10.Size = new Size(22, 24);
            label10.TabIndex = 5;
            label10.Text = "X";
            label10.Click += label10_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Red;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(959, 652);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            Load += Employee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmpDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox EmpIdTb;
        private Label label6;
        private ComboBox EmpPosCb;
        private TextBox EmpPhoneTb;
        private Label label4;
        private TextBox EmpAddTb;
        private Label label5;
        private TextBox EmpNameTb;
        private Label label3;
        private DateTimePicker EmpDob;
        private ComboBox EmpEduCb;
        private Label label8;
        private Label label7;
        private ComboBox EmpGenCb;
        private Label label9;
        private Button button1;
        private DataGridView EmpDGV;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label10;
        private PictureBox pictureBox1;
    }
}