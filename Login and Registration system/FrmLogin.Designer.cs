namespace Login_and_Registration_system
{
    partial class FrmLogin
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
            label5 = new Label();
            label4 = new Label();
            ClearBtn = new Button();
            RegisterBtn = new Button();
            CheckBxShowPassword = new CheckBox();
            txtPassword = new TextBox();
            label2 = new Label();
            txtUsername = new TextBox();
            label1 = new Label();
            Get = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.FromArgb(116, 86, 184);
            label5.Location = new Point(122, 433);
            label5.Name = "label5";
            label5.Size = new Size(58, 17);
            label5.TabIndex = 16;
            label5.Text = "Register";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 406);
            label4.Name = "label4";
            label4.Size = new Size(148, 17);
            label4.TabIndex = 17;
            label4.Text = "Don't Have a Account?";
            // 
            // ClearBtn
            // 
            ClearBtn.BackColor = Color.FromArgb(116, 86, 184);
            ClearBtn.Cursor = Cursors.Hand;
            ClearBtn.FlatStyle = FlatStyle.Flat;
            ClearBtn.ForeColor = Color.White;
            ClearBtn.Location = new Point(45, 349);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(216, 42);
            ClearBtn.TabIndex = 14;
            ClearBtn.Text = "CLEAR";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.FromArgb(116, 86, 184);
            RegisterBtn.Cursor = Cursors.Hand;
            RegisterBtn.FlatStyle = FlatStyle.Flat;
            RegisterBtn.ForeColor = Color.White;
            RegisterBtn.Location = new Point(45, 301);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(216, 42);
            RegisterBtn.TabIndex = 15;
            RegisterBtn.Text = "LOGIN";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // CheckBxShowPassword
            // 
            CheckBxShowPassword.AutoSize = true;
            CheckBxShowPassword.Location = new Point(146, 258);
            CheckBxShowPassword.Name = "CheckBxShowPassword";
            CheckBxShowPassword.Size = new Size(122, 21);
            CheckBxShowPassword.TabIndex = 13;
            CheckBxShowPassword.Text = "Show Password";
            CheckBxShowPassword.UseVisualStyleBackColor = true;
            CheckBxShowPassword.CheckedChanged += CheckBxShowPassword_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(45, 200);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(216, 28);
            txtPassword.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 180);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(45, 133);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 28);
            txtUsername.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 113);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 9;
            label1.Text = "Username";
            // 
            // Get
            // 
            Get.AutoSize = true;
            Get.Font = new Font("MS Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Get.ForeColor = Color.FromArgb(116, 86, 184);
            Get.Location = new Point(39, 62);
            Get.Name = "Get";
            Get.Size = new Size(177, 27);
            Get.TabIndex = 6;
            Get.Text = "Get Started";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(307, 572);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ClearBtn);
            Controls.Add(RegisterBtn);
            Controls.Add(CheckBxShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(Get);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Button ClearBtn;
        private Button RegisterBtn;
        private CheckBox CheckBxShowPassword;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtUsername;
        private Label label1;
        private Label Get;
    }
}