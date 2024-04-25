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
    public partial class specialsControl : UserControl
    {
        public specialsControl()
        {
            InitializeComponent();
        }

        //Backing Fields
        private Image _icon;
        private string _specName;
        private string _specPrice;

        [Category("Custom Properties")]     //Allows the property to show up in Design View in a new Category
        public Image SpecialIcon
        {
            get { return _icon; }
            set { _icon = value; picSpecial.Image = value; }    //Updates backing field and icon
        }
        [Category("Custom Properties")]     //Allows the property to show up in Design View in a new Category
        public string SpecialName
        {
            get { return _specName; }
            set { _specName = value; lblSpecName.Text = value; }        //Updates backing field and label
        }
        [Category("Custom Properties")]     //Allows the property to show up in Design View in a new Category
        public string SpecialPrice
        {
            get { return _specPrice; }
            set { _specPrice = value; lblSpecPrice.Text = value; }      //Updates backing field and label
        }
    }
}
