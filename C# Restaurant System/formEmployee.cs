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
    public partial class formEmployee : Form
    {
        public List<employeeControl> listEmployees = new List<employeeControl>();   //List that holds employeeControls

        public formEmployee()
        {
            InitializeComponent();
        } 

        private void FormEmployee_Load(object sender, EventArgs e)
        {    
            //Walks through the flowPanel on Employee Controls and adds them to the list
            foreach(employeeControl c in flowLayoutPanelEmployees.Controls)
            {
                listEmployees.Add(c);
            }
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            //Opens the AddEmp form
            formAddEmp addForm = new formAddEmp();
            addForm.Show();
        }

        private void BtnEditEmp_Click(object sender, EventArgs e)
        {
            //Opens the EditEmp form
            formEditEmp editEmpForm = new formEditEmp();
            editEmpForm.Show();
        }

        private void BtnDeleteEmp_Click(object sender, EventArgs e)
        {
            //Open the DeleteEmp form
            formRemoveEmp removeForm = new formRemoveEmp();
            removeForm.Show();
        }

        
        private void BtnAllEmps_Click(object sender, EventArgs e)
        {
            //Walks through the list of empControls and turns them all visible
            foreach(employeeControl c in listEmployees)
            {
                c.Visible = true;
            }
        }

        private void BtnSushiEmps_Click(object sender, EventArgs e)
        {
            //Walks through the list of emp controls and makes on the "Sushi Chef" controls visible
            foreach (employeeControl c in listEmployees)
            {
                if (c.EmployeePosition == "Sushi Chef")
                {
                    c.Visible = true;
                }
                else
                {
                    c.Visible = false;
                }
            }
        }

        private void BtnKitchenEmps_Click(object sender, EventArgs e)
        {
            //Walks through the list of emp controls and makes on the "Kitchen Chef" controls visible
            foreach (employeeControl c in listEmployees)
            {
                if (c.EmployeePosition == "Kitchen Chef")
                {
                    c.Visible = true;
                }
                else
                {
                    c.Visible = false;
                }
            }
        }

        private void BtnWaitressEmps_Click(object sender, EventArgs e)
        {
            //Walks through the list of emp controls and makes on the "Waitress" controls visible
            foreach (employeeControl c in listEmployees)
            {
                if (c.EmployeePosition == "Waitress")
                {
                    c.Visible = true;
                }
                else
                {
                    c.Visible = false;
                }
            }
        }

        private void BtnHostessEmps_Click(object sender, EventArgs e)
        {
            //Walks through the list of emp controls and makes on the "Hostess" controls visible
            foreach (employeeControl c in listEmployees)
            {
                if (c.EmployeePosition == "Hostess")
                {
                    c.Visible = true;
                }
                else
                {
                    c.Visible = false;
                }
            }
        }

        private void BtnBartenderEmps_Click(object sender, EventArgs e)
        {
            //Walks through the list of emp controls and makes on the "Bartender" controls visible
            foreach (employeeControl c in listEmployees)
            {
                if (c.EmployeePosition == "Bartender")
                {
                    c.Visible = true;
                }
                else
                {
                    c.Visible = false;
                }
            }
        }

        private void BtnManagerEmps_Click(object sender, EventArgs e)
        {
            //Walks through the list of emp controls and makes on the "Manager" controls visible
            foreach (employeeControl c in listEmployees)
            {
                if (c.EmployeePosition == "Manager")
                {
                    c.Visible = true;
                }
                else
                {
                    c.Visible = false;
                }
            }
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature coming soon in Spring! :)");
        }

        private void BtnEditUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature coming soon in Spring! :)");
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature coming soon in Spring! :)");
        }
    }
}
