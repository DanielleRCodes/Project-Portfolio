using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanielleRodriguez_CPT_185_Resturant_System
{
    public partial class formViewOrders : Form
    {
        public formViewOrders()
        {
            InitializeComponent();
        }

        private void FormViewOrders_Load(object sender, EventArgs e)
        {
            foreach (Order o in formMainConsole.allOrders)
            {
                openOrderControl order = new openOrderControl();
                order.OrderName = o.orderTableNumber;
                order.OrderTotal = o.orderTotal.ToString("c");
                order.OrderObject = o;

                flowLayoutPanelopenOrders.Controls.Add(order);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }       

        private void FlowLayoutPanelopenOrders_ControlRemoved(object sender, ControlEventArgs e)
        {
            formMainConsole.openOrdersCount--;
            formMainConsole.newDashboard.lblOutputOpenOrders.Text = formMainConsole.openOrdersCount.ToString();
        }
    }
}
