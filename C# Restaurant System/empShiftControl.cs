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
    public partial class empShiftControl : UserControl
    {
        public empShiftControl()
        {
            InitializeComponent();
        }

        //Backing Fields
        private Image _icon;
        private string _empName;
        private string _empTime;

        [Category ("Custom Properties")]    //Allows the property to show up in Design View in a new Category
        public string shiftEmpName
        {
            get { return _empName; }
            set { _empName = value; lblEmpName.Text = value; }      //Updates backing field and label
        }
        [Category("Custom Properties")]     //Allows the property to show up in Design View in a new Category
        public string shiftEmpTime
        {
            get { return _empTime; }
            set { _empTime = value; lblShiftTime.Text = value; }    //Updates backing field and label
        }
        [Category("Custom Properties")]     //Allows the property to show up in Design View in a new Category
        public Image icon
        {
            get { return _icon; }
            set { _icon = value; picEmp.Image = value; }            //Updates backing field and icon
        }
    }   
}
