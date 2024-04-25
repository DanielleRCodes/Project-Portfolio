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
    public partial class formOrders : Form
    {
        //Global Variables
        private const decimal TAX_RATE = 0.08m;
        public decimal subTotal = 0.0m;
        public decimal tax = 0.0m;
        public decimal total = 0.0m;

        public Order thisOrder;         //Creates Order Object;
        public formViewOrders newForm;  //Creates form Object;   
        public List<orderedItemControl> listOrderedItems = new List<orderedItemControl>();


        public formOrders()
        {
            InitializeComponent();
        }
        
        private void formOrders_Load(object sender, EventArgs e)
        {
            //Walks though the controls in the menu items list and makes the Add button visible and adds them to the 
            //menu items flow panel
            foreach (menuItemControl c in formMainConsole.listMenuItems)
            {
                c.btnAddItem.Visible = true;
                flowLayoutPanelMenuItems.Controls.Add(c);
                lblChangeInstruct.Visible = false;
            }
            thisOrder = new Order();
        }       

        private void flowLayoutPanelOrder_ControlAdded(object sender, ControlEventArgs e)
        {                     
            //When a controls is added to passes the order object properties to the labels to display
            lblOutputSubTotal.Text = thisOrder.orderSubTotal.ToString("c");
            lblOutputTax.Text = thisOrder.orderTax.ToString("c");
            lblOutputTotal.Text = thisOrder.orderTotal.ToString("c");                    
        }

        private void FlowLayoutPanelOrder_ControlRemoved(object sender, ControlEventArgs e)
        {
            //When a control is removed it passes the order object properties to the labels to display
            lblOutputSubTotal.Text = thisOrder.orderSubTotal.ToString("c");
            lblOutputTax.Text = thisOrder.orderTax.ToString("c");
            lblOutputTotal.Text = thisOrder.orderTotal.ToString("c");
        }

        private void BtnCashOut_Click(object sender, EventArgs e)
        {    
            formMainConsole.Update_Add_Completed_Orders(1); //Updates Completed Orders
            formMainConsole.totalRev += thisOrder.orderTotal; //Total Rev Stat on the Dashboard
            formMainConsole.Update_Total_rev();
            formMainConsole.Update_Open_Orders(1);

            //catchs if user clicks button without entering an amount
            if (txtCashReceived.Text == "")
            {
                MessageBox.Show("Please enter amount of cash!");
            }           
            else
            {
                decimal custMoney = decimal.Parse(txtCashReceived.Text);
                decimal custChange = 0.0m;               

                custChange = thisOrder.Change_For_Customer(custMoney);

                //catches if not enough money was collected
                if (custChange < 0)
                {
                    MessageBox.Show("Please collect the full amount from customer!");
                }
                else
                {
                    //Displays change
                    lblOutputChange.Text = custChange.ToString("c");
                    lblChangeInstruct.Visible = true;

                    btnCashOut.Visible = false;

                    //Walks through the order object in the orders list and removes the current order from the list
                    foreach (Order o in formMainConsole.allOrders)
                    {
                        if (o.orderTableNumber == thisOrder.orderTableNumber && o.orderTotal == thisOrder.orderTotal)
                        {
                            formMainConsole.allOrders.Remove(o);
                            formMainConsole.newOrders.thisOrder = new Order();
                            formMainConsole.newOrders.flowLayoutPanelOrder.Controls.Clear();
                            break;
                        }
                    }
                }
            }
        }        
              
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();           
        }


        //This methods sort the menu items
        private void btnAllItems_Click(object sender, EventArgs e)
        {
            foreach (menuItemControl c in flowLayoutPanelMenuItems.Controls)
            {
                c.Visible = true;
            }
        }

        private void btnAppItems_Click(object sender, EventArgs e)
        {
            foreach (menuItemControl c in flowLayoutPanelMenuItems.Controls)
            {
                if (c.ItemCategory == "Appetizer")
                {
                    c.Visible = true;
                }
                else
                {
                    c.Visible = false;
                }         
            }
        }

        private void btnKitchenItems_Click(object sender, EventArgs e)
        {
            foreach (menuItemControl c in flowLayoutPanelMenuItems.Controls)
            {
                if (c.ItemCategory == "Kitchen")
                {
                    c.Visible = true;
                }
                else
                {
                    c.Visible = false;
                }
            }
        }

        private void btnSushiItems_Click(object sender, EventArgs e)
        {
            foreach (menuItemControl c in flowLayoutPanelMenuItems.Controls)
            {
                if (c.ItemCategory == "Sushi")
                {
                    c.Visible = true;
                }
                else
                {
                    c.Visible = false;
                }
            }
        }

        private void btnDessertItems_Click(object sender, EventArgs e)
        {
            foreach (menuItemControl c in flowLayoutPanelMenuItems.Controls)
            {
                if (c.ItemCategory == "Dessert")
                {
                    c.Visible = true;
                }
                else
                {
                    c.Visible = false;
                }
            }
        }

        private void btnDrinkItems_Click(object sender, EventArgs e)
        {
            foreach (menuItemControl c in flowLayoutPanelMenuItems.Controls)
            {
                if (c.ItemCategory == "Drinks")
                {
                    c.Visible = true;
                }
                else
                {
                    c.Visible = false;
                }
            }
        }

        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            flowLayoutPanelOrder.Controls.Clear();
            lblOutputSubTotal.Text = "";
            lblOutputChange.Text = "";
            lblOutputTax.Text = "";
            lblOutputTotal.Text = "";
            btnCashOut.Visible = false;
            txtCashReceived.Text = "";

            thisOrder = new Order();            
        }

        private void BtnViewOrders_Click(object sender, EventArgs e)
        {
            newForm = new formViewOrders();
            newForm.Show();
        }

        private void BtnSubmitOrder_Click(object sender, EventArgs e)
        {
            thisOrder.Order_Submitted(true);        //Changes the properity to true on the object so we know its been submitted
                                                    //to the kitchen and can now be cashed out
            formMainConsole.Update_Add_Total_Orders(1);

            //Catches if they didn't make a selection
            if (comboBoxTables.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Table!");
            }
            else
            {
                //stores selection as a string variable
                string tableNum = comboBoxTables.SelectedItem.ToString();

                //updates order object with table number
                thisOrder.orderTableNumber = tableNum;

                //adds the selected item controls to a list
                foreach(orderedItemControl c in flowLayoutPanelOrder.Controls)
                {
                    thisOrder.Add_Ordered_Item_To_List(c);
                }

                flowLayoutPanelOrder.Controls.Clear();
                lblOutputSubTotal.Text = "";
                lblOutputChange.Text = "";
                lblOutputTax.Text = "";
                lblOutputTotal.Text = "";                
                txtCashReceived.Text = "";
                comboBoxTables.Text = "";               

                //adds the order object to the list of orders
                formMainConsole.allOrders.Add(thisOrder);

                //creates a new order object
                thisOrder = new Order();                
            }
        }       
    }

    public class Order
    {
        //Backing Fields
        private decimal _subtotal = 0.0m;
        private decimal _tax = 0.0m;
        private decimal _total = 0.0m;
        private string _tableNum = "";
        private bool _submit = false;

        //Properties
        public decimal orderTotal
        {
            get { return _total; }
            set { _total = value; }
        }
        public decimal orderTax
        {
            get { return _tax; }
            set { _tax = value; }
        }
        public decimal orderSubTotal
        {
            get { return _subtotal; }
            set { _subtotal = value; }
        }

        public string orderTableNumber
        {
            get { return _tableNum; }
            set { _tableNum = value; }
        }

        public bool orderSubmitted
        {
            get { return _submit; }
            set { _submit = value; }
        }

        private List<orderedItemControl> orderedItems = new List<orderedItemControl>();

        //Constructors
        public Order(decimal subTotal, decimal tax, decimal total)
        {
            orderSubTotal = subTotal;
            orderTax = tax;
            orderTotal = total;
        }

        public Order()
        {
            orderSubTotal = 0.0m;
            orderTax = 0.0m;
            orderTotal = 0.0m;
            orderTableNumber = "";
        }

        public void Add_To_Subtotal(decimal e)
        {
            _subtotal += e;
            _tax = _subtotal * .08m;
            _total = _subtotal + _tax;
            
        }

        public void Subtract_From_Subtotal(decimal e)
        {
            _subtotal -= e;
            _tax = _subtotal * .08m;
            _total = _subtotal + _tax;
        }

        public void Add_Ordered_Item_To_List(orderedItemControl c)
        {
            orderedItems.Add(c);
        }

        public void Remove_Ordered_Item_From_List(orderedItemControl c)
        {
            orderedItems.Remove(c);
        }

        public void Clear_Ordered_Items ()
        {
            orderedItems.Clear();
        }

        public List<orderedItemControl> Get_List_Of_Ordered_Items()
        {
            return orderedItems;
        }

        public void Order_Submitted(bool b)
        {
            orderSubmitted = b;
        }

        public decimal Change_For_Customer(decimal e)
        {
            decimal change = 0.0m;

            change = e - _total;

            return change;
        }        
    }
}
