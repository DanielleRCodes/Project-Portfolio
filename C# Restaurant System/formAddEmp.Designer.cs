namespace DanielleRodriguez_CPT_185_Resturant_System
{
    partial class formAddEmp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAddEmp));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblEmpFName = new System.Windows.Forms.Label();
            this.lblEmpLName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewEmpFirstName = new System.Windows.Forms.TextBox();
            this.txtNewEmpLastName = new System.Windows.Forms.TextBox();
            this.cboxNewEmpPosition = new System.Windows.Forms.ComboBox();
            this.btnAddNewEmp = new System.Windows.Forms.Button();
            this.imageListEmpIcons = new System.Windows.Forms.ImageList(this.components);
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(70)))), ((int)(((byte)(102)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(377, 38);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(4, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(95, 26);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Add User";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Location = new System.Drawing.Point(338, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 31);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
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
            // 
            // lblEmpFName
            // 
            this.lblEmpFName.AutoSize = true;
            this.lblEmpFName.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpFName.Location = new System.Drawing.Point(28, 67);
            this.lblEmpFName.Name = "lblEmpFName";
            this.lblEmpFName.Size = new System.Drawing.Size(125, 15);
            this.lblEmpFName.TabIndex = 4;
            this.lblEmpFName.Text = "Employee First Name:";
            // 
            // lblEmpLName
            // 
            this.lblEmpLName.AutoSize = true;
            this.lblEmpLName.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpLName.Location = new System.Drawing.Point(29, 117);
            this.lblEmpLName.Name = "lblEmpLName";
            this.lblEmpLName.Size = new System.Drawing.Size(124, 15);
            this.lblEmpLName.TabIndex = 5;
            this.lblEmpLName.Text = "Employee Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employee Position:";
            // 
            // txtNewEmpFirstName
            // 
            this.txtNewEmpFirstName.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewEmpFirstName.Location = new System.Drawing.Point(159, 64);
            this.txtNewEmpFirstName.Name = "txtNewEmpFirstName";
            this.txtNewEmpFirstName.Size = new System.Drawing.Size(133, 23);
            this.txtNewEmpFirstName.TabIndex = 7;
            // 
            // txtNewEmpLastName
            // 
            this.txtNewEmpLastName.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewEmpLastName.Location = new System.Drawing.Point(159, 114);
            this.txtNewEmpLastName.Name = "txtNewEmpLastName";
            this.txtNewEmpLastName.Size = new System.Drawing.Size(133, 23);
            this.txtNewEmpLastName.TabIndex = 8;
            // 
            // cboxNewEmpPosition
            // 
            this.cboxNewEmpPosition.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxNewEmpPosition.FormattingEnabled = true;
            this.cboxNewEmpPosition.Items.AddRange(new object[] {
            "Waitress",
            "Hostess",
            "Bartender",
            "Kitchen Chef",
            "Sushi Chef",
            "Manager"});
            this.cboxNewEmpPosition.Location = new System.Drawing.Point(159, 164);
            this.cboxNewEmpPosition.Name = "cboxNewEmpPosition";
            this.cboxNewEmpPosition.Size = new System.Drawing.Size(133, 23);
            this.cboxNewEmpPosition.TabIndex = 9;
            // 
            // btnAddNewEmp
            // 
            this.btnAddNewEmp.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewEmp.Location = new System.Drawing.Point(139, 210);
            this.btnAddNewEmp.Name = "btnAddNewEmp";
            this.btnAddNewEmp.Size = new System.Drawing.Size(95, 36);
            this.btnAddNewEmp.TabIndex = 10;
            this.btnAddNewEmp.Text = "Add";
            this.btnAddNewEmp.UseVisualStyleBackColor = true;
            this.btnAddNewEmp.Click += new System.EventHandler(this.BtnAddNewEmp_Click);
            // 
            // imageListEmpIcons
            // 
            this.imageListEmpIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListEmpIcons.ImageStream")));
            this.imageListEmpIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListEmpIcons.Images.SetKeyName(0, "manager.png");
            this.imageListEmpIcons.Images.SetKeyName(1, "hostess.png");
            this.imageListEmpIcons.Images.SetKeyName(2, "bartender.png");
            this.imageListEmpIcons.Images.SetKeyName(3, "waitress (1).png");
            this.imageListEmpIcons.Images.SetKeyName(4, "sushi chef.png");
            this.imageListEmpIcons.Images.SetKeyName(5, "kithen chef.png");
            // 
            // formAddEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(377, 269);
            this.Controls.Add(this.btnAddNewEmp);
            this.Controls.Add(this.cboxNewEmpPosition);
            this.Controls.Add(this.txtNewEmpLastName);
            this.Controls.Add(this.txtNewEmpFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmpLName);
            this.Controls.Add(this.lblEmpFName);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAddEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formAddEmp";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblEmpFName;
        private System.Windows.Forms.Label lblEmpLName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewEmpFirstName;
        private System.Windows.Forms.TextBox txtNewEmpLastName;
        private System.Windows.Forms.ComboBox cboxNewEmpPosition;
        private System.Windows.Forms.Button btnAddNewEmp;
        private System.Windows.Forms.ImageList imageListEmpIcons;
    }
}