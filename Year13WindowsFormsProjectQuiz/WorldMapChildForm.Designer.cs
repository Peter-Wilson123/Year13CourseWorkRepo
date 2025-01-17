namespace Year13WindowsFormsProjectQuiz
{
    partial class WorldMapChildForm
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
            panel1 = new Panel();
            button6 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.BackgroundImage = Properties.Resources.pixil_frame_0;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(728, 724);
            panel1.TabIndex = 0;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button6.BackColor = Color.Transparent;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Impact", 18F);
            button6.Location = new Point(462, 110);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(195, 75);
            button6.TabIndex = 26;
            button6.Text = "Medium";
            button6.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.AutoSize = true;
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Impact", 18F);
            button3.Location = new Point(51, 538);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(205, 54);
            button3.TabIndex = 28;
            button3.Text = "Medium";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoSize = true;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Impact", 18F);
            button2.Location = new Point(215, 67);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(99, 54);
            button2.TabIndex = 24;
            button2.Text = "Hard";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSize = true;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Impact", 18F);
            button1.Location = new Point(242, 258);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(224, 54);
            button1.TabIndex = 27;
            button1.Text = "YourCountry";
            button1.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.AutoSize = true;
            button5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Impact", 18F);
            button5.Location = new Point(592, 490);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(95, 54);
            button5.TabIndex = 25;
            button5.Text = "Easy";
            button5.UseVisualStyleBackColor = false;
            // 
            // WorldMapChildForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 724);
            Controls.Add(panel1);
            Name = "WorldMapChildForm";
            Text = "WorldMapChildForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button6;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button5;
    }
}