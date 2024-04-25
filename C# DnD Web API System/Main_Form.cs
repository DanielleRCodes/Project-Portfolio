using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanielleRodriguez_CPT_206_Project
{
    public partial class Main_Form : Form
    {       
        public static Monsters_Form formMonsters = new Monsters_Form();
        

        public Main_Form()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            //Allows all the forms to be loaded into the main panel
            if (this.pnlLoadForms.Controls.Count > 0)
            {
                this.pnlLoadForms.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlLoadForms.Controls.Add(f);
            this.pnlLoadForms.Tag = f;
            f.Show();            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            Dice_Roller_Form form = new Dice_Roller_Form();
            form.StartPosition = FormStartPosition.Manual;
            form.Left = 332;
            form.Top = 8;
            form.Show();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            loadform(formMonsters);
        }            

        private void btnViewMonsters_Click(object sender, EventArgs e)
        {
            loadform(formMonsters);
        }       
    }
}
