namespace Login_and_Registration_system
{
    partial class FrmRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Get = new Label();
            label1 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            txtConPassword = new TextBox();
            CheckBxShowPassword = new CheckBox();
            RegisterBtn = new Button();
            label4 = new Label();
            label5 = new Label();
            ClearBtn = new Button();
            SuspendLayout();
            // 
            // Get
            // 
            Get.AutoSize = true;
            Get.Font = new Font("MS Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Get.ForeColor = Color.FromArgb(116, 86, 184);
            Get.Location = new Point(28, 68);
            Get.Name = "Get";
            Get.Size = new Size(177, 27);
            Get.TabIndex = 0;
            Get.Text = "Get Started";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 119);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(34, 139);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 28);
            txtUsername.TabIndex = 2;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 186);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 1;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(34, 206);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(216, 28);
            txtPassword.TabIndex = 2;
            txtPassword.TextChanged += txtUsername_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 255);
            label3.Name = "label3";
            label3.Size = new Size(120, 17);
            label3.TabIndex = 1;
            label3.Text = "Confirm Password";
            label3.Click += label2_Click;
            // 
            // txtConPassword
            // 
            txtConPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtConPassword.BorderStyle = BorderStyle.None;
            txtConPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtConPassword.ForeColor = Color.Black;
            txtConPassword.Location = new Point(34, 275);
            txtConPassword.Multiline = true;
            txtConPassword.Name = "txtConPassword";
            txtConPassword.PasswordChar = '*';
            txtConPassword.Size = new Size(216, 28);
            txtConPassword.TabIndex = 2;
            txtConPassword.TextChanged += txtUsername_TextChanged;
            // 
            // CheckBxShowPassword
            // 
            CheckBxShowPassword.AutoSize = true;
            CheckBxShowPassword.Location = new Point(135, 324);
            CheckBxShowPassword.Name = "CheckBxShowPassword";
            CheckBxShowPassword.Size = new Size(122, 21);
            CheckBxShowPassword.TabIndex = 3;
            CheckBxShowPassword.Text = "Show Password";
            CheckBxShowPassword.UseVisualStyleBackColor = true;
            CheckBxShowPassword.CheckedChanged += CheckBxShowPassword_CheckedChanged;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.FromArgb(116, 86, 184);
            RegisterBtn.Cursor = Cursors.Hand;
            RegisterBtn.FlatStyle = FlatStyle.Flat;
            RegisterBtn.ForeColor = Color.White;
            RegisterBtn.Location = new Point(34, 367);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(216, 42);
            RegisterBtn.TabIndex = 4;
            RegisterBtn.Text = "REGISTER";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 472);
            label4.Name = "label4";
            label4.Size = new Size(161, 17);
            label4.TabIndex = 5;
            label4.Text = "Already Have a Account?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.FromArgb(116, 86, 184);
            label5.Location = new Point(111, 499);
            label5.Name = "label5";
            label5.Size = new Size(43, 17);
            label5.TabIndex = 5;
            label5.Text = "LogIn";
            label5.Click += label5_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.FlatStyle = FlatStyle.Flat;
            ClearBtn.ForeColor = Color.FromArgb(116, 86, 184);
            ClearBtn.Location = new Point(34, 424);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(216, 29);
            ClearBtn.TabIndex = 6;
            ClearBtn.Text = "CLEAR";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += button1_Click;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(285, 544);
            Controls.Add(ClearBtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(RegisterBtn);
            Controls.Add(CheckBxShowPassword);
            Controls.Add(txtConPassword);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(Get);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Get;
        private Label label1;
        private TextBox txtUsername;
        private Label label2;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtConPassword;
        private CheckBox CheckBxShowPassword;
        private Button RegisterBtn;
        private Label label4;
        private Label label5;
        private Button ClearBtn;
    }
}
