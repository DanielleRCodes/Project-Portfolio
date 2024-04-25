namespace DanielleRodriguez_CPT_185_Resturant_System
{
    partial class openOrderControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(openOrderControl));
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.lblTableName = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.btnOpenOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.Location = new System.Drawing.Point(16, 9);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(57, 49);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // lblTableName
            // 
            this.lblTableName.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableName.ForeColor = System.Drawing.Color.White;
            this.lblTableName.Location = new System.Drawing.Point(84, 12);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(115, 38);
            this.lblTableName.TabIndex = 1;
            this.lblTableName.Text = "Table Name";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTotal.ForeColor = System.Drawing.Color.White;
            this.lblOrderTotal.Location = new System.Drawing.Point(196, 12);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(92, 38);
            this.lblOrderTotal.TabIndex = 2;
            this.lblOrderTotal.Text = "Order Total";
            // 
            // btnOpenOrder
            // 
            this.btnOpenOrder.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenOrder.Location = new System.Drawing.Point(296, 14);
            this.btnOpenOrder.Name = "btnOpenOrder";
            this.btnOpenOrder.Size = new System.Drawing.Size(80, 38);
            this.btnOpenOrder.TabIndex = 3;
            this.btnOpenOrder.Text = "View";
            this.btnOpenOrder.UseVisualStyleBackColor = true;
            this.btnOpenOrder.Click += new System.EventHandler(this.BtnOpenOrder_Click);
            // 
            // openOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(128)))), ((int)(((byte)(134)))));
            this.Controls.Add(this.btnOpenOrder);
            this.Controls.Add(this.lblOrderTotal);
            this.Controls.Add(this.lblTableName);
            this.Controls.Add(this.pictureBoxIcon);
            this.Name = "openOrderControl";
            this.Size = new System.Drawing.Size(390, 68);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Button btnOpenOrder;
    }
}
