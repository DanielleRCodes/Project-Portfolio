namespace DanielleRodriguez_CPT_185_Resturant_System
{
    partial class formMainConsole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMainConsole));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnNavOrders = new System.Windows.Forms.Button();
            this.btnNavMenuItems = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNavEmployee = new System.Windows.Forms.Button();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.picRestIcon = new System.Windows.Forms.PictureBox();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRestIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(70)))), ((int)(((byte)(102)))));
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1302, 38);
            this.pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rising Sun Sushi Resturant";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Location = new System.Drawing.Point(1265, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 31);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(70)))), ((int)(((byte)(102)))));
            this.pnlNavBar.Controls.Add(this.btnLogout);
            this.pnlNavBar.Controls.Add(this.btnNavOrders);
            this.pnlNavBar.Controls.Add(this.btnNavMenuItems);
            this.pnlNavBar.Controls.Add(this.button2);
            this.pnlNavBar.Controls.Add(this.btnNavEmployee);
            this.pnlNavBar.Controls.Add(this.btnNavDashboard);
            this.pnlNavBar.Controls.Add(this.picRestIcon);
            this.pnlNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavBar.Location = new System.Drawing.Point(0, 38);
            this.pnlNavBar.Name = "pnlNavBar";
            this.pnlNavBar.Size = new System.Drawing.Size(189, 654);
            this.pnlNavBar.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(1, 597);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(186, 45);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnNavOrders
            // 
            this.btnNavOrders.FlatAppearance.BorderSize = 0;
            this.btnNavOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavOrders.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavOrders.ForeColor = System.Drawing.Color.White;
            this.btnNavOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnNavOrders.Image")));
            this.btnNavOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavOrders.Location = new System.Drawing.Point(3, 231);
            this.btnNavOrders.Name = "btnNavOrders";
            this.btnNavOrders.Size = new System.Drawing.Size(186, 45);
            this.btnNavOrders.TabIndex = 6;
            this.btnNavOrders.Text = "   Orders";
            this.btnNavOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavOrders.UseVisualStyleBackColor = true;
            this.btnNavOrders.Click += new System.EventHandler(this.BtnNavOrders_Click);
            // 
            // btnNavMenuItems
            // 
            this.btnNavMenuItems.FlatAppearance.BorderSize = 0;
            this.btnNavMenuItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMenuItems.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavMenuItems.ForeColor = System.Drawing.Color.White;
            this.btnNavMenuItems.Image = ((System.Drawing.Image)(resources.GetObject("btnNavMenuItems.Image")));
            this.btnNavMenuItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavMenuItems.Location = new System.Drawing.Point(1, 301);
            this.btnNavMenuItems.Name = "btnNavMenuItems";
            this.btnNavMenuItems.Size = new System.Drawing.Size(186, 45);
            this.btnNavMenuItems.TabIndex = 5;
            this.btnNavMenuItems.Text = "   Menu Items";
            this.btnNavMenuItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavMenuItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavMenuItems.UseVisualStyleBackColor = true;
            this.btnNavMenuItems.Click += new System.EventHandler(this.btnNavMenuItems_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(0, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "   Dashboard";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnNavEmployee
            // 
            this.btnNavEmployee.FlatAppearance.BorderSize = 0;
            this.btnNavEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavEmployee.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavEmployee.ForeColor = System.Drawing.Color.White;
            this.btnNavEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnNavEmployee.Image")));
            this.btnNavEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavEmployee.Location = new System.Drawing.Point(0, 375);
            this.btnNavEmployee.Name = "btnNavEmployee";
            this.btnNavEmployee.Size = new System.Drawing.Size(186, 45);
            this.btnNavEmployee.TabIndex = 3;
            this.btnNavEmployee.Text = "   Employees";
            this.btnNavEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavEmployee.UseVisualStyleBackColor = true;
            this.btnNavEmployee.Click += new System.EventHandler(this.btnNavEmployee_Click);
            // 
            // btnNavDashboard
            // 
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavDashboard.ForeColor = System.Drawing.Color.White;
            this.btnNavDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnNavDashboard.Image")));
            this.btnNavDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.Location = new System.Drawing.Point(0, 160);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Size = new System.Drawing.Size(186, 45);
            this.btnNavDashboard.TabIndex = 2;
            this.btnNavDashboard.Text = "   Dashboard";
            this.btnNavDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavDashboard.UseVisualStyleBackColor = true;
            this.btnNavDashboard.Click += new System.EventHandler(this.btnNavDashboard_Click);
            // 
            // picRestIcon
            // 
            this.picRestIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picRestIcon.Image = ((System.Drawing.Image)(resources.GetObject("picRestIcon.Image")));
            this.picRestIcon.Location = new System.Drawing.Point(34, 13);
            this.picRestIcon.Name = "picRestIcon";
            this.picRestIcon.Size = new System.Drawing.Size(113, 99);
            this.picRestIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRestIcon.TabIndex = 2;
            this.picRestIcon.TabStop = false;
            // 
            // pnlBackground
            // 
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBackground.Location = new System.Drawing.Point(189, 38);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1113, 654);
            this.pnlBackground.TabIndex = 2;
            // 
            // formMainConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1302, 692);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.pnlNavBar);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formMainConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.formMainConsole_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRestIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlNavBar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picRestIcon;
        public System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.Button btnNavOrders;
        public System.Windows.Forms.Button btnNavMenuItems;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btnNavEmployee;
        public System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Panel pnlBackground;
    }
}

