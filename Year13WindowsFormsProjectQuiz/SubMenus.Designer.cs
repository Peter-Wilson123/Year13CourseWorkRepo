namespace Year13WindowsFormsProjectQuiz
{
    partial class SubMenus
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
            label4 = new Label();
            hScrollBar2 = new HScrollBar();
            hScrollBar1 = new HScrollBar();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.ForeColor = Color.Cornsilk;
            label4.Location = new Point(206, 139);
            label4.Name = "label4";
            label4.Size = new Size(130, 25);
            label4.TabIndex = 6;
            label4.Text = "Change Colour";
            // 
            // hScrollBar2
            // 
            hScrollBar2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            hScrollBar2.Location = new Point(82, 302);
            hScrollBar2.Name = "hScrollBar2";
            hScrollBar2.Size = new Size(395, 55);
            hScrollBar2.TabIndex = 5;
            hScrollBar2.Scroll += hScrollBar2_Scroll;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            hScrollBar1.Location = new Point(82, 176);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.RightToLeft = RightToLeft.No;
            hScrollBar1.Size = new Size(395, 55);
            hScrollBar1.TabIndex = 4;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = Color.Cornsilk;
            label3.Location = new Point(177, 268);
            label3.Name = "label3";
            label3.Size = new Size(179, 25);
            label3.TabIndex = 3;
            label3.Text = "Change Transparancy";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.Font = new Font("Segoe UI", 30F);
            label2.ForeColor = Color.Cornsilk;
            label2.Location = new Point(149, 27);
            label2.Name = "label2";
            label2.Size = new Size(265, 97);
            label2.TabIndex = 0;
            label2.Text = "Settings";
            label2.Click += label2_Click;
            // 
            // SubMenus
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(559, 427);
            Controls.Add(label4);
            Controls.Add(hScrollBar2);
            Controls.Add(hScrollBar1);
            Controls.Add(label2);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SubMenus";
            Text = "SubMenus";
            Load += SubMenus_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private HScrollBar hScrollBar2;
        private HScrollBar hScrollBar1;
        private Label label3;
        private Label label2;
    }
}