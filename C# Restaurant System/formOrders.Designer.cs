namespace DanielleRodriguez_CPT_185_Resturant_System
{
    partial class formOrders
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
            this.pnlCurrentNav = new System.Windows.Forms.Panel();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.flowLayoutPanelMenuItems = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAllItems = new System.Windows.Forms.Button();
            this.btnAppItems = new System.Windows.Forms.Button();
            this.btnKitchenItems = new System.Windows.Forms.Button();
            this.btnSushiItems = new System.Windows.Forms.Button();
            this.btnDessertItems = new System.Windows.Forms.Button();
            this.btnDrinkItems = new System.Windows.Forms.Button();
            this.flowLayoutPanelOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOrderTitle = new System.Windows.Forms.Label();
            this.gBoxTotals = new System.Windows.Forms.GroupBox();
            this.lblOutputTotal = new System.Windows.Forms.Label();
            this.lblOutputTax = new System.Windows.Forms.Label();
            this.lblOutputSubTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.btnCashOut = new System.Windows.Forms.Button();
            this.gboxCashout = new System.Windows.Forms.GroupBox();
            this.lblOutputChange = new System.Windows.Forms.Label();
            this.lblChangeInstruct = new System.Windows.Forms.Label();
            this.txtCashReceived = new System.Windows.Forms.TextBox();
            this.lblCashInstruction = new System.Windows.Forms.Label();
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.pnlCurrentNav.SuspendLayout();
            this.gBoxTotals.SuspendLayout();
            this.gboxCashout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCurrentNav
            // 
            this.pnlCurrentNav.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnlCurrentNav.Controls.Add(this.btnNewOrder);
            this.pnlCurrentNav.Controls.Add(this.btnSubmitOrder);
            this.pnlCurrentNav.Controls.Add(this.label2);
            this.pnlCurrentNav.Controls.Add(this.btnViewOrders);
            this.pnlCurrentNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCurrentNav.Location = new System.Drawing.Point(0, 0);
            this.pnlCurrentNav.Name = "pnlCurrentNav";
            this.pnlCurrentNav.Size = new System.Drawing.Size(1098, 64);
            this.pnlCurrentNav.TabIndex = 3;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(128)))), ((int)(((byte)(134)))));
            this.btnNewOrder.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewOrder.ForeColor = System.Drawing.Color.White;
            this.btnNewOrder.Location = new System.Drawing.Point(692, 7);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(105, 49);
            this.btnNewOrder.TabIndex = 16;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = false;
            this.btnNewOrder.Click += new System.EventHandler(this.BtnNewOrder_Click);
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(128)))), ((int)(((byte)(134)))));
            this.btnSubmitOrder.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitOrder.ForeColor = System.Drawing.Color.White;
            this.btnSubmitOrder.Location = new System.Drawing.Point(976, 7);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(105, 49);
            this.btnSubmitOrder.TabIndex = 15;
            this.btnSubmitOrder.Text = "Submit";
            this.btnSubmitOrder.UseVisualStyleBackColor = false;
            this.btnSubmitOrder.Click += new System.EventHandler(this.BtnSubmitOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(21, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Place Order";
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(128)))), ((int)(((byte)(134)))));
            this.btnViewOrders.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrders.ForeColor = System.Drawing.Color.White;
            this.btnViewOrders.Location = new System.Drawing.Point(837, 7);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(105, 49);
            this.btnViewOrders.TabIndex = 14;
            this.btnViewOrders.Text = "View All Orders";
            this.btnViewOrders.UseVisualStyleBackColor = false;
            this.btnViewOrders.Click += new System.EventHandler(this.BtnViewOrders_Click);
            // 
            // flowLayoutPanelMenuItems
            // 
            this.flowLayoutPanelMenuItems.AutoScroll = true;
            this.flowLayoutPanelMenuItems.Location = new System.Drawing.Point(29, 137);
            this.flowLayoutPanelMenuItems.Name = "flowLayoutPanelMenuItems";
            this.flowLayoutPanelMenuItems.Size = new System.Drawing.Size(635, 516);
            this.flowLayoutPanelMenuItems.TabIndex = 4;
            // 
            // btnAllItems
            // 
            this.btnAllItems.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllItems.Location = new System.Drawing.Point(27, 90);
            this.btnAllItems.Name = "btnAllItems";
            this.btnAllItems.Size = new System.Drawing.Size(97, 39);
            this.btnAllItems.TabIndex = 5;
            this.btnAllItems.Text = "All";
            this.btnAllItems.UseVisualStyleBackColor = true;
            this.btnAllItems.Click += new System.EventHandler(this.btnAllItems_Click);
            // 
            // btnAppItems
            // 
            this.btnAppItems.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppItems.Location = new System.Drawing.Point(130, 90);
            this.btnAppItems.Name = "btnAppItems";
            this.btnAppItems.Size = new System.Drawing.Size(97, 39);
            this.btnAppItems.TabIndex = 6;
            this.btnAppItems.Text = "Appetizers";
            this.btnAppItems.UseVisualStyleBackColor = true;
            this.btnAppItems.Click += new System.EventHandler(this.btnAppItems_Click);
            // 
            // btnKitchenItems
            // 
            this.btnKitchenItems.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitchenItems.Location = new System.Drawing.Point(233, 90);
            this.btnKitchenItems.Name = "btnKitchenItems";
            this.btnKitchenItems.Size = new System.Drawing.Size(97, 39);
            this.btnKitchenItems.TabIndex = 7;
            this.btnKitchenItems.Text = "Kitchen Items";
            this.btnKitchenItems.UseVisualStyleBackColor = true;
            this.btnKitchenItems.Click += new System.EventHandler(this.btnKitchenItems_Click);
            // 
            // btnSushiItems
            // 
            this.btnSushiItems.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSushiItems.Location = new System.Drawing.Point(336, 90);
            this.btnSushiItems.Name = "btnSushiItems";
            this.btnSushiItems.Size = new System.Drawing.Size(97, 39);
            this.btnSushiItems.TabIndex = 8;
            this.btnSushiItems.Text = "Sushi";
            this.btnSushiItems.UseVisualStyleBackColor = true;
            this.btnSushiItems.Click += new System.EventHandler(this.btnSushiItems_Click);
            // 
            // btnDessertItems
            // 
            this.btnDessertItems.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDessertItems.Location = new System.Drawing.Point(439, 90);
            this.btnDessertItems.Name = "btnDessertItems";
            this.btnDessertItems.Size = new System.Drawing.Size(97, 39);
            this.btnDessertItems.TabIndex = 9;
            this.btnDessertItems.Text = "Dessert";
            this.btnDessertItems.UseVisualStyleBackColor = true;
            this.btnDessertItems.Click += new System.EventHandler(this.btnDessertItems_Click);
            // 
            // btnDrinkItems
            // 
            this.btnDrinkItems.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrinkItems.Location = new System.Drawing.Point(542, 90);
            this.btnDrinkItems.Name = "btnDrinkItems";
            this.btnDrinkItems.Size = new System.Drawing.Size(97, 39);
            this.btnDrinkItems.TabIndex = 10;
            this.btnDrinkItems.Text = "Drinks";
            this.btnDrinkItems.UseVisualStyleBackColor = true;
            this.btnDrinkItems.Click += new System.EventHandler(this.btnDrinkItems_Click);
            // 
            // flowLayoutPanelOrder
            // 
            this.flowLayoutPanelOrder.AutoScroll = true;
            this.flowLayoutPanelOrder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanelOrder.Location = new System.Drawing.Point(692, 103);
            this.flowLayoutPanelOrder.Name = "flowLayoutPanelOrder";
            this.flowLayoutPanelOrder.Size = new System.Drawing.Size(381, 288);
            this.flowLayoutPanelOrder.TabIndex = 11;
            this.flowLayoutPanelOrder.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanelOrder_ControlAdded);
            this.flowLayoutPanelOrder.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.FlowLayoutPanelOrder_ControlRemoved);
            // 
            // lblOrderTitle
            // 
            this.lblOrderTitle.AutoSize = true;
            this.lblOrderTitle.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblOrderTitle.Location = new System.Drawing.Point(659, 67);
            this.lblOrderTitle.Name = "lblOrderTitle";
            this.lblOrderTitle.Size = new System.Drawing.Size(135, 26);
            this.lblOrderTitle.TabIndex = 12;
            this.lblOrderTitle.Text = "Current Order";
            // 
            // gBoxTotals
            // 
            this.gBoxTotals.Controls.Add(this.lblOutputTotal);
            this.gBoxTotals.Controls.Add(this.lblOutputTax);
            this.gBoxTotals.Controls.Add(this.lblOutputSubTotal);
            this.gBoxTotals.Controls.Add(this.lblTotal);
            this.gBoxTotals.Controls.Add(this.lblTax);
            this.gBoxTotals.Controls.Add(this.lblSubTotal);
            this.gBoxTotals.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxTotals.ForeColor = System.Drawing.Color.DimGray;
            this.gBoxTotals.Location = new System.Drawing.Point(672, 401);
            this.gBoxTotals.Margin = new System.Windows.Forms.Padding(2);
            this.gBoxTotals.Name = "gBoxTotals";
            this.gBoxTotals.Padding = new System.Windows.Forms.Padding(2);
            this.gBoxTotals.Size = new System.Drawing.Size(219, 182);
            this.gBoxTotals.TabIndex = 13;
            this.gBoxTotals.TabStop = false;
            this.gBoxTotals.Text = "Order Totals";
            // 
            // lblOutputTotal
            // 
            this.lblOutputTotal.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputTotal.ForeColor = System.Drawing.Color.DimGray;
            this.lblOutputTotal.Location = new System.Drawing.Point(99, 135);
            this.lblOutputTotal.Name = "lblOutputTotal";
            this.lblOutputTotal.Size = new System.Drawing.Size(95, 27);
            this.lblOutputTotal.TabIndex = 21;
            this.lblOutputTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutputTax
            // 
            this.lblOutputTax.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputTax.ForeColor = System.Drawing.Color.DimGray;
            this.lblOutputTax.Location = new System.Drawing.Point(99, 82);
            this.lblOutputTax.Name = "lblOutputTax";
            this.lblOutputTax.Size = new System.Drawing.Size(95, 27);
            this.lblOutputTax.TabIndex = 20;
            this.lblOutputTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutputSubTotal
            // 
            this.lblOutputSubTotal.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputSubTotal.ForeColor = System.Drawing.Color.DimGray;
            this.lblOutputSubTotal.Location = new System.Drawing.Point(99, 34);
            this.lblOutputSubTotal.Name = "lblOutputSubTotal";
            this.lblOutputSubTotal.Size = new System.Drawing.Size(95, 27);
            this.lblOutputSubTotal.TabIndex = 19;
            this.lblOutputSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotal.Location = new System.Drawing.Point(37, 139);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 19);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "Total:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.ForeColor = System.Drawing.Color.DimGray;
            this.lblTax.Location = new System.Drawing.Point(48, 86);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(38, 19);
            this.lblTax.TabIndex = 17;
            this.lblTax.Text = "Tax:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubTotal.Location = new System.Drawing.Point(12, 38);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(74, 19);
            this.lblSubTotal.TabIndex = 16;
            this.lblSubTotal.Text = "Subtotal:";
            // 
            // btnCashOut
            // 
            this.btnCashOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(180)))), ((int)(((byte)(98)))));
            this.btnCashOut.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashOut.ForeColor = System.Drawing.Color.White;
            this.btnCashOut.Location = new System.Drawing.Point(690, 601);
            this.btnCashOut.Name = "btnCashOut";
            this.btnCashOut.Size = new System.Drawing.Size(381, 39);
            this.btnCashOut.TabIndex = 16;
            this.btnCashOut.Text = "Cash Out";
            this.btnCashOut.UseVisualStyleBackColor = false;
            this.btnCashOut.Visible = false;
            this.btnCashOut.Click += new System.EventHandler(this.BtnCashOut_Click);
            // 
            // gboxCashout
            // 
            this.gboxCashout.Controls.Add(this.lblOutputChange);
            this.gboxCashout.Controls.Add(this.lblChangeInstruct);
            this.gboxCashout.Controls.Add(this.txtCashReceived);
            this.gboxCashout.Controls.Add(this.lblCashInstruction);
            this.gboxCashout.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxCashout.ForeColor = System.Drawing.Color.DimGray;
            this.gboxCashout.Location = new System.Drawing.Point(896, 401);
            this.gboxCashout.Name = "gboxCashout";
            this.gboxCashout.Size = new System.Drawing.Size(190, 182);
            this.gboxCashout.TabIndex = 17;
            this.gboxCashout.TabStop = false;
            this.gboxCashout.Text = "Cash Out";
            // 
            // lblOutputChange
            // 
            this.lblOutputChange.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputChange.ForeColor = System.Drawing.Color.DimGray;
            this.lblOutputChange.Location = new System.Drawing.Point(30, 137);
            this.lblOutputChange.Name = "lblOutputChange";
            this.lblOutputChange.Size = new System.Drawing.Size(130, 23);
            this.lblOutputChange.TabIndex = 20;
            this.lblOutputChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChangeInstruct
            // 
            this.lblChangeInstruct.AutoSize = true;
            this.lblChangeInstruct.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeInstruct.ForeColor = System.Drawing.Color.DimGray;
            this.lblChangeInstruct.Location = new System.Drawing.Point(23, 105);
            this.lblChangeInstruct.Name = "lblChangeInstruct";
            this.lblChangeInstruct.Size = new System.Drawing.Size(147, 18);
            this.lblChangeInstruct.TabIndex = 19;
            this.lblChangeInstruct.Text = "Change for Customer:";
            // 
            // txtCashReceived
            // 
            this.txtCashReceived.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashReceived.ForeColor = System.Drawing.Color.DimGray;
            this.txtCashReceived.Location = new System.Drawing.Point(30, 57);
            this.txtCashReceived.Name = "txtCashReceived";
            this.txtCashReceived.Size = new System.Drawing.Size(132, 35);
            this.txtCashReceived.TabIndex = 18;
            this.txtCashReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCashInstruction
            // 
            this.lblCashInstruction.AutoSize = true;
            this.lblCashInstruction.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashInstruction.ForeColor = System.Drawing.Color.DimGray;
            this.lblCashInstruction.Location = new System.Drawing.Point(27, 32);
            this.lblCashInstruction.Name = "lblCashInstruction";
            this.lblCashInstruction.Size = new System.Drawing.Size(138, 18);
            this.lblCashInstruction.TabIndex = 17;
            this.lblCashInstruction.Text = "Enter cash received:";
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Items.AddRange(new object[] {
            "Table - 1",
            "Table - 2",
            "Table - 3",
            "Table - 4",
            "Table - 5",
            "Table - 6",
            "Table - 7",
            "Table - 8",
            "Table - 9",
            "Table - 10"});
            this.comboBoxTables.Location = new System.Drawing.Point(957, 74);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(116, 23);
            this.comboBoxTables.TabIndex = 18;
            this.comboBoxTables.Text = "     Select Table";
            // 
            // formOrders
            // 
            this.AcceptButton = this.btnCashOut;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1098, 660);
            this.Controls.Add(this.comboBoxTables);
            this.Controls.Add(this.gboxCashout);
            this.Controls.Add(this.btnCashOut);
            this.Controls.Add(this.gBoxTotals);
            this.Controls.Add(this.lblOrderTitle);
            this.Controls.Add(this.flowLayoutPanelOrder);
            this.Controls.Add(this.btnDrinkItems);
            this.Controls.Add(this.btnDessertItems);
            this.Controls.Add(this.btnSushiItems);
            this.Controls.Add(this.btnKitchenItems);
            this.Controls.Add(this.btnAppItems);
            this.Controls.Add(this.btnAllItems);
            this.Controls.Add(this.flowLayoutPanelMenuItems);
            this.Controls.Add(this.pnlCurrentNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formOrders";
            this.Load += new System.EventHandler(this.formOrders_Load);
            this.pnlCurrentNav.ResumeLayout(false);
            this.pnlCurrentNav.PerformLayout();
            this.gBoxTotals.ResumeLayout(false);
            this.gBoxTotals.PerformLayout();
            this.gboxCashout.ResumeLayout(false);
            this.gboxCashout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlCurrentNav;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAllItems;
        private System.Windows.Forms.Button btnAppItems;
        private System.Windows.Forms.Button btnKitchenItems;
        private System.Windows.Forms.Button btnSushiItems;
        private System.Windows.Forms.Button btnDessertItems;
        private System.Windows.Forms.Button btnDrinkItems;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOrder;
        private System.Windows.Forms.Label lblOrderTitle;
        private System.Windows.Forms.GroupBox gBoxTotals;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubTotal;
        public System.Windows.Forms.Label lblOutputTotal;
        public System.Windows.Forms.Label lblOutputTax;
        public System.Windows.Forms.Label lblOutputSubTotal;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.GroupBox gboxCashout;
        private System.Windows.Forms.TextBox txtCashReceived;
        private System.Windows.Forms.Label lblCashInstruction;
        public System.Windows.Forms.Label lblOutputChange;
        private System.Windows.Forms.Label lblChangeInstruct;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.ComboBox comboBoxTables;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenuItems;
        public System.Windows.Forms.Button btnCashOut;
    }
}