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
    public partial class formAddEmp : Form
    {
        string newEmpFirstName;
        string newEmpLastName;
        string newEmpPostion;
        Image newIcon;

        public formAddEmp()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddNewEmp_Click(object sender, EventArgs e)
        {
            //Takes user input and stores in variables
            newEmpFirstName = txtNewEmpFirstName.Text;
            newEmpLastName = txtNewEmpLastName.Text;
            newEmpPostion = cboxNewEmpPosition.SelectedItem.ToString();

            //Creates employee controls
            employeeControl newEmp = new employeeControl();

            //Passes the user input to the employee controls
            newEmp.EmployeeFirstname = newEmpFirstName;
            newEmp.EmployeeLastName = newEmpLastName;
            newEmp.EmployeePosition = newEmpPostion;
            
            //Stores Icon depending on the user input for the emp position
            switch (newEmpPostion)
            {
                case "Waitress":
                    {
                        newIcon = imageListEmpIcons.Images[3];
                        break;
                    }
                case "Hostess":
                    {
                        newIcon = imageListEmpIcons.Images[1];
                        break;
                    }
                case "Manager":
                    {
                        newIcon = imageListEmpIcons.Images[0];
                        break;
                    }
                case "Bartender":
                    {
                        newIcon = imageListEmpIcons.Images[2];
                        break;
                    }
                case "Kitchen Chef":
                    {
                        newIcon = imageListEmpIcons.Images[5];
                        break;
                    }
                case "Sushi Chef":
                    {
                        newIcon = imageListEmpIcons.Images[4];
                        break;
                    }
            }

            //Passes the Icon to the employee control
            newEmp.EmployeeIcon = newIcon;

            //Adds the employee control to the flowPanel
            formMainConsole.newEmployee.flowLayoutPanelEmployees.Controls.Add(newEmp);

            //Closes the form
            this.Close();
        }
    }
}
