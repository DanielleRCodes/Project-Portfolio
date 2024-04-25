using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanielleRodriguez_CPT_185_Resturant_System
{
    public partial class openOrderControl : UserControl
    {
        public openOrderControl()
        {
            InitializeComponent();
        }

        private string _orderName;
        private string _orderTotal;
        private Order _orderObject;

        public string OrderName
        {
            get { return _orderName; }
            set { _orderName = value; lblTableName.Text = value; }  //Updates backing field and the label
        }

        public string OrderTotal
        {
            get { return _orderTotal; }
            set { _orderTotal = value; lblOrderTotal.Text = value; }    //Updates backing field and the label
        }

        public Order OrderObject
        {
            get { return _orderObject; }
            set { _orderObject = value; }
        }

        private void BtnOpenOrder_Click(object sender, EventArgs e)
        {
            //Passes the Order Object to the Form
            formMainConsole.newOrders.thisOrder = OrderObject;

            //If the Order has been submitted then bash out button appears
            if(OrderObject.orderSubmitted == true)
            {
                formMainConsole.newOrders.btnCashOut.Visible = true;
            }

            //Fills Order From panel with Ordered Items
            foreach(orderedItemControl o in OrderObject.Get_List_Of_Ordered_Items())
            {
                formMainConsole.newOrders.flowLayoutPanelOrder.Controls.Add(o);
            }            

            formMainConsole.newOrders.newForm.Close();
           
        }


    }
}
