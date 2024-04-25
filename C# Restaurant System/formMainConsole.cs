using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DanielleRodriguez_CPT_185_Resturant_System
{
    public partial class formMainConsole : Form
    {
        //Form Objects
        public static formDashboard newDashboard = new formDashboard();     //Creates the form object
        public static formOrders newOrders = new formOrders();              //Creates the form object
        public static formEmployee newEmployee = new formEmployee();        //Creates the form object
        public static formMenuItems newMenuItems = new formMenuItems();     //Creates the form object
        public static List<Order> allOrders = new List<Order>();            //Creates a list that holds Order objects
        public static List<menuItemControl> listMenuItems = new List<menuItemControl>();    //Creates a list that holds menuItemControls
        public static decimal totalRev = 0.0m;     
        public static int numOrders = 0;
        public static int openOrdersCount = 0;
        public static int completeOrdersCount = 0;       

        public formMainConsole()
        {
            InitializeComponent();
        }

        
        public void loadform(object Form)                       
        {          
            //Allows all the forms to be loaded into the main panel
            if (this.pnlBackground.Controls.Count > 0)
            {
                this.pnlBackground.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlBackground.Controls.Add(f);
            this.pnlBackground.Tag = f;
            f.Show();

            //Adds the controls in the MenuItems form to the list so it can be used by the Orders Form
            foreach (menuItemControl c in newMenuItems.flowLayoutPanelMenuItemsManager.Controls)
            {
                listMenuItems.Add(c);                
            }
        }

        public void Create_New_Order_Form()         //Method to create a new Order Form
        {
            newOrders = new formOrders();
        }

       
        private void BtnExit_Click(object sender, EventArgs e)
        {        
            this.Close();
        }       //Exit Button

        private void BtnNavOrders_Click(object sender, EventArgs e)
        {
            //Loads the Form Object in the panel
            loadform(newOrders);

            //Walkthrough all the controls in the list making the Add button visible and adds them to the flowPanel
            foreach (menuItemControl c in listMenuItems)
            {
                c.btnAddItem.Visible = true;
                newOrders.flowLayoutPanelMenuItems.Controls.Add(c);
            }
        }

        private void formMainConsole_Load(object sender, EventArgs e)
        {
            loadform(newDashboard);
        }

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {                                   
            loadform(newDashboard);
        }

        private void btnNavEmployee_Click(object sender, EventArgs e)
        {
            loadform(newEmployee);
        }

        private void btnNavMenuItems_Click(object sender, EventArgs e)
        {
            loadform(newMenuItems);

            //Walks through the list of controls making the Add button not visible and adds them to the flowPanel
            foreach (menuItemControl c in formMainConsole.listMenuItems)
            {
                c.btnAddItem.Visible = false;
                newMenuItems.flowLayoutPanelMenuItemsManager.Controls.Add(c);
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature will be added in Spring! :)");
        }

        //
        public static void Update_Add_Total_Orders(int c) 
        {            
            openOrdersCount += c;
            openOrdersCount -= completeOrdersCount;
            formMainConsole.newDashboard.lblOutputOpenOrders.Text = openOrdersCount.ToString();
        }

        public static void Update_Add_Completed_Orders(int c)
        {
            completeOrdersCount += c;
            formMainConsole.newDashboard.lblOutputNumCompleteOrders.Text = completeOrdersCount.ToString(); 
        }

        public static void Update_Open_Orders(int c) //Numbers of time users hits Submit Buttom
        {
            openOrdersCount -= c;           
            formMainConsole.newDashboard.lblOutputOpenOrders.Text = openOrdersCount.ToString();
        }

        public static void Update_Total_rev()
        {
            newDashboard.lblOutputDailyRevenue.Text = totalRev.ToString("c");
        }

    }
}
