namespace Year13WindowsFormsProjectQuiz
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            LoadingBar = new Panel();
            Title = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // LoadingBar
            // 
            LoadingBar.BackColor = SystemColors.Desktop;
            LoadingBar.Location = new Point(-5, 427);
            LoadingBar.Name = "LoadingBar";
            LoadingBar.Size = new Size(32, 25);
            LoadingBar.TabIndex = 0;
            LoadingBar.Paint += LoadingBar_Paint;
            // 
            // Title
            // 
            Title.Font = new Font("Segoe UI", 50F);
            Title.Location = new Point(81, 9);
            Title.Name = "Title";
            Title.Size = new Size(617, 273);
            Title.TabIndex = 1;
            Title.Text = "QUIZ GAME NAME HERE";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Title);
            Controls.Add(LoadingBar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel LoadingBar;
        private Label Title;
        private System.Windows.Forms.Timer timer1;
    }
}
