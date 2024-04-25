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
    public partial class orderedItemControl : UserControl
    {   
        
        public orderedItemControl()
        {
            InitializeComponent();
        }
        //Backing fields
        private string _itemName;
        private decimal _itemPrice;
        private Image _icon;
        private int _numItems = 1;

        [Category("Custom Properties")]     //Allows the property to show up in Design view in a new Category
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; lblItemName.Text = value; }    //Updates backing field and the label
        }
        [Category("Custom Properties")]     //Allows the property to show up in Design view in a new Category
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; picItem.Image = value; }   //Updates backing field and the icon
        }

        public decimal ItemPrice
        {
            get { return _itemPrice; }
            set { _itemPrice = value; lblItemPrice.Text = value.ToString(); }   //Updates backing field and the label
        }

        public int ItemNum
        {
            get { return _numItems; }
            set { _numItems = value; }
        }

        private void BtnRemoveItem_Click(object sender, EventArgs e)
        {
            ItemNum--;
            formMainConsole.newOrders.thisOrder.Subtract_From_Subtotal(ItemPrice);

            this.Dispose();    
        }
    }
}
