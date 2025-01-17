namespace Year13WindowsFormsProjectQuiz
{
    partial class GameMenu
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Tanker", 40F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 24);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(352, 101);
            label1.TabIndex = 0;
            label1.Text = "GameMenu";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.PaleGreen;
            button1.Location = new Point(215, 128);
            button1.Name = "button1";
            button1.Size = new Size(125, 65);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.Gainsboro;
            button2.Location = new Point(162, 363);
            button2.Name = "button2";
            button2.Size = new Size(233, 52);
            button2.TabIndex = 2;
            button2.Text = "Load";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = Color.Gainsboro;
            button3.Location = new Point(162, 289);
            button3.Name = "button3";
            button3.Size = new Size(233, 52);
            button3.TabIndex = 3;
            button3.Text = "Load";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button4.BackColor = Color.Gainsboro;
            button4.Location = new Point(162, 215);
            button4.Name = "button4";
            button4.Size = new Size(233, 52);
            button4.TabIndex = 4;
            button4.Text = "Load";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // GameMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 427);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GameMenu";
            Text = "GameMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}