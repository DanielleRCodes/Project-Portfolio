namespace DanielleRodriguez_CPT_185_Resturant_System
{
    partial class specialsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(specialsControl));
            this.picSpecial = new System.Windows.Forms.PictureBox();
            this.lblSpecName = new System.Windows.Forms.Label();
            this.lblSpecPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSpecial)).BeginInit();
            this.SuspendLayout();
            // 
            // picSpecial
            // 
            this.picSpecial.Image = ((System.Drawing.Image)(resources.GetObject("picSpecial.Image")));
            this.picSpecial.Location = new System.Drawing.Point(28, 12);
            this.picSpecial.Name = "picSpecial";
            this.picSpecial.Size = new System.Drawing.Size(96, 84);
            this.picSpecial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSpecial.TabIndex = 0;
            this.picSpecial.TabStop = false;
            // 
            // lblSpecName
            // 
            this.lblSpecName.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(128)))), ((int)(((byte)(134)))));
            this.lblSpecName.Location = new System.Drawing.Point(3, 108);
            this.lblSpecName.Name = "lblSpecName";
            this.lblSpecName.Size = new System.Drawing.Size(143, 49);
            this.lblSpecName.TabIndex = 2;
            this.lblSpecName.Text = "Item Name";
            this.lblSpecName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSpecPrice
            // 
            this.lblSpecPrice.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(128)))), ((int)(((byte)(134)))));
            this.lblSpecPrice.Location = new System.Drawing.Point(23, 179);
            this.lblSpecPrice.Name = "lblSpecPrice";
            this.lblSpecPrice.Size = new System.Drawing.Size(101, 36);
            this.lblSpecPrice.TabIndex = 3;
            this.lblSpecPrice.Text = "$10.00";
            this.lblSpecPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // specialsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.Controls.Add(this.lblSpecPrice);
            this.Controls.Add(this.lblSpecName);
            this.Controls.Add(this.picSpecial);
            this.Name = "specialsControl";
            this.Size = new System.Drawing.Size(149, 268);
            ((System.ComponentModel.ISupportInitialize)(this.picSpecial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSpecial;
        private System.Windows.Forms.Label lblSpecName;
        private System.Windows.Forms.Label lblSpecPrice;
    }
}
