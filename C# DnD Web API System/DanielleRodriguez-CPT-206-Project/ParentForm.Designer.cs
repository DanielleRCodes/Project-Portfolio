namespace DanielleRodriguez_CPT_206_Project
{
    partial class ParentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentForm));
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.btnClasses = new System.Windows.Forms.Button();
            this.btnSpells = new System.Windows.Forms.Button();
            this.btnViewMonsters = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picMainIcon = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlLoadForms = new System.Windows.Forms.Panel();
            this.btnTestAPIForm = new System.Windows.Forms.Button();
            this.pnlTitleBar.SuspendLayout();
            this.pnlNavBar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(85)))), ((int)(((byte)(62)))));
            this.pnlTitleBar.Controls.Add(this.btnExit);
            this.pnlTitleBar.Controls.Add(this.btnRollDice);
            this.pnlTitleBar.Controls.Add(this.lblProjectTitle);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1291, 47);
            this.pnlTitleBar.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1240, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(41, 37);
            this.btnExit.TabIndex = 8;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRollDice
            // 
            this.btnRollDice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnRollDice.FlatAppearance.BorderSize = 0;
            this.btnRollDice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRollDice.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollDice.Location = new System.Drawing.Point(1101, 7);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(104, 32);
            this.btnRollDice.TabIndex = 3;
            this.btnRollDice.Text = "Dice Roller";
            this.btnRollDice.UseVisualStyleBackColor = false;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.AutoSize = true;
            this.lblProjectTitle.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTitle.ForeColor = System.Drawing.Color.White;
            this.lblProjectTitle.Location = new System.Drawing.Point(12, 11);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(300, 23);
            this.lblProjectTitle.TabIndex = 2;
            this.lblProjectTitle.Text = "Dungeons and Dragons 5th Edition";
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(85)))), ((int)(((byte)(62)))));
            this.pnlNavBar.Controls.Add(this.btnTestAPIForm);
            this.pnlNavBar.Controls.Add(this.btnClasses);
            this.pnlNavBar.Controls.Add(this.btnSpells);
            this.pnlNavBar.Controls.Add(this.btnViewMonsters);
            this.pnlNavBar.Controls.Add(this.pnlHeader);
            this.pnlNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavBar.Location = new System.Drawing.Point(0, 47);
            this.pnlNavBar.Name = "pnlNavBar";
            this.pnlNavBar.Size = new System.Drawing.Size(202, 637);
            this.pnlNavBar.TabIndex = 1;
            // 
            // btnClasses
            // 
            this.btnClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnClasses.FlatAppearance.BorderSize = 0;
            this.btnClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClasses.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClasses.Location = new System.Drawing.Point(0, 237);
            this.btnClasses.Name = "btnClasses";
            this.btnClasses.Size = new System.Drawing.Size(202, 53);
            this.btnClasses.TabIndex = 7;
            this.btnClasses.Text = "Classes";
            this.btnClasses.UseVisualStyleBackColor = false;
            this.btnClasses.Click += new System.EventHandler(this.btnClasses_Click);
            // 
            // btnSpells
            // 
            this.btnSpells.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnSpells.FlatAppearance.BorderSize = 0;
            this.btnSpells.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpells.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpells.Location = new System.Drawing.Point(0, 319);
            this.btnSpells.Name = "btnSpells";
            this.btnSpells.Size = new System.Drawing.Size(202, 53);
            this.btnSpells.TabIndex = 6;
            this.btnSpells.Text = "Spells";
            this.btnSpells.UseVisualStyleBackColor = false;
            this.btnSpells.Click += new System.EventHandler(this.btnSpells_Click);
            // 
            // btnViewMonsters
            // 
            this.btnViewMonsters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnViewMonsters.FlatAppearance.BorderSize = 0;
            this.btnViewMonsters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewMonsters.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMonsters.Location = new System.Drawing.Point(0, 403);
            this.btnViewMonsters.Name = "btnViewMonsters";
            this.btnViewMonsters.Size = new System.Drawing.Size(202, 53);
            this.btnViewMonsters.TabIndex = 4;
            this.btnViewMonsters.Text = "Monsters";
            this.btnViewMonsters.UseVisualStyleBackColor = false;
            this.btnViewMonsters.Click += new System.EventHandler(this.btnViewMonsters_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(108)))));
            this.pnlHeader.Controls.Add(this.picMainIcon);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(202, 179);
            this.pnlHeader.TabIndex = 2;
            // 
            // picMainIcon
            // 
            this.picMainIcon.Image = ((System.Drawing.Image)(resources.GetObject("picMainIcon.Image")));
            this.picMainIcon.Location = new System.Drawing.Point(41, 43);
            this.picMainIcon.Name = "picMainIcon";
            this.picMainIcon.Size = new System.Drawing.Size(117, 104);
            this.picMainIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMainIcon.TabIndex = 1;
            this.picMainIcon.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(23, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(158, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Monster Manager";
            // 
            // pnlLoadForms
            // 
            this.pnlLoadForms.BackColor = System.Drawing.Color.White;
            this.pnlLoadForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoadForms.Location = new System.Drawing.Point(202, 47);
            this.pnlLoadForms.Name = "pnlLoadForms";
            this.pnlLoadForms.Size = new System.Drawing.Size(1089, 637);
            this.pnlLoadForms.TabIndex = 2;
            // 
            // btnTestAPIForm
            // 
            this.btnTestAPIForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnTestAPIForm.FlatAppearance.BorderSize = 0;
            this.btnTestAPIForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestAPIForm.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestAPIForm.Location = new System.Drawing.Point(0, 530);
            this.btnTestAPIForm.Name = "btnTestAPIForm";
            this.btnTestAPIForm.Size = new System.Drawing.Size(202, 53);
            this.btnTestAPIForm.TabIndex = 8;
            this.btnTestAPIForm.Text = "Test API Form";
            this.btnTestAPIForm.UseVisualStyleBackColor = false;
            this.btnTestAPIForm.Click += new System.EventHandler(this.btnTestAPIForm_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 684);
            this.ControlBox = false;
            this.Controls.Add(this.pnlLoadForms);
            this.Controls.Add(this.pnlNavBar);
            this.Controls.Add(this.pnlTitleBar);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ParentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ParentForm_Load);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlNavBar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Panel pnlNavBar;
        private System.Windows.Forms.PictureBox picMainIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProjectTitle;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlLoadForms;
        private System.Windows.Forms.Button btnViewMonsters;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Button btnSpells;
        private System.Windows.Forms.Button btnClasses;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTestAPIForm;
    }
}

