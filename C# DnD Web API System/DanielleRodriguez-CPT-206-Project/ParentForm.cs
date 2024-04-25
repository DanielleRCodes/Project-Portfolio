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
    public partial class ParentForm : Form
    {
        Classes_Form formClasses = new Classes_Form();
        Spells_Form formSpells = new Spells_Form(); 
        Monsters_Form formMonsters = new Monsters_Form();
        Test_API_Form formTest = new Test_API_Form();

        public ParentForm()
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
            loadform(formClasses);
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            loadform(formClasses);
        }

        private void btnSpells_Click(object sender, EventArgs e)
        {
            loadform(formSpells);
        }

        private void btnViewMonsters_Click(object sender, EventArgs e)
        {
            loadform(formMonsters);
        }

        private void btnTestAPIForm_Click(object sender, EventArgs e)
        {
            loadform(formTest);
        }
    }
}
