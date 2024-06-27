namespace EmployeeManagementSystem
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            userIDTextbox = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            passwordTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(328, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 35);
            label1.TabIndex = 1;
            label1.Text = "ElyghSoft";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // userIDTextbox
            // 
            userIDTextbox.AllowDrop = true;
            userIDTextbox.BackColor = Color.White;
            userIDTextbox.BorderStyle = BorderStyle.FixedSingle;
            userIDTextbox.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userIDTextbox.ForeColor = Color.Red;
            userIDTextbox.ImeMode = ImeMode.Off;
            userIDTextbox.Location = new Point(280, 106);
            userIDTextbox.Name = "userIDTextbox";
            userIDTextbox.Size = new Size(125, 32);
            userIDTextbox.TabIndex = 3;
            userIDTextbox.TextChanged += textBox1_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // passwordTextBox
            // 
            passwordTextBox.AllowDrop = true;
            passwordTextBox.BackColor = Color.White;
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.ForeColor = Color.Red;
            passwordTextBox.ImeMode = ImeMode.Off;
            passwordTextBox.Location = new Point(280, 162);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(125, 32);
            passwordTextBox.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(189, 214);
            button1.Name = "button1";
            button1.Size = new Size(124, 34);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(336, 214);
            button2.Name = "button2";
            button2.Size = new Size(124, 34);
            button2.TabIndex = 8;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(159, 110);
            label2.Name = "label2";
            label2.Size = new Size(85, 28);
            label2.TabIndex = 9;
            label2.Text = "UserID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(159, 162);
            label3.Name = "label3";
            label3.Size = new Size(115, 28);
            label3.TabIndex = 10;
            label3.Text = "Password:";
            label3.Click += label3_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(472, 261);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(passwordTextBox);
            Controls.Add(userIDTextbox);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox userIDTextbox;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox passwordTextBox;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
    }
}