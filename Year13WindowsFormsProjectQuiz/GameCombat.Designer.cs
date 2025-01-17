namespace Year13WindowsFormsProjectQuiz
{
    partial class GameCombat
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
            Question = new Label();
            ModifierDisplay = new Label();
            AttacksDisplay = new Label();
            AttackButton = new Button();
            RetreatButton = new Button();
            Question3 = new Label();
            Question1 = new Label();
            Question2 = new Label();
            Question4 = new Label();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Aktura", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1327, 96);
            label1.TabIndex = 0;
            label1.Text = "The Invasion of _________";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Question
            // 
            Question.BackColor = Color.Transparent;
            Question.Dock = DockStyle.Top;
            Question.Font = new Font("Tanker", 18F);
            Question.Location = new Point(0, 96);
            Question.Name = "Question";
            Question.Size = new Size(1327, 45);
            Question.TabIndex = 2;
            Question.Text = "Where question text will be";
            Question.TextAlign = ContentAlignment.MiddleCenter;
            Question.Click += Question_Click;
            // 
            // ModifierDisplay
            // 
            ModifierDisplay.AutoSize = true;
            ModifierDisplay.BackColor = Color.Transparent;
            ModifierDisplay.Font = new Font("Tanker", 15.9999981F);
            ModifierDisplay.Location = new Point(986, 396);
            ModifierDisplay.Name = "ModifierDisplay";
            ModifierDisplay.Size = new Size(285, 40);
            ModifierDisplay.TabIndex = 5;
            ModifierDisplay.Text = "Chance of Success: 0%";
            ModifierDisplay.Click += label4_Click;
            // 
            // AttacksDisplay
            // 
            AttacksDisplay.AutoSize = true;
            AttacksDisplay.BackColor = Color.Transparent;
            AttacksDisplay.Font = new Font("Tanker", 15.9999981F);
            AttacksDisplay.Location = new Point(108, 396);
            AttacksDisplay.Name = "AttacksDisplay";
            AttacksDisplay.Size = new Size(157, 40);
            AttacksDisplay.TabIndex = 6;
            AttacksDisplay.Text = "Attacks 0/3";
            // 
            // AttackButton
            // 
            AttackButton.BackColor = Color.Transparent;
            AttackButton.Font = new Font("Tanker", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AttackButton.Location = new Point(707, 396);
            AttackButton.Name = "AttackButton";
            AttackButton.Size = new Size(148, 67);
            AttackButton.TabIndex = 7;
            AttackButton.Text = "Attack";
            AttackButton.UseVisualStyleBackColor = false;
            AttackButton.Click += AttackButton_Click;
            // 
            // RetreatButton
            // 
            RetreatButton.BackColor = Color.Transparent;
            RetreatButton.Font = new Font("Tanker", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RetreatButton.Location = new Point(472, 396);
            RetreatButton.Name = "RetreatButton";
            RetreatButton.Size = new Size(148, 67);
            RetreatButton.TabIndex = 8;
            RetreatButton.Text = "Retreat";
            RetreatButton.UseVisualStyleBackColor = false;
            RetreatButton.Click += RetreatButton_Click;
            // 
            // Question3
            // 
            Question3.Anchor = AnchorStyles.None;
            Question3.AutoSize = true;
            Question3.BackColor = Color.Transparent;
            Question3.Font = new Font("Tanker", 15.9999981F);
            Question3.Location = new Point(120, 33);
            Question3.Name = "Question3";
            Question3.Size = new Size(90, 40);
            Question3.TabIndex = 11;
            Question3.Text = "blank";
            Question3.TextAlign = ContentAlignment.MiddleCenter;
            Question3.Click += Question3_Click;
            // 
            // Question1
            // 
            Question1.Anchor = AnchorStyles.None;
            Question1.AutoSize = true;
            Question1.BackColor = Color.Transparent;
            Question1.Font = new Font("Tanker", 15.9999981F);
            Question1.Location = new Point(451, 33);
            Question1.Name = "Question1";
            Question1.Size = new Size(90, 40);
            Question1.TabIndex = 9;
            Question1.Text = "blank";
            Question1.TextAlign = ContentAlignment.MiddleCenter;
            Question1.Click += Question1_Click;
            // 
            // Question2
            // 
            Question2.Anchor = AnchorStyles.None;
            Question2.AutoSize = true;
            Question2.BackColor = Color.Transparent;
            Question2.Font = new Font("Tanker", 15.9999981F);
            Question2.Location = new Point(782, 33);
            Question2.Name = "Question2";
            Question2.Size = new Size(90, 40);
            Question2.TabIndex = 10;
            Question2.Text = "blank";
            Question2.TextAlign = ContentAlignment.MiddleCenter;
            Question2.Click += Question2_Click;
            // 
            // Question4
            // 
            Question4.Anchor = AnchorStyles.None;
            Question4.AutoSize = true;
            Question4.BackColor = Color.Transparent;
            Question4.Font = new Font("Tanker", 15.9999981F);
            Question4.Location = new Point(1115, 33);
            Question4.Name = "Question4";
            Question4.Size = new Size(90, 40);
            Question4.TabIndex = 12;
            Question4.Text = "blank";
            Question4.TextAlign = ContentAlignment.MiddleCenter;
            Question4.Click += Question4_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Free_Nature_Backgrounds_Pixel_Art31;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(Question);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(RetreatButton);
            panel1.Controls.Add(AttackButton);
            panel1.Controls.Add(AttacksDisplay);
            panel1.Controls.Add(ModifierDisplay);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1327, 627);
            panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(Question4, 3, 0);
            tableLayoutPanel1.Controls.Add(Question2, 2, 0);
            tableLayoutPanel1.Controls.Add(Question1, 1, 0);
            tableLayoutPanel1.Controls.Add(Question3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 141);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1327, 107);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // GameCombat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 627);
            Controls.Add(panel1);
            Name = "GameCombat";
            Text = "GameCombat";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label Question;
        private Label ModifierDisplay;
        private Label AttacksDisplay;
        private Button AttackButton;
        private Button RetreatButton;
        private Label Question1;
        private Label Question2;
        private Label Question3;
        private Label Question4;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}