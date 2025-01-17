namespace Year13WindowsFormsProjectQuiz
{
    partial class UserLogin
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
            LoginPanel = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            username = new Label();
            password = new Label();
            login = new Label();
            button1 = new Button();
            LoginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginPanel
            // 
            LoginPanel.AutoSize = true;
            LoginPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoginPanel.BackColor = Color.FromArgb(35, 35, 35);
            LoginPanel.BackgroundImageLayout = ImageLayout.Stretch;
            LoginPanel.Controls.Add(textBox2);
            LoginPanel.Controls.Add(textBox1);
            LoginPanel.Controls.Add(username);
            LoginPanel.Controls.Add(password);
            LoginPanel.Controls.Add(login);
            LoginPanel.Controls.Add(button1);
            LoginPanel.Dock = DockStyle.Fill;
            LoginPanel.Location = new Point(0, 0);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(559, 427);
            LoginPanel.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.ImeMode = ImeMode.NoControl;
            textBox2.Location = new Point(280, 262);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(270, 31);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(280, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 31);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // username
            // 
            username.BackColor = Color.Transparent;
            username.Font = new Font("false", 24F);
            username.ForeColor = SystemColors.ButtonHighlight;
            username.Location = new Point(9, 133);
            username.MinimumSize = new Size(200, 50);
            username.Name = "username";
            username.Size = new Size(265, 69);
            username.TabIndex = 7;
            username.Text = "Username";
            username.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // password
            // 
            password.BackColor = Color.Transparent;
            password.Font = new Font("false", 24F);
            password.ForeColor = SystemColors.ButtonHighlight;
            password.Location = new Point(3, 241);
            password.MinimumSize = new Size(200, 50);
            password.Name = "password";
            password.Size = new Size(259, 74);
            password.TabIndex = 8;
            password.Text = "Password";
            password.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // login
            // 
            login.BackColor = Color.Transparent;
            login.Dock = DockStyle.Top;
            login.Font = new Font("Tanker", 47.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login.ForeColor = SystemColors.ButtonHighlight;
            login.Location = new Point(0, 0);
            login.Name = "login";
            login.Size = new Size(559, 133);
            login.TabIndex = 1;
            login.Text = "LOGIN";
            login.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.PaleGreen;
            button1.Location = new Point(179, 318);
            button1.Name = "button1";
            button1.Size = new Size(194, 97);
            button1.TabIndex = 11;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(559, 427);
            Controls.Add(LoginPanel);
            ForeColor = SystemColors.AppWorkspace;
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserLogin";
            Text = "UserLogin";
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel LoginPanel;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label username;
        private Label password;
        private Button button1;
        private Label login;
    }
}