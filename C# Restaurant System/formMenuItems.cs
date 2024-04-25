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
    public partial class formMenuItems : Form
    {       

        public formMenuItems()
        {
            InitializeComponent();
        }

        //When this form loads it adds the menuItemControls in the mainConsole form list to the flow panel
        private void FormMenuItems_Load(object sender, EventArgs e)
        {
            foreach (menuItemControl c in formMainConsole.listMenuItems)
            {
                flowLayoutPanelMenuItemsManager.Controls.Add(c);
            }
        }

        //Makes all the menuItemControls visible in the flow panel
        private void BtnAllItems_Click(object sender, EventArgs e)
        {
            foreach (menuItemControl c in flowLayoutPanelMenuItemsManager.Controls)
            {
                c.Visible = true;
            }
        }

        //Makes only the menuItemControls with "Appeziter" as the lblFoodTypeName visible
        private void BtnAppItems_Click(object sender, EventArgs e)
        {
            foreach (menuItemControl c in flowLayoutPanelMenuItemsManager.Controls)
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

        //Makes only the menuItemControls with "Kitchen" as the lblFoodTypeName visible
        private void BtnKitchenItems_Click(object sender, EventArgs e)
        {
            foreach (menuItemControl c in flowLayoutPanelMenuItemsManager.Controls)
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

        //Makes only the menuItemControls with "Sushi" as the lblFoodTypeName visible
        private void BtnSushiItems_Click(object sender, EventArgs e)
        {
            foreach (menuItemControl c in flowLayoutPanelMenuItemsManager.Controls)
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

        //Makes only the menuItemControls with "Dessert" as the lblFoodTypeName visible
        private void BtnDessertItems_Click(object sender, EventArgs e)
        {
            foreach (menuItemControl c in flowLayoutPanelMenuItemsManager.Controls)
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

        //Makes only the menuItemControls with "Drink" as the lblFoodTypeName visible
        private void BtnDrinkItems_Click(object sender, EventArgs e)
        {
            foreach (menuItemControl c in flowLayoutPanelMenuItemsManager.Controls)
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

        //These buttons will be added to the program later
        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Under Construction! :)");
        }

        private void BtnRemoveItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Under Construction! :)");
        }

        private void BtnManageSpecials_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Under Construction! :)");
        }
    }
}
