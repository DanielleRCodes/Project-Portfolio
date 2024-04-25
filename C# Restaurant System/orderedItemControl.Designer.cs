
namespace DanielleRodriguez_CPT_185_Resturant_System
{
    partial class orderedItemControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderedItemControl));
            this.lblItemName = new System.Windows.Forms.Label();
            this.picItem = new System.Windows.Forms.PictureBox();
            this.pnlHighlight = new System.Windows.Forms.Panel();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.lblItemPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemName
            // 
            this.lblItemName.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.White;
            this.lblItemName.Location = new System.Drawing.Point(64, 12);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(143, 38);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Item Name";
            // 
            // picItem
            // 
            this.picItem.Image = ((System.Drawing.Image)(resources.GetObject("picItem.Image")));
            this.picItem.Location = new System.Drawing.Point(12, 8);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(46, 45);
            this.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picItem.TabIndex = 1;
            this.picItem.TabStop = false;
            // 
            // pnlHighlight
            // 
            this.pnlHighlight.BackColor = System.Drawing.Color.White;
            this.pnlHighlight.Location = new System.Drawing.Point(0, 63);
            this.pnlHighlight.Name = "pnlHighlight";
            this.pnlHighlight.Size = new System.Drawing.Size(404, 10);
            this.pnlHighlight.TabIndex = 3;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveItem.BackgroundImage")));
            this.btnRemoveItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveItem.FlatAppearance.BorderSize = 0;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Location = new System.Drawing.Point(296, 10);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(43, 40);
            this.btnRemoveItem.TabIndex = 5;
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.BtnRemoveItem_Click);
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemPrice.ForeColor = System.Drawing.Color.White;
            this.lblItemPrice.Location = new System.Drawing.Point(212, 12);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(71, 38);
            this.lblItemPrice.TabIndex = 6;
            this.lblItemPrice.Text = "Price";
            // 
            // orderedItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.Controls.Add(this.lblItemPrice);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.pnlHighlight);
            this.Controls.Add(this.picItem);
            this.Controls.Add(this.lblItemName);
            this.Name = "orderedItemControl";
            this.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Size = new System.Drawing.Size(351, 65);
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.PictureBox picItem;
        private System.Windows.Forms.Panel pnlHighlight;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Label lblItemPrice;
    }
}
