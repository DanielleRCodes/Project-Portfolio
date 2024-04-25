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
    public partial class formEditEmp : Form
    {
        //Local string variables
        private string selectedEmp = "";
        private string selectedField = "";
        private string newInformation = "";
        private string newFirstName = "";

        public formEditEmp()
        {
            InitializeComponent();
        }

        private void FormEditEmp_Load(object sender, EventArgs e)
        {
            //When this form loads in walks through the emp Controls in the flow panel and adds each controls first name
            //to the combobox
            foreach (employeeControl c in formMainConsole.newEmployee.flowLayoutPanelEmployees.Controls)
            {
                cboxEmps.Items.Add(c.EmployeeFirstname);
            }
        }
        

        private void BtnGo_Click(object sender, EventArgs e)
        {        
            //When user clicks Go the user input is stored in the variables
            selectedEmp = cboxEmps.SelectedItem.ToString();
            selectedField = cboxField.SelectedItem.ToString();
            newInformation = txtEmpInformation.Text;

            //Depending on the field the user wanted to update determines the case of the switch
            switch (selectedField)
            {
                case "First Name":
                    {
                        //Updates with new information
                        foreach (employeeControl c in formMainConsole.newEmployee.flowLayoutPanelEmployees.Controls)
                        {
                            if (c.EmployeeFirstname == selectedEmp)
                            {
                                c.EmployeeFirstname = newInformation;
                                break;
                            }
                        }
                        break;
                    }
                case "Last Name":
                    {
                        //Updates with new information
                        foreach (employeeControl c in formMainConsole.newEmployee.flowLayoutPanelEmployees.Controls)
                        {
                            if (c.EmployeeFirstname == selectedEmp)
                            {
                                c.EmployeeLastName = newInformation;
                            }
                        }
                        break;
                    }
                case "Position":
                    {
                        //Updates with new information
                        foreach (employeeControl c in formMainConsole.newEmployee.flowLayoutPanelEmployees.Controls)
                        {
                            if (c.EmployeeFirstname == selectedEmp)
                            {
                                c.EmployeePosition = newInformation;
                            }
                        }
                        break;
                    }
            }


            lblInstructions.Visible = false;
            cboxEmps.Visible = false;
            btnGo.Visible = false;
            this.Close();
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEditFirstName_Click(object sender, EventArgs e)
        {
            try
            {
                newFirstName = txtEmpInformation.Text;

                foreach (employeeControl c in formMainConsole.newEmployee.flowLayoutPanelEmployees.Controls)
                {
                    if (c.EmployeeFirstname == selectedEmp)
                    {
                        c.EmployeeFirstname = newFirstName;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter First Name");
            }
        }

        

        

        
    }
}
