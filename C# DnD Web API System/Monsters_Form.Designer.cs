namespace DanielleRodriguez_CPT_206_Project
{
    partial class Monsters_Form
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnFilterType = new System.Windows.Forms.Button();
            this.cboxMonsterTypes = new System.Windows.Forms.ComboBox();
            this.flowPanelAllMonsters = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMonsterBackground = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblHPOutput = new System.Windows.Forms.Label();
            this.lblCROutput = new System.Windows.Forms.Label();
            this.lblSpeedOutput = new System.Windows.Forms.Label();
            this.lblSizeOutput = new System.Windows.Forms.Label();
            this.lblTypeOutput = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPaneActions = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblCHA = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblWIS = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblINT = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblCON = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblDEX = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSTR = new System.Windows.Forms.Label();
            this.picMonsterImage = new System.Windows.Forms.PictureBox();
            this.lblNameOutput = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlMonsterBackground.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMonsterImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Scaly Sans Caps", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(7, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(98, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Monsters";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(116)))), ((int)(((byte)(84)))));
            this.pnlHeader.Controls.Add(this.btnFilterType);
            this.pnlHeader.Controls.Add(this.cboxMonsterTypes);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1193, 38);
            this.pnlHeader.TabIndex = 1;
            // 
            // btnFilterType
            // 
            this.btnFilterType.Font = new System.Drawing.Font("Zatanna Misdirection", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterType.Location = new System.Drawing.Point(484, 7);
            this.btnFilterType.Name = "btnFilterType";
            this.btnFilterType.Size = new System.Drawing.Size(67, 23);
            this.btnFilterType.TabIndex = 3;
            this.btnFilterType.Text = "Filter";
            this.btnFilterType.UseVisualStyleBackColor = true;
            this.btnFilterType.Click += new System.EventHandler(this.btnFilterType_Click);
            // 
            // cboxMonsterTypes
            // 
            this.cboxMonsterTypes.Font = new System.Drawing.Font("Scaly Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxMonsterTypes.FormattingEnabled = true;
            this.cboxMonsterTypes.Items.AddRange(new object[] {
            "All",
            "Aberration",
            "Beast",
            "Celestial",
            "Construct",
            "Dragon",
            "Elemental",
            "Fey",
            "Fiend",
            "Giant",
            "Humanoid",
            "Monstrosity",
            "Ooze",
            "Plant",
            "Undead"});
            this.cboxMonsterTypes.Location = new System.Drawing.Point(322, 6);
            this.cboxMonsterTypes.Name = "cboxMonsterTypes";
            this.cboxMonsterTypes.Size = new System.Drawing.Size(154, 25);
            this.cboxMonsterTypes.TabIndex = 2;
            this.cboxMonsterTypes.Text = "All";
            // 
            // flowPanelAllMonsters
            // 
            this.flowPanelAllMonsters.AutoScroll = true;
            this.flowPanelAllMonsters.Location = new System.Drawing.Point(12, 44);
            this.flowPanelAllMonsters.Name = "flowPanelAllMonsters";
            this.flowPanelAllMonsters.Size = new System.Drawing.Size(421, 644);
            this.flowPanelAllMonsters.TabIndex = 2;
            // 
            // pnlMonsterBackground
            // 
            this.pnlMonsterBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(229)))), ((int)(((byte)(160)))));
            this.pnlMonsterBackground.Controls.Add(this.groupBox2);
            this.pnlMonsterBackground.Controls.Add(this.groupBox1);
            this.pnlMonsterBackground.Controls.Add(this.panel1);
            this.pnlMonsterBackground.Controls.Add(this.picMonsterImage);
            this.pnlMonsterBackground.Controls.Add(this.lblNameOutput);
            this.pnlMonsterBackground.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMonsterBackground.Location = new System.Drawing.Point(609, 38);
            this.pnlMonsterBackground.Name = "pnlMonsterBackground";
            this.pnlMonsterBackground.Size = new System.Drawing.Size(584, 662);
            this.pnlMonsterBackground.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblHPOutput);
            this.groupBox2.Controls.Add(this.lblCROutput);
            this.groupBox2.Controls.Add(this.lblSpeedOutput);
            this.groupBox2.Controls.Add(this.lblSizeOutput);
            this.groupBox2.Controls.Add(this.lblTypeOutput);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Scaly Sans Caps", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(224, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 196);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Info";
            // 
            // lblHPOutput
            // 
            this.lblHPOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHPOutput.Font = new System.Drawing.Font("Scaly Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHPOutput.Location = new System.Drawing.Point(101, 138);
            this.lblHPOutput.Name = "lblHPOutput";
            this.lblHPOutput.Size = new System.Drawing.Size(143, 26);
            this.lblHPOutput.TabIndex = 19;
            this.lblHPOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCROutput
            // 
            this.lblCROutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCROutput.Font = new System.Drawing.Font("Scaly Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCROutput.Location = new System.Drawing.Point(101, 108);
            this.lblCROutput.Name = "lblCROutput";
            this.lblCROutput.Size = new System.Drawing.Size(143, 26);
            this.lblCROutput.TabIndex = 18;
            this.lblCROutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSpeedOutput
            // 
            this.lblSpeedOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSpeedOutput.Font = new System.Drawing.Font("Scaly Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeedOutput.Location = new System.Drawing.Point(101, 80);
            this.lblSpeedOutput.Name = "lblSpeedOutput";
            this.lblSpeedOutput.Size = new System.Drawing.Size(143, 26);
            this.lblSpeedOutput.TabIndex = 17;
            this.lblSpeedOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSizeOutput
            // 
            this.lblSizeOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSizeOutput.Font = new System.Drawing.Font("Scaly Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeOutput.Location = new System.Drawing.Point(101, 53);
            this.lblSizeOutput.Name = "lblSizeOutput";
            this.lblSizeOutput.Size = new System.Drawing.Size(143, 26);
            this.lblSizeOutput.TabIndex = 16;
            this.lblSizeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTypeOutput
            // 
            this.lblTypeOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTypeOutput.Font = new System.Drawing.Font("Scaly Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOutput.Location = new System.Drawing.Point(101, 25);
            this.lblTypeOutput.Name = "lblTypeOutput";
            this.lblTypeOutput.Size = new System.Drawing.Size(143, 26);
            this.lblTypeOutput.TabIndex = 15;
            this.lblTypeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Scaly Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "HP:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Scaly Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(53, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 14);
            this.label12.TabIndex = 13;
            this.label12.Text = "Speed:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Scaly Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "CR:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Scaly Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(64, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 14);
            this.label11.TabIndex = 12;
            this.label11.Text = "Size:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Scaly Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Type:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPaneActions);
            this.groupBox1.Font = new System.Drawing.Font("Scaly Sans Caps", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 282);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // flowLayoutPaneActions
            // 
            this.flowLayoutPaneActions.AutoScroll = true;
            this.flowLayoutPaneActions.Location = new System.Drawing.Point(19, 25);
            this.flowLayoutPaneActions.Name = "flowLayoutPaneActions";
            this.flowLayoutPaneActions.Size = new System.Drawing.Size(532, 251);
            this.flowLayoutPaneActions.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox8);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(0, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 82);
            this.panel1.TabIndex = 5;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblCHA);
            this.groupBox8.Font = new System.Drawing.Font("Scaly Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(428, 8);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(66, 63);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Cha";
            // 
            // lblCHA
            // 
            this.lblCHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCHA.Location = new System.Drawing.Point(16, 15);
            this.lblCHA.Name = "lblCHA";
            this.lblCHA.Size = new System.Drawing.Size(35, 37);
            this.lblCHA.TabIndex = 1;
            this.lblCHA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblWIS);
            this.groupBox7.Font = new System.Drawing.Font("Scaly Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(356, 8);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(66, 63);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Wis";
            // 
            // lblWIS
            // 
            this.lblWIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWIS.Location = new System.Drawing.Point(16, 15);
            this.lblWIS.Name = "lblWIS";
            this.lblWIS.Size = new System.Drawing.Size(35, 37);
            this.lblWIS.TabIndex = 1;
            this.lblWIS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblINT);
            this.groupBox6.Font = new System.Drawing.Font("Scaly Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(284, 8);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(66, 63);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Int";
            // 
            // lblINT
            // 
            this.lblINT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINT.Location = new System.Drawing.Point(16, 15);
            this.lblINT.Name = "lblINT";
            this.lblINT.Size = new System.Drawing.Size(35, 37);
            this.lblINT.TabIndex = 1;
            this.lblINT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblCON);
            this.groupBox5.Font = new System.Drawing.Font("Scaly Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(212, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(66, 63);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Con";
            // 
            // lblCON
            // 
            this.lblCON.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCON.Location = new System.Drawing.Point(16, 15);
            this.lblCON.Name = "lblCON";
            this.lblCON.Size = new System.Drawing.Size(35, 37);
            this.lblCON.TabIndex = 1;
            this.lblCON.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblDEX);
            this.groupBox4.Font = new System.Drawing.Font("Scaly Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(140, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(66, 63);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dex";
            // 
            // lblDEX
            // 
            this.lblDEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDEX.Location = new System.Drawing.Point(17, 16);
            this.lblDEX.Name = "lblDEX";
            this.lblDEX.Size = new System.Drawing.Size(35, 37);
            this.lblDEX.TabIndex = 1;
            this.lblDEX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSTR);
            this.groupBox3.Font = new System.Drawing.Font("Scaly Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(68, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(66, 63);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Str";
            // 
            // lblSTR
            // 
            this.lblSTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTR.Location = new System.Drawing.Point(15, 16);
            this.lblSTR.Name = "lblSTR";
            this.lblSTR.Size = new System.Drawing.Size(35, 37);
            this.lblSTR.TabIndex = 0;
            this.lblSTR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picMonsterImage
            // 
            this.picMonsterImage.Location = new System.Drawing.Point(15, 37);
            this.picMonsterImage.Name = "picMonsterImage";
            this.picMonsterImage.Size = new System.Drawing.Size(203, 167);
            this.picMonsterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMonsterImage.TabIndex = 0;
            this.picMonsterImage.TabStop = false;
            // 
            // lblNameOutput
            // 
            this.lblNameOutput.Font = new System.Drawing.Font("Nodesto Caps Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOutput.Location = new System.Drawing.Point(8, 8);
            this.lblNameOutput.Name = "lblNameOutput";
            this.lblNameOutput.Size = new System.Drawing.Size(286, 26);
            this.lblNameOutput.TabIndex = 14;
            this.lblNameOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Monsters_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1193, 700);
            this.Controls.Add(this.pnlMonsterBackground);
            this.Controls.Add(this.flowPanelAllMonsters);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Monsters_Form";
            this.Text = "Monsters_Form";
            this.Load += new System.EventHandler(this.Monsters_Form_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMonsterBackground.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMonsterImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlMonsterBackground;
        private System.Windows.Forms.FlowLayoutPanel flowPanelAllMonsters;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboxMonsterTypes;
        private System.Windows.Forms.Button btnFilterType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblNameOutput;
        public System.Windows.Forms.Label lblHPOutput;
        public System.Windows.Forms.Label lblCROutput;
        public System.Windows.Forms.Label lblSpeedOutput;
        public System.Windows.Forms.Label lblSizeOutput;
        public System.Windows.Forms.Label lblTypeOutput;
        public System.Windows.Forms.PictureBox picMonsterImage;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label lblCHA;
        public System.Windows.Forms.Label lblWIS;
        public System.Windows.Forms.Label lblINT;
        public System.Windows.Forms.Label lblCON;
        public System.Windows.Forms.Label lblDEX;
        public System.Windows.Forms.Label lblSTR;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPaneActions;
    }
}