namespace DanielleRodriguez_CPT_206_Project
{
    partial class ActionControl
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
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOutputDice = new System.Windows.Forms.Label();
            this.lblOutputBonus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOutputDamType = new System.Windows.Forms.Label();
            this.tboxActionDesc = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Zatanna Misdirection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(8, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(128, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Action Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tboxActionDesc);
            this.panel1.Controls.Add(this.lblOutputDice);
            this.panel1.Controls.Add(this.lblOutputBonus);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblOutputDamType);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 159);
            this.panel1.TabIndex = 1;
            // 
            // lblOutputDice
            // 
            this.lblOutputDice.Font = new System.Drawing.Font("Scaly Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputDice.Location = new System.Drawing.Point(380, 33);
            this.lblOutputDice.Name = "lblOutputDice";
            this.lblOutputDice.Size = new System.Drawing.Size(100, 29);
            this.lblOutputDice.TabIndex = 5;
            this.lblOutputDice.Text = "1d6+1";
            this.lblOutputDice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOutputBonus
            // 
            this.lblOutputBonus.Font = new System.Drawing.Font("Scaly Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputBonus.Location = new System.Drawing.Point(122, 35);
            this.lblOutputBonus.Name = "lblOutputBonus";
            this.lblOutputBonus.Size = new System.Drawing.Size(42, 28);
            this.lblOutputBonus.TabIndex = 4;
            this.lblOutputBonus.Text = "##";
            this.lblOutputBonus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Scaly Sans Caps", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Attack Bonus: +";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutputDamType
            // 
            this.lblOutputDamType.Font = new System.Drawing.Font("Scaly Sans Caps", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputDamType.Location = new System.Drawing.Point(352, 6);
            this.lblOutputDamType.Name = "lblOutputDamType";
            this.lblOutputDamType.Size = new System.Drawing.Size(128, 29);
            this.lblOutputDamType.TabIndex = 2;
            this.lblOutputDamType.Text = "Damage Type";
            this.lblOutputDamType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxActionDesc
            // 
            this.tboxActionDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(108)))));
            this.tboxActionDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxActionDesc.Font = new System.Drawing.Font("Scaly Sans Caps", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxActionDesc.Location = new System.Drawing.Point(11, 65);
            this.tboxActionDesc.Multiline = true;
            this.tboxActionDesc.Name = "tboxActionDesc";
            this.tboxActionDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tboxActionDesc.Size = new System.Drawing.Size(469, 72);
            this.tboxActionDesc.TabIndex = 7;
            // 
            // ActionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(108)))));
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ActionControl";
            this.Size = new System.Drawing.Size(508, 167);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOutputBonus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOutputDamType;
        private System.Windows.Forms.Label lblOutputDice;
        private System.Windows.Forms.TextBox tboxActionDesc;
    }
}
