namespace DanielleRodriguez_CPT_185_Resturant_System
{
    partial class empShiftControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(empShiftControl));
            this.picEmp = new System.Windows.Forms.PictureBox();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblShiftTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // picEmp
            // 
            this.picEmp.Image = ((System.Drawing.Image)(resources.GetObject("picEmp.Image")));
            this.picEmp.Location = new System.Drawing.Point(13, 7);
            this.picEmp.Name = "picEmp";
            this.picEmp.Size = new System.Drawing.Size(64, 56);
            this.picEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEmp.TabIndex = 0;
            this.picEmp.TabStop = false;
            // 
            // lblEmpName
            // 
            this.lblEmpName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpName.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(70)))), ((int)(((byte)(102)))));
            this.lblEmpName.Location = new System.Drawing.Point(100, 20);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(169, 43);
            this.lblEmpName.TabIndex = 1;
            this.lblEmpName.Text = "Employee Name";
            // 
            // lblShiftTime
            // 
            this.lblShiftTime.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShiftTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(70)))), ((int)(((byte)(102)))));
            this.lblShiftTime.Location = new System.Drawing.Point(275, 20);
            this.lblShiftTime.Name = "lblShiftTime";
            this.lblShiftTime.Size = new System.Drawing.Size(119, 43);
            this.lblShiftTime.TabIndex = 2;
            this.lblShiftTime.Text = "Shift Time";
            this.lblShiftTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // empShiftControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.lblShiftTime);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.picEmp);
            this.Name = "empShiftControl";
            this.Size = new System.Drawing.Size(408, 71);
            ((System.ComponentModel.ISupportInitialize)(this.picEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picEmp;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblShiftTime;
    }
}
