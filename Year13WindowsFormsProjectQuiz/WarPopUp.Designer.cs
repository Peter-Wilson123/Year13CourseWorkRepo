namespace Year13WindowsFormsProjectQuiz
{
    partial class WarPopUp
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
            YesButton = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // YesButton
            // 
            YesButton.BackColor = Color.LightGreen;
            YesButton.FlatAppearance.BorderColor = Color.Black;
            YesButton.FlatAppearance.BorderSize = 5;
            YesButton.FlatStyle = FlatStyle.Flat;
            YesButton.Font = new Font("Tanker", 20F, FontStyle.Bold);
            YesButton.Location = new Point(68, 189);
            YesButton.Name = "YesButton";
            YesButton.Size = new Size(122, 84);
            YesButton.TabIndex = 0;
            YesButton.Text = "YES";
            YesButton.UseMnemonic = false;
            YesButton.UseVisualStyleBackColor = false;
            YesButton.Click += YesButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Tomato;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.BorderSize = 5;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tanker", 20F, FontStyle.Bold);
            button2.Location = new Point(266, 189);
            button2.Name = "button2";
            button2.Size = new Size(127, 84);
            button2.TabIndex = 1;
            button2.Text = "NO";
            button2.UseMnemonic = false;
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Tanker", 47.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(439, 121);
            label1.TabIndex = 2;
            label1.Text = "Alert!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Tanker", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 121);
            label2.Name = "label2";
            label2.Size = new Size(439, 50);
            label2.TabIndex = 3;
            label2.Text = "Do you wish to invade?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WarPopUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(439, 295);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(YesButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "WarPopUp";
            Text = "WarPopUp";
            Load += WarPopUp_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button YesButton;
        private Button button2;
        private Label label1;
        private Label label2;
    }
}