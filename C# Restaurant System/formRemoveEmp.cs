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
    public partial class formRemoveEmp : Form
    {
        public formRemoveEmp()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRemoveEmp_Click(object sender, EventArgs e)
        {
            //Walks through the emp COntrols in the flowPanel and when finds a match to input it disposes the control
            foreach (employeeControl c in formMainConsole.newEmployee.flowLayoutPanelEmployees.Controls)
            {
                if (cboxEmps.SelectedItem == c.EmployeeFirstname)
                {
                    c.Dispose();                       
                }
            }

            //Clears the emp list
            formMainConsole.newEmployee.listEmployees.Clear();
            cboxEmps.Items.Clear();
            cboxEmps.Text = "";

            //Walks though again and readds the controls to the list
            foreach (employeeControl c in formMainConsole.newEmployee.flowLayoutPanelEmployees.Controls)
            {
                formMainConsole.newEmployee.listEmployees.Add(c);
                cboxEmps.Items.Add(c.EmployeeFirstname);
            }

            this.Close();
        }

        private void FormRemoveEmp_Load(object sender, EventArgs e)
        {
            //When the form loads it fills the list with the emp controls in the flow panel
            foreach(employeeControl c in formMainConsole.newEmployee.flowLayoutPanelEmployees.Controls)
            {
                cboxEmps.Items.Add(c.EmployeeFirstname);
            }
        }
    }
}
