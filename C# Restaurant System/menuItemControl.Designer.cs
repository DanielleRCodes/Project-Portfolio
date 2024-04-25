namespace DanielleRodriguez_CPT_185_Resturant_System
{
    partial class menuItemControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuItemControl));
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblItemName = new System.Windows.Forms.Label();
            this.picMenuItem = new System.Windows.Forms.PictureBox();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(128)))), ((int)(((byte)(134)))));
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(118, 186);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(66, 41);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Visible = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblItemName
            // 
            this.lblItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(180)))), ((int)(((byte)(98)))));
            this.lblItemName.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.White;
            this.lblItemName.Location = new System.Drawing.Point(8, 15);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(139, 36);
            this.lblItemName.TabIndex = 5;
            this.lblItemName.Text = "Chicken Katsu";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picMenuItem
            // 
            this.picMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("picMenuItem.Image")));
            this.picMenuItem.Location = new System.Drawing.Point(0, 3);
            this.picMenuItem.Name = "picMenuItem";
            this.picMenuItem.Size = new System.Drawing.Size(196, 154);
            this.picMenuItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMenuItem.TabIndex = 6;
            this.picMenuItem.TabStop = false;
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemPrice.ForeColor = System.Drawing.Color.White;
            this.lblItemPrice.Location = new System.Drawing.Point(4, 189);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(98, 41);
            this.lblItemPrice.TabIndex = 7;
            this.lblItemPrice.Text = "11.99";
            this.lblItemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategory
            // 
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(5, 159);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(107, 33);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Main Dish";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(70)))), ((int)(((byte)(102)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblItemPrice);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.picMenuItem);
            this.DoubleBuffered = true;
            this.Name = "menuItemControl";
            this.Size = new System.Drawing.Size(196, 236);
            ((System.ComponentModel.ISupportInitialize)(this.picMenuItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.PictureBox picMenuItem;
        private System.Windows.Forms.Label lblCategory;
        public System.Windows.Forms.Label lblItemPrice;
        public System.Windows.Forms.Button btnAddItem;
    }
}
