namespace DanielleRodriguez_CPT_206_Project
{
    partial class Dice_Roller_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dice_Roller_Form));
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.gboxResults = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lboxRolls = new System.Windows.Forms.ListBox();
            this.lblOutputTotalOfRoll = new System.Windows.Forms.Label();
            this.gboxChooseDice = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRollRice = new System.Windows.Forms.Button();
            this.lblNumberOfDice = new System.Windows.Forms.Label();
            this.btnD2 = new System.Windows.Forms.Button();
            this.btnPercentage = new System.Windows.Forms.Button();
            this.btnD10 = new System.Windows.Forms.Button();
            this.btnD12 = new System.Windows.Forms.Button();
            this.btnD8 = new System.Windows.Forms.Button();
            this.btnD6 = new System.Windows.Forms.Button();
            this.btnD4 = new System.Windows.Forms.Button();
            this.btnD20 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTitleBar.SuspendLayout();
            this.gboxResults.SuspendLayout();
            this.gboxChooseDice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(85)))), ((int)(((byte)(62)))));
            this.pnlTitleBar.Controls.Add(this.btnExit);
            this.pnlTitleBar.Controls.Add(this.lblProjectTitle);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1247, 35);
            this.pnlTitleBar.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1214, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 25);
            this.btnExit.TabIndex = 8;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.AutoSize = true;
            this.lblProjectTitle.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTitle.ForeColor = System.Drawing.Color.White;
            this.lblProjectTitle.Location = new System.Drawing.Point(6, 4);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(100, 23);
            this.lblProjectTitle.TabIndex = 2;
            this.lblProjectTitle.Text = "Dice Roller";
            // 
            // gboxResults
            // 
            this.gboxResults.Controls.Add(this.btnClear);
            this.gboxResults.Controls.Add(this.label3);
            this.gboxResults.Controls.Add(this.label2);
            this.gboxResults.Controls.Add(this.lboxRolls);
            this.gboxResults.Controls.Add(this.lblOutputTotalOfRoll);
            this.gboxResults.Location = new System.Drawing.Point(850, 41);
            this.gboxResults.Name = "gboxResults";
            this.gboxResults.Size = new System.Drawing.Size(385, 103);
            this.gboxResults.TabIndex = 14;
            this.gboxResults.TabStop = false;
            this.gboxResults.Text = "Results";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(295, 43);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(52, 33);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Detailed Rolls";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Total";
            // 
            // lboxRolls
            // 
            this.lboxRolls.FormattingEnabled = true;
            this.lboxRolls.ItemHeight = 15;
            this.lboxRolls.Location = new System.Drawing.Point(160, 31);
            this.lboxRolls.Name = "lboxRolls";
            this.lboxRolls.Size = new System.Drawing.Size(120, 64);
            this.lboxRolls.TabIndex = 25;
            // 
            // lblOutputTotalOfRoll
            // 
            this.lblOutputTotalOfRoll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputTotalOfRoll.Location = new System.Drawing.Point(54, 32);
            this.lblOutputTotalOfRoll.Name = "lblOutputTotalOfRoll";
            this.lblOutputTotalOfRoll.Size = new System.Drawing.Size(77, 63);
            this.lblOutputTotalOfRoll.TabIndex = 24;
            this.lblOutputTotalOfRoll.Text = "##";
            this.lblOutputTotalOfRoll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gboxChooseDice
            // 
            this.gboxChooseDice.Controls.Add(this.pictureBox2);
            this.gboxChooseDice.Controls.Add(this.btnRollRice);
            this.gboxChooseDice.Controls.Add(this.lblNumberOfDice);
            this.gboxChooseDice.Controls.Add(this.btnD2);
            this.gboxChooseDice.Controls.Add(this.btnPercentage);
            this.gboxChooseDice.Controls.Add(this.btnD10);
            this.gboxChooseDice.Controls.Add(this.btnD12);
            this.gboxChooseDice.Controls.Add(this.btnD8);
            this.gboxChooseDice.Controls.Add(this.btnD6);
            this.gboxChooseDice.Controls.Add(this.btnD4);
            this.gboxChooseDice.Controls.Add(this.btnD20);
            this.gboxChooseDice.Controls.Add(this.pictureBox1);
            this.gboxChooseDice.Location = new System.Drawing.Point(10, 41);
            this.gboxChooseDice.Name = "gboxChooseDice";
            this.gboxChooseDice.Size = new System.Drawing.Size(834, 103);
            this.gboxChooseDice.TabIndex = 0;
            this.gboxChooseDice.TabStop = false;
            this.gboxChooseDice.Text = "Choose Your Dice!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(643, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // btnRollRice
            // 
            this.btnRollRice.Font = new System.Drawing.Font("Corbel", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollRice.Location = new System.Drawing.Point(711, 29);
            this.btnRollRice.Name = "btnRollRice";
            this.btnRollRice.Size = new System.Drawing.Size(109, 47);
            this.btnRollRice.TabIndex = 24;
            this.btnRollRice.Text = "Roll it!";
            this.btnRollRice.UseVisualStyleBackColor = true;
            this.btnRollRice.Click += new System.EventHandler(this.btnRollRice_Click);
            // 
            // lblNumberOfDice
            // 
            this.lblNumberOfDice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumberOfDice.Location = new System.Drawing.Point(567, 29);
            this.lblNumberOfDice.Name = "lblNumberOfDice";
            this.lblNumberOfDice.Size = new System.Drawing.Size(70, 47);
            this.lblNumberOfDice.TabIndex = 23;
            this.lblNumberOfDice.Text = "##";
            this.lblNumberOfDice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnD2
            // 
            this.btnD2.Location = new System.Drawing.Point(464, 59);
            this.btnD2.Name = "btnD2";
            this.btnD2.Size = new System.Drawing.Size(80, 33);
            this.btnD2.TabIndex = 22;
            this.btnD2.Text = "d2";
            this.btnD2.UseVisualStyleBackColor = true;
            this.btnD2.Click += new System.EventHandler(this.btnD2_Click);
            // 
            // btnPercentage
            // 
            this.btnPercentage.Location = new System.Drawing.Point(464, 17);
            this.btnPercentage.Name = "btnPercentage";
            this.btnPercentage.Size = new System.Drawing.Size(80, 33);
            this.btnPercentage.TabIndex = 21;
            this.btnPercentage.Text = "Percentage";
            this.btnPercentage.UseVisualStyleBackColor = true;
            this.btnPercentage.Click += new System.EventHandler(this.btnPercentage_Click);
            // 
            // btnD10
            // 
            this.btnD10.Location = new System.Drawing.Point(363, 17);
            this.btnD10.Name = "btnD10";
            this.btnD10.Size = new System.Drawing.Size(80, 33);
            this.btnD10.TabIndex = 20;
            this.btnD10.Text = "d10";
            this.btnD10.UseVisualStyleBackColor = true;
            this.btnD10.Click += new System.EventHandler(this.btnD10_Click);
            // 
            // btnD12
            // 
            this.btnD12.Location = new System.Drawing.Point(363, 59);
            this.btnD12.Name = "btnD12";
            this.btnD12.Size = new System.Drawing.Size(80, 33);
            this.btnD12.TabIndex = 19;
            this.btnD12.Text = "d12";
            this.btnD12.UseVisualStyleBackColor = true;
            this.btnD12.Click += new System.EventHandler(this.btnD12_Click);
            // 
            // btnD8
            // 
            this.btnD8.Location = new System.Drawing.Point(262, 59);
            this.btnD8.Name = "btnD8";
            this.btnD8.Size = new System.Drawing.Size(80, 33);
            this.btnD8.TabIndex = 18;
            this.btnD8.Text = "d8";
            this.btnD8.UseVisualStyleBackColor = true;
            this.btnD8.Click += new System.EventHandler(this.btnD8_Click);
            // 
            // btnD6
            // 
            this.btnD6.Location = new System.Drawing.Point(262, 17);
            this.btnD6.Name = "btnD6";
            this.btnD6.Size = new System.Drawing.Size(80, 33);
            this.btnD6.TabIndex = 17;
            this.btnD6.Text = "d6";
            this.btnD6.UseVisualStyleBackColor = true;
            this.btnD6.Click += new System.EventHandler(this.btnD6_Click);
            // 
            // btnD4
            // 
            this.btnD4.Location = new System.Drawing.Point(161, 59);
            this.btnD4.Name = "btnD4";
            this.btnD4.Size = new System.Drawing.Size(80, 33);
            this.btnD4.TabIndex = 16;
            this.btnD4.Text = "d4";
            this.btnD4.UseVisualStyleBackColor = true;
            this.btnD4.Click += new System.EventHandler(this.btnD4_Click);
            // 
            // btnD20
            // 
            this.btnD20.Location = new System.Drawing.Point(161, 17);
            this.btnD20.Name = "btnD20";
            this.btnD20.Size = new System.Drawing.Size(80, 33);
            this.btnD20.TabIndex = 15;
            this.btnD20.Text = "d20";
            this.btnD20.UseVisualStyleBackColor = true;
            this.btnD20.Click += new System.EventHandler(this.btnD20_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Dice_Roller_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1247, 148);
            this.ControlBox = false;
            this.Controls.Add(this.gboxChooseDice);
            this.Controls.Add(this.gboxResults);
            this.Controls.Add(this.pnlTitleBar);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dice_Roller_Form";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.gboxResults.ResumeLayout(false);
            this.gboxResults.PerformLayout();
            this.gboxChooseDice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblProjectTitle;
        private System.Windows.Forms.GroupBox gboxResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lboxRolls;
        private System.Windows.Forms.Label lblOutputTotalOfRoll;
        private System.Windows.Forms.GroupBox gboxChooseDice;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRollRice;
        private System.Windows.Forms.Label lblNumberOfDice;
        private System.Windows.Forms.Button btnD2;
        private System.Windows.Forms.Button btnPercentage;
        private System.Windows.Forms.Button btnD10;
        private System.Windows.Forms.Button btnD12;
        private System.Windows.Forms.Button btnD8;
        private System.Windows.Forms.Button btnD6;
        private System.Windows.Forms.Button btnD4;
        private System.Windows.Forms.Button btnD20;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClear;
    }
}