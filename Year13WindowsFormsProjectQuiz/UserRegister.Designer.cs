namespace Year13WindowsFormsProjectQuiz
{
    partial class UserRegister
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
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            Female = new RadioButton();
            ResetButton = new Button();
            FirstNameBox = new TextBox();
            RegisterButton = new Button();
            FirstName = new Label();
            Male = new RadioButton();
            Surname = new Label();
            DateOfBirth = new Label();
            RegisterPassword = new Label();
            Gender = new Label();
            SurnameBox = new TextBox();
            RegisterUsername = new Label();
            UsernameBox = new TextBox();
            PasswordBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Tanker", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(665, 86);
            label1.TabIndex = 16;
            label1.Text = "Register";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(369, 272);
            dateTimePicker1.Margin = new Padding(5, 4, 5, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(190, 41);
            dateTimePicker1.TabIndex = 0;
            // 
            // Female
            // 
            Female.AutoSize = true;
            Female.ForeColor = SystemColors.ControlLightLight;
            Female.Location = new Point(380, 178);
            Female.Margin = new Padding(5, 4, 5, 4);
            Female.Name = "Female";
            Female.Size = new Size(131, 36);
            Female.TabIndex = 2;
            Female.TabStop = true;
            Female.Text = "Female";
            Female.UseVisualStyleBackColor = true;
            Female.CheckedChanged += Female_CheckedChanged;
            // 
            // ResetButton
            // 
            ResetButton.BackColor = Color.Gainsboro;
            ResetButton.Location = new Point(369, 381);
            ResetButton.Margin = new Padding(5, 4, 5, 4);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(168, 44);
            ResetButton.TabIndex = 15;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            // 
            // FirstNameBox
            // 
            FirstNameBox.Location = new Point(154, 98);
            FirstNameBox.Margin = new Padding(5, 4, 5, 4);
            FirstNameBox.Name = "FirstNameBox";
            FirstNameBox.Size = new Size(197, 41);
            FirstNameBox.TabIndex = 3;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.Gainsboro;
            RegisterButton.Location = new Point(102, 381);
            RegisterButton.Margin = new Padding(5, 4, 5, 4);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(168, 44);
            RegisterButton.TabIndex = 14;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Font = new Font("false", 12F, FontStyle.Bold);
            FirstName.ForeColor = Color.Snow;
            FirstName.Location = new Point(4, 98);
            FirstName.Margin = new Padding(5, 0, 5, 0);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(148, 32);
            FirstName.TabIndex = 4;
            FirstName.Text = "First name";
            // 
            // Male
            // 
            Male.AutoSize = true;
            Male.ForeColor = SystemColors.ControlLightLight;
            Male.Location = new Point(380, 141);
            Male.Margin = new Padding(5, 4, 5, 4);
            Male.Name = "Male";
            Male.Size = new Size(101, 36);
            Male.TabIndex = 13;
            Male.TabStop = true;
            Male.Text = "Male";
            Male.UseVisualStyleBackColor = true;
            Male.CheckedChanged += Male_CheckedChanged;
            // 
            // Surname
            // 
            Surname.AutoSize = true;
            Surname.Font = new Font("false", 12F, FontStyle.Bold);
            Surname.ForeColor = Color.Snow;
            Surname.Location = new Point(4, 163);
            Surname.Margin = new Padding(5, 0, 5, 0);
            Surname.Name = "Surname";
            Surname.Size = new Size(125, 32);
            Surname.TabIndex = 5;
            Surname.Text = "Surname";
            // 
            // DateOfBirth
            // 
            DateOfBirth.AutoSize = true;
            DateOfBirth.ForeColor = Color.AliceBlue;
            DateOfBirth.Location = new Point(369, 236);
            DateOfBirth.Margin = new Padding(5, 0, 5, 0);
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.Size = new Size(179, 32);
            DateOfBirth.TabIndex = 12;
            DateOfBirth.Text = "Date of Birth";
            // 
            // RegisterPassword
            // 
            RegisterPassword.AutoSize = true;
            RegisterPassword.Font = new Font("false", 12F, FontStyle.Bold);
            RegisterPassword.ForeColor = Color.Snow;
            RegisterPassword.Location = new Point(4, 328);
            RegisterPassword.Margin = new Padding(5, 0, 5, 0);
            RegisterPassword.Name = "RegisterPassword";
            RegisterPassword.Size = new Size(131, 32);
            RegisterPassword.TabIndex = 6;
            RegisterPassword.Text = "Password";
            // 
            // Gender
            // 
            Gender.AutoSize = true;
            Gender.Font = new Font("false", 12F, FontStyle.Bold);
            Gender.ForeColor = SystemColors.ControlLightLight;
            Gender.Location = new Point(380, 98);
            Gender.Margin = new Padding(5, 0, 5, 0);
            Gender.Name = "Gender";
            Gender.Size = new Size(103, 32);
            Gender.TabIndex = 11;
            Gender.Text = "Gender";
            // 
            // SurnameBox
            // 
            SurnameBox.Location = new Point(154, 163);
            SurnameBox.Margin = new Padding(5, 4, 5, 4);
            SurnameBox.Name = "SurnameBox";
            SurnameBox.Size = new Size(197, 41);
            SurnameBox.TabIndex = 7;
            // 
            // RegisterUsername
            // 
            RegisterUsername.AutoSize = true;
            RegisterUsername.Font = new Font("false", 12F, FontStyle.Bold);
            RegisterUsername.ForeColor = Color.Snow;
            RegisterUsername.Location = new Point(4, 258);
            RegisterUsername.Margin = new Padding(5, 0, 5, 0);
            RegisterUsername.Name = "RegisterUsername";
            RegisterUsername.Size = new Size(139, 32);
            RegisterUsername.TabIndex = 10;
            RegisterUsername.Text = "Username";
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(154, 258);
            UsernameBox.Margin = new Padding(5, 4, 5, 4);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(197, 41);
            UsernameBox.TabIndex = 8;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(154, 328);
            PasswordBox.Margin = new Padding(5, 4, 5, 4);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(197, 41);
            PasswordBox.TabIndex = 9;
            // 
            // UserRegister
            // 
            AutoScaleDimensions = new SizeF(15F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(665, 427);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(Female);
            Controls.Add(PasswordBox);
            Controls.Add(ResetButton);
            Controls.Add(UsernameBox);
            Controls.Add(FirstNameBox);
            Controls.Add(RegisterUsername);
            Controls.Add(RegisterButton);
            Controls.Add(SurnameBox);
            Controls.Add(FirstName);
            Controls.Add(Gender);
            Controls.Add(Male);
            Controls.Add(RegisterPassword);
            Controls.Add(Surname);
            Controls.Add(DateOfBirth);
            Font = new Font("false", 12F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "UserRegister";
            Text = "UserRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private RadioButton Female;
        private Button ResetButton;
        private TextBox FirstNameBox;
        private Button RegisterButton;
        private Label FirstName;
        private RadioButton Male;
        private Label Surname;
        private Label DateOfBirth;
        private Label RegisterPassword;
        private Label Gender;
        private TextBox SurnameBox;
        private Label RegisterUsername;
        private TextBox UsernameBox;
        private TextBox PasswordBox;
    }
}