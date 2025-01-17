namespace Year13WindowsFormsProjectQuiz
{
    partial class Germany
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
            label3 = new Label();
            label1 = new Label();
            WestGermany = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.BackgroundImage = Properties.Resources.pixil_frame_0_7_;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(WestGermany);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.MinimumSize = new Size(800, 600);
            panel1.Name = "panel1";
            panel1.Size = new Size(1156, 744);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(751, 304);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(145, 42);
            label3.TabIndex = 19;
            label3.Text = "Capital Germany";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(622, 660);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(148, 57);
            label1.TabIndex = 17;
            label1.Text = "South Germany";
            // 
            // WestGermany
            // 
            WestGermany.Anchor = AnchorStyles.None;
            WestGermany.BackColor = Color.Transparent;
            WestGermany.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WestGermany.Location = new Point(471, 430);
            WestGermany.Margin = new Padding(0);
            WestGermany.Name = "WestGermany";
            WestGermany.Size = new Size(239, 58);
            WestGermany.TabIndex = 16;
            WestGermany.Text = "West Germany";
            WestGermany.Click += label9_Click;
            // 
            // Germany
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1156, 744);
            Controls.Add(panel1);
            DoubleBuffered = true;
            MinimumSize = new Size(800, 800);
            Name = "Germany";
            Text = "Germany";
            Load += Germany_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label1;
        private Label WestGermany;
    }
}