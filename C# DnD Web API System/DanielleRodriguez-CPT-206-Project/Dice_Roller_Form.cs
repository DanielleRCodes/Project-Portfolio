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
    public partial class Dice_Roller_Form : Form
    {
        Random rand = new Random();
        private int diceCounter = 0;
        private int total = 0;
        private bool d20 = false;
        private bool d2 = false;
        private bool d4 = false;
        private bool d6 = false;
        private bool d8 = false;
        private bool d10 = false;
        private bool d12 = false;
        private bool dPercent = false;
        List<int> results = new List<int>();

        public Dice_Roller_Form()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnD20_Click(object sender, EventArgs e)
        {

            if (d2 == false && d4 == false && d6 == false && d8 == false && d10 == false && d12 == false && dPercent == false)
            {

                diceCounter++;
                d20 = true;
                lblNumberOfDice.Text = diceCounter.ToString();
            }
            else
            { 
                MessageBox.Show("Only one die type at a time please :)");
                
            }
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            
            if (d20 == false && d2 == false && d6 == false && d8 == false && d10 == false && d12 == false && dPercent == false)
            {
                diceCounter++;
                d4 = true;
                lblNumberOfDice.Text = diceCounter.ToString();
            }
            else
            {
                MessageBox.Show("Only one die type at a time please :)");
            }
        }

        private void btnD6_Click(object sender, EventArgs e)
        {
            
            if (d2 == false && d4 == false && d20 == false && d8 == false && d10 == false && d12 == false && dPercent == false)
            {
                diceCounter++;
                d6 = true;
                lblNumberOfDice.Text = diceCounter.ToString();
            }
            else
            {
                MessageBox.Show("Only one die type at a time please :)");
            }
        }

        private void btnD8_Click(object sender, EventArgs e)
        {
            
            if (d2 == false && d4 == false && d6 == false && d20 == false && d10 == false && d12 == false && dPercent == false)
            {
                diceCounter++;
                d8 = true;
                lblNumberOfDice.Text = diceCounter.ToString();
            }
            else
            {
                MessageBox.Show("Only one die type at a time please :)");
            }
        }

        private void btnD10_Click(object sender, EventArgs e)
        {
            
            if (d2 == false && d4 == false && d6 == false && d8 == false && d20 == false && d12 == false && dPercent == false)
            {
                diceCounter++;
                d10 = true;
                lblNumberOfDice.Text = diceCounter.ToString();
            }
            else
            {
                MessageBox.Show("Only one die type at a time please :)");
            }
        }

        private void btnD12_Click(object sender, EventArgs e)
        {
            
            if (d2 == false && d4 == false && d6 == false && d8 == false && d10 == false && d20 == false && dPercent == false)
            {
                diceCounter++;
                d12 = true;
                lblNumberOfDice.Text = diceCounter.ToString();
            }
            else
            {
                MessageBox.Show("Only one die type at a time please :)");
            }
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            
            if (d2 == false && d4 == false && d6 == false && d8 == false && d10 == false && d12 == false && d20 == false)
            {
                diceCounter++;
                dPercent = true;
                lblNumberOfDice.Text = diceCounter.ToString();
            }
            else
            {
                MessageBox.Show("Only one die type at a time please :)");
            }
        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            
            if (d20 == false && d4 == false && d6 == false && d8 == false && d10 == false && d12 == false && dPercent == false)
            {
                diceCounter++;
                d2 = true;
                lblNumberOfDice.Text = diceCounter.ToString();
            }
            else
            {
                MessageBox.Show("Only one die type at a time please :)");
            }
        }

        private void btnRollRice_Click(object sender, EventArgs e)
        {
            if (d20 == true)
            {
                for(int i = diceCounter; i > 0; i--)
                {
                    results.Add(rand.Next(1, 20));
                }
            }else if (d2 == true)
            {
                for (int i = diceCounter; i > 0; i--)
                {
                    results.Add(rand.Next(1, 2));
                }
            }
            else if (d4 == true)
            {
                for (int i = diceCounter; i > 0; i--)
                {
                    results.Add(rand.Next(1, 4));
                }
            }
            else if (d6 == true)
            {
                for (int i = diceCounter; i > 0; i--)
                {
                    results.Add(rand.Next(1, 6));
                }
            }
            else if (d8 == true)
            {
                for (int i = diceCounter; i > 0; i--)
                {
                    results.Add(rand.Next(1, 8));
                }
            }
            else if (d10 == true)
            {
                for (int i = diceCounter; i > 0; i--)
                {
                    results.Add(rand.Next(1, 10));
                }
            }
            else if (d12 == true)
            {
                for (int i = diceCounter; i > 0; i--)
                {
                    results.Add(rand.Next(1, 12));
                }
            }
            else if (dPercent == true)
            {
                for (int i = diceCounter; i > 0; i--)
                {
                    results.Add(rand.Next(1, 100));
                }
            }

            foreach (int i in results)
            {
                lboxRolls.Items.Add(i);
                total += i;
            }

            lblOutputTotalOfRoll.Text = total.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            diceCounter = 0;
            total = 0;
            lblNumberOfDice.Text = "0";
            d20 = false;
            d2 = false;
            d4 = false;
            d6 = false;
            d8 = false;
            d10 = false;
            d12 = false;
            dPercent = false;
            lboxRolls.Items.Clear();
            lblOutputTotalOfRoll.Text = "";
            results.Clear();
            
        }     
    }
}
