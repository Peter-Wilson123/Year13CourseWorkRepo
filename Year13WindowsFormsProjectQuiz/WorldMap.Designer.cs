namespace Year13WindowsFormsProjectQuiz
{
    partial class WorldMap
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
            button9 = new Button();
            M = new Label();
            R = new Label();
            Mill = new Label();
            button8 = new Button();
            button4 = new Button();
            button7 = new Button();
            panelChildForm = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            StatsResults = new Label();
            panel3 = new Panel();
            CountryDropDownMenu = new Panel();
            GoToWorldMap = new Button();
            GoToFrance = new Button();
            GoToEngland = new Button();
            GoToGermany = new Button();
            GoToItaly = new Button();
            label1 = new Label();
            GoToSpain = new Button();
            panel1.SuspendLayout();
            panelChildForm.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            CountryDropDownMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuBar;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button9);
            panel1.Controls.Add(M);
            panel1.Controls.Add(R);
            panel1.Controls.Add(Mill);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1178, 43);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Left;
            button9.Font = new Font("Aktura", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(666, 0);
            button9.Name = "button9";
            button9.Size = new Size(222, 43);
            button9.TabIndex = 6;
            button9.Text = "Diplomacy";
            button9.UseVisualStyleBackColor = true;
            // 
            // M
            // 
            M.AutoSize = true;
            M.Dock = DockStyle.Right;
            M.Font = new Font("Tanker", 10F);
            M.ForeColor = Color.Black;
            M.Location = new Point(958, 0);
            M.Name = "M";
            M.Size = new Size(59, 25);
            M.TabIndex = 5;
            M.Text = "Money";
            // 
            // R
            // 
            R.AutoSize = true;
            R.Dock = DockStyle.Right;
            R.Font = new Font("Tanker", 10F);
            R.ForeColor = Color.Black;
            R.Location = new Point(1017, 0);
            R.Name = "R";
            R.Size = new Size(83, 25);
            R.TabIndex = 4;
            R.Text = "Research";
            // 
            // Mill
            // 
            Mill.AutoSize = true;
            Mill.Dock = DockStyle.Right;
            Mill.Font = new Font("Tanker", 10F);
            Mill.ForeColor = Color.Black;
            Mill.Location = new Point(1100, 0);
            Mill.Name = "Mill";
            Mill.Size = new Size(78, 25);
            Mill.TabIndex = 3;
            Mill.Text = "Millitary";
            // 
            // button8
            // 
            button8.Dock = DockStyle.Left;
            button8.Font = new Font("Aktura", 11.999999F);
            button8.Location = new Point(444, 0);
            button8.Name = "button8";
            button8.Size = new Size(222, 43);
            button8.TabIndex = 2;
            button8.Text = "Research";
            button8.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Left;
            button4.Font = new Font("Aktura", 11.999999F);
            button4.Location = new Point(222, 0);
            button4.Name = "button4";
            button4.Size = new Size(222, 43);
            button4.TabIndex = 1;
            button4.Text = "Economy";
            button4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Left;
            button7.Font = new Font("Aktura", 11.999999F);
            button7.Location = new Point(0, 0);
            button7.Name = "button7";
            button7.Size = new Size(222, 43);
            button7.TabIndex = 0;
            button7.Text = "Countries";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Countrys_Click;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.AliceBlue;
            panelChildForm.BackgroundImageLayout = ImageLayout.Zoom;
            panelChildForm.Controls.Add(panel4);
            panelChildForm.Controls.Add(panel3);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(0, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1178, 744);
            panelChildForm.TabIndex = 17;
            panelChildForm.Paint += panel2_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Controls.Add(label2);
            panel4.Controls.Add(StatsResults);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(956, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(222, 744);
            panel4.TabIndex = 21;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Tanker", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(0, 104);
            label2.Name = "label2";
            label2.Size = new Size(222, 207);
            label2.TabIndex = 3;
            label2.Text = "France: 0,0,0 England: 0,0,0 Germany: 0,0,0 Italy: 0,0,0   Spain: 0,0,0";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StatsResults
            // 
            StatsResults.BackColor = Color.Black;
            StatsResults.Dock = DockStyle.Top;
            StatsResults.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StatsResults.ForeColor = SystemColors.Control;
            StatsResults.Location = new Point(0, 0);
            StatsResults.Name = "StatsResults";
            StatsResults.Size = new Size(222, 104);
            StatsResults.TabIndex = 0;
            StatsResults.Text = "0 , 0 , 0";
            StatsResults.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(CountryDropDownMenu);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(222, 744);
            panel3.TabIndex = 20;
            // 
            // CountryDropDownMenu
            // 
            CountryDropDownMenu.BackColor = Color.AliceBlue;
            CountryDropDownMenu.Controls.Add(GoToWorldMap);
            CountryDropDownMenu.Controls.Add(GoToFrance);
            CountryDropDownMenu.Controls.Add(GoToEngland);
            CountryDropDownMenu.Controls.Add(GoToGermany);
            CountryDropDownMenu.Controls.Add(GoToItaly);
            CountryDropDownMenu.Controls.Add(label1);
            CountryDropDownMenu.Controls.Add(GoToSpain);
            CountryDropDownMenu.Dock = DockStyle.Top;
            CountryDropDownMenu.ForeColor = Color.CornflowerBlue;
            CountryDropDownMenu.Location = new Point(0, 0);
            CountryDropDownMenu.Name = "CountryDropDownMenu";
            CountryDropDownMenu.Size = new Size(222, 298);
            CountryDropDownMenu.TabIndex = 0;
            CountryDropDownMenu.Visible = false;
            // 
            // GoToWorldMap
            // 
            GoToWorldMap.BackColor = Color.White;
            GoToWorldMap.Dock = DockStyle.Bottom;
            GoToWorldMap.Font = new Font("Aktura", 11.999999F);
            GoToWorldMap.ForeColor = SystemColors.ActiveCaptionText;
            GoToWorldMap.Location = new Point(0, 40);
            GoToWorldMap.Name = "GoToWorldMap";
            GoToWorldMap.Size = new Size(222, 43);
            GoToWorldMap.TabIndex = 7;
            GoToWorldMap.Text = "WorldMap";
            GoToWorldMap.UseVisualStyleBackColor = false;
            GoToWorldMap.Click += GoToWorldMap_Click;
            // 
            // GoToFrance
            // 
            GoToFrance.BackColor = Color.White;
            GoToFrance.Dock = DockStyle.Bottom;
            GoToFrance.Font = new Font("Aktura", 11.999999F);
            GoToFrance.ForeColor = SystemColors.ActiveCaptionText;
            GoToFrance.Location = new Point(0, 83);
            GoToFrance.Name = "GoToFrance";
            GoToFrance.Size = new Size(222, 43);
            GoToFrance.TabIndex = 6;
            GoToFrance.Text = "France";
            GoToFrance.UseVisualStyleBackColor = false;
            GoToFrance.Click += GoToFrance_Click;
            // 
            // GoToEngland
            // 
            GoToEngland.BackColor = Color.White;
            GoToEngland.Dock = DockStyle.Bottom;
            GoToEngland.Font = new Font("Aktura", 11.999999F);
            GoToEngland.ForeColor = SystemColors.ActiveCaptionText;
            GoToEngland.Location = new Point(0, 126);
            GoToEngland.Name = "GoToEngland";
            GoToEngland.Size = new Size(222, 43);
            GoToEngland.TabIndex = 5;
            GoToEngland.Text = "England";
            GoToEngland.UseVisualStyleBackColor = false;
            // 
            // GoToGermany
            // 
            GoToGermany.BackColor = Color.White;
            GoToGermany.Dock = DockStyle.Bottom;
            GoToGermany.Font = new Font("Aktura", 11.999999F);
            GoToGermany.ForeColor = SystemColors.ActiveCaptionText;
            GoToGermany.Location = new Point(0, 169);
            GoToGermany.Name = "GoToGermany";
            GoToGermany.Size = new Size(222, 43);
            GoToGermany.TabIndex = 4;
            GoToGermany.Text = "Germany";
            GoToGermany.UseVisualStyleBackColor = false;
            GoToGermany.Click += GoToGermany_Click;
            // 
            // GoToItaly
            // 
            GoToItaly.BackColor = Color.White;
            GoToItaly.Dock = DockStyle.Bottom;
            GoToItaly.Font = new Font("Aktura", 11.999999F);
            GoToItaly.ForeColor = SystemColors.ActiveCaptionText;
            GoToItaly.Location = new Point(0, 212);
            GoToItaly.Name = "GoToItaly";
            GoToItaly.Size = new Size(222, 43);
            GoToItaly.TabIndex = 3;
            GoToItaly.Text = "Italy";
            GoToItaly.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(222, 43);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // GoToSpain
            // 
            GoToSpain.BackColor = Color.White;
            GoToSpain.Dock = DockStyle.Bottom;
            GoToSpain.Font = new Font("Aktura", 11.999999F);
            GoToSpain.ForeColor = SystemColors.ActiveCaptionText;
            GoToSpain.Location = new Point(0, 255);
            GoToSpain.Name = "GoToSpain";
            GoToSpain.Size = new Size(222, 43);
            GoToSpain.TabIndex = 1;
            GoToSpain.Text = "Spain";
            GoToSpain.UseVisualStyleBackColor = false;
            GoToSpain.Click += button10_Click;
            // 
            // WorldMap
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1178, 744);
            Controls.Add(panel1);
            Controls.Add(panelChildForm);
            MinimumSize = new Size(1200, 800);
            Name = "WorldMap";
            Text = "WorldMap";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelChildForm.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            CountryDropDownMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button7;
        private Button button8;
        private Button button4;
        private Label M;
        private Label R;
        private Label Mill;
        private Panel panelChildForm;
        private Panel panel4;
        private Panel panel3;
        private Button button9;
        private Panel CountryDropDownMenu;
        private Label label1;
        private Button button10;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button GoToFrance;
        private Button GoToEngland;
        private Button GoToGermany;
        private Button GoToItaly;
        private Button GoToSpain;
        private Button GoToWorldMap;
        private Label Rresult;
        private Label Millresult;
        private Label StatsResults;
        private Label label2;
    }
}