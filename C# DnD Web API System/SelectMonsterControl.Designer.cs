namespace DanielleRodriguez_CPT_206_Project
{
    partial class SelectMonsterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectMonsterControl));
            this.picMonster = new System.Windows.Forms.PictureBox();
            this.btnMonsterDetails = new System.Windows.Forms.Button();
            this.lblMonsterName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblMonType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picMonster)).BeginInit();
            this.SuspendLayout();
            // 
            // picMonster
            // 
            this.picMonster.Image = ((System.Drawing.Image)(resources.GetObject("picMonster.Image")));
            this.picMonster.Location = new System.Drawing.Point(17, 9);
            this.picMonster.Name = "picMonster";
            this.picMonster.Size = new System.Drawing.Size(80, 74);
            this.picMonster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMonster.TabIndex = 0;
            this.picMonster.TabStop = false;
            // 
            // btnMonsterDetails
            // 
            this.btnMonsterDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(229)))), ((int)(((byte)(160)))));
            this.btnMonsterDetails.FlatAppearance.BorderSize = 0;
            this.btnMonsterDetails.Font = new System.Drawing.Font("Zatanna Misdirection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonsterDetails.ForeColor = System.Drawing.Color.Black;
            this.btnMonsterDetails.Location = new System.Drawing.Point(309, 25);
            this.btnMonsterDetails.Name = "btnMonsterDetails";
            this.btnMonsterDetails.Size = new System.Drawing.Size(78, 41);
            this.btnMonsterDetails.TabIndex = 1;
            this.btnMonsterDetails.Text = "Details";
            this.btnMonsterDetails.UseVisualStyleBackColor = false;
            this.btnMonsterDetails.Click += new System.EventHandler(this.btnMonsterDetails_Click);
            // 
            // lblMonsterName
            // 
            this.lblMonsterName.Font = new System.Drawing.Font("Nodesto Caps Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonsterName.Location = new System.Drawing.Point(112, 10);
            this.lblMonsterName.Name = "lblMonsterName";
            this.lblMonsterName.Size = new System.Drawing.Size(191, 38);
            this.lblMonsterName.TabIndex = 2;
            this.lblMonsterName.Text = "Monster Name";
            this.lblMonsterName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Scaly Sans Caps", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(112, 48);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(54, 35);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type:";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMonType
            // 
            this.lblMonType.Font = new System.Drawing.Font("Scaly Sans Caps", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonType.Location = new System.Drawing.Point(160, 48);
            this.lblMonType.Name = "lblMonType";
            this.lblMonType.Size = new System.Drawing.Size(114, 35);
            this.lblMonType.TabIndex = 5;
            this.lblMonType.Text = "Type?";
            this.lblMonType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 10);
            this.panel1.TabIndex = 6;
            // 
            // SelectMonsterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMonType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblMonsterName);
            this.Controls.Add(this.btnMonsterDetails);
            this.Controls.Add(this.picMonster);
            this.Name = "SelectMonsterControl";
            this.Size = new System.Drawing.Size(403, 93);
            ((System.ComponentModel.ISupportInitialize)(this.picMonster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMonster;
        private System.Windows.Forms.Button btnMonsterDetails;
        private System.Windows.Forms.Label lblMonsterName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblMonType;
        private System.Windows.Forms.Panel panel1;
    }
}
