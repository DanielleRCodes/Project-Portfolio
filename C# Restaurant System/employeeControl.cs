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
    public partial class employeeControl : UserControl
    {
        public employeeControl()
        {
            InitializeComponent();
        }

        //Backing Fields
        private string _empFirstName;
        private string _empLastname;
        private string _empPosition;
        private Image _empIcon;

        //Properties
        [Category("Custom Properties")]     //Allows the property to show up in Design view in a new Category
        public string EmployeeFirstname
        {
            get { return _empFirstName; }
            set { _empFirstName = value; lblFirstName.Text = value; }   //Updates backing field and label
        }

        [Category("Custom Properties")]     //Allows the property to show up in Design view in a new Category
        public string EmployeeLastName
        {
            get { return _empLastname; }
            set { _empLastname = value; lblLastName.Text = value; }     //Updates backing field and label
        }

        [Category("Custom Properties")]     //Allows the property to show up in Design view in a new Category
        public string EmployeePosition
        {
            get { return _empPosition; }
            set { _empPosition = value; lblPosition.Text = value; ; }   //Updates backing field and label
        }

        [Category("Custom Properties")]     //Allows the property to show up in Design view in a new Category
        public Image EmployeeIcon
        {
            get { return _empIcon; }
            set { _empIcon = value; picEmpIcon.Image = value; }     //Updates backing field and icon
        }

        //Constructor
        public employeeControl(string fname, string lname, string pos)
        {
            EmployeeFirstname = fname;
            EmployeeLastName = lname;
            EmployeePosition = pos;
        }

        //Functions
        public void ChangeIconManager(Image pic)
        {
            EmployeeIcon = pic;
        }
    }
}
