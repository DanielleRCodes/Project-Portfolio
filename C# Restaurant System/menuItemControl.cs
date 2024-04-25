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
    public partial class menuItemControl : UserControl
    {
        public menuItemControl()
        {
            InitializeComponent();
        }

        private string _itemName;
        private string _itemCategory;
        private string _itemPrice;
        private Image _icon;
        public decimal Price = 0.0m;

        [Category("Custom Properties")]         //Allows them to show up in the Design View under a new category
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; lblItemName.Text = value; }    //Updates backing field and the label
        }

        [Category("Custom Properties")]         //Allows them to show up in the Design View under a new category
        public string ItemCategory
        {
            get { return _itemCategory; }
            set { _itemCategory = value; lblCategory.Text = value; }    //Updates backing field and the label
        }

        [Category("Custom Properties")]         //Allows them to show up in the Design View under a new category
        public string ItemPrice
        {
            get { return _itemPrice; }
            set { _itemPrice = value; lblItemPrice.Text = value; Price = decimal.Parse(value); }    //Updates backing field and the label
        }

        [Category("Custom Properties")]         //Allows them to show up in the Design View under a new category
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; picMenuItem.Image = value; }   //Updates backing field and the icon
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {  
            //created the ordered item user control
            orderedItemControl selectedItem = new orderedItemControl();

            //sets the properties of the ordered item user control
            selectedItem.ItemName = _itemName;
            selectedItem.Icon = _icon;
            selectedItem.ItemPrice = decimal.Parse(_itemPrice);

            //addes that control to the list and flow panel and updates price
            formMainConsole.newOrders.listOrderedItems.Add(selectedItem);
            formMainConsole.newOrders.thisOrder.Add_To_Subtotal(decimal.Parse(ItemPrice));            
            formMainConsole.newOrders.flowLayoutPanelOrder.Controls.Add(selectedItem);


        }
    }
}
