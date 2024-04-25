using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace DanielleRodriguez_CPT_206_Project
{
    public partial class Monsters_Form : Form
    {
        public Monsters_Form()
        {
            InitializeComponent();
        }
        
        //Method that uses my monster class and connects to the DnD Web API and retrieves monster info
        private void getMonsters()
        {
            using (WebClient client = new WebClient())
            {
                string url = "https://www.dnd5eapi.co/api/monsters";
                var json = client.DownloadString(url);
                BasicMonsterConnection.root Info = JsonConvert.DeserializeObject<BasicMonsterConnection.root>(json);

                foreach (var item in Info.results)
                {                   
                    SelectMonsterControl newMonster = new SelectMonsterControl();
                    newMonster.MonsterName = item.name;
                    newMonster.MonsterIndex = item.index;
                    newMonster.MonsterURL = item.url;
                    newMonster.MonsterType = getMonsterType(item.url);
                    newMonster.ChangePicture(newMonster.MonsterType);
                    flowPanelAllMonsters.Controls.Add(newMonster);                    
                }
            }
        }

        private string getMonsterType(string index)
        {
            string monType = "";
            using (WebClient client = new WebClient())
            {
                string url = "https://www.dnd5eapi.co" + index;
                var json = client.DownloadString(url);
                DetailedMonsterConnection.root Info = JsonConvert.DeserializeObject<DetailedMonsterConnection.root>(json);

                monType = Info.type;

                return monType;
            }
        }

        

        private void Monsters_Form_Load(object sender, EventArgs e)
        {
            getMonsters();
        }

        private void btnFilterType_Click(object sender, EventArgs e)
        {
            string selection = cboxMonsterTypes.SelectedItem.ToString();

            switch (selection)
            {
                case "All":
                    foreach (SelectMonsterControl c in flowPanelAllMonsters.Controls)
                    {
                        c.Visible = true;
                    }
                    break;

                case "Aberration":
                    foreach (SelectMonsterControl c in flowPanelAllMonsters.Controls)
                    {
                        if (c.MonsterType == "aberration")
                        {
                            c.Visible = true;
                        }
                        else
                        {
                            c.Visible = false;
                        }
                    }
                    break;

                case "Beast":
                    foreach (SelectMonsterControl c in flowPanelAllMonsters.Controls)
                    {
                        if (c.MonsterType == "beast")
                        {
                            c.Visible = true;
                        }
                        else
                        {
                            c.Visible = false;
                        }
                    }
                    break;

                case "Celestial":
                    foreach (SelectMonsterControl c in flowPanelAllMonsters.Controls)
                    {
                        if (c.MonsterType == "celestial")
                        {
                            c.Visible = true;
                        }
                        else
                        {
                            c.Visible = false;
                        }
                    }
                    break;

                case "Construct":
                    foreach (SelectMonsterControl c in flowPanelAllMonsters.Controls)
                    {
                        if (c.MonsterType == "construct")
                        {
                            c.Visible = true;
                        }
                        else
                        {
                            c.Visible = false;
                        }
                    }
                    break;

                case "Dragon":
                    foreach (SelectMonsterControl c in flowPanelAllMonsters.Controls)
                    {
                        if (c.MonsterType == "dragon")
                        {
                            c.Visible = true;
                        }
                        else
                        {
                            c.Visible = false;
                        }
                    }
                    break;

                case "Elemental":
                    foreach (SelectMonsterControl c in flowPanelAllMonsters.Controls)
                    {
                        if (c.MonsterType == "elemental")
                        {
                            c.Visible = true;
                        }
                        else
                        {
                            c.Visible = false;
                        }
                    }
                    break;

                case "Fey":
                    foreach (SelectMonsterControl c in flowPanelAllMonsters.Controls)
                    {
                        if (c.MonsterType == "fey")
                        {
                            c.Visible = true;
                        }
                        else
                        {
                            c.Visible = false;
                        }
                    }
                    break;

                case "Fiend":
                    foreach (SelectMonsterControl c in flowPanelAllMonsters.Controls)
                    {
                        if (c.MonsterType == "fiend")
                        {
                            c.Visible = true;
                        }
                        else
                        {
                            c.Visible = false;
                        }
                    }
                    break;

                case "Giant":
                    foreach (SelectMonsterControl c in flowPanelAllMonsters.Controls)
                    {
                        if (c.MonsterType == "giant")
                        {
                            c.Visible = true;
                        }
                        else
                        {
                            c.Visible = false;
                        }
                    }
                    break;

                case "Humanoid":
                    foreach (SelectMonsterControl c in flowPanelAllMonsters.Controls)
                    {
                        if (c.MonsterType == "humanoid")
                        {
                            c.Visible = true;
                        }
                        else
                        {
                            c.Visible = false;
                        }
                    }
                    break;

                case "Monstrosity":
                    foreach (SelectMonsterControl c in flowPanelAllMonsters.Controls)
                    {
                        if (c.MonsterType == "monstrosity")
                        {
                            c.Visible = true;
                        }
                        else
                        {
                            c.Visible = false;
                        }
                    }
                    break;

                case "Ooze":
                    foreach (SelectMonsterControl c in flowPanelAllMonsters.Controls)
                    {
                        if (c.MonsterType == "ooze")
                        {
                            c.Visible = true;
                        }
                        else
                        {
                            c.Visible = false;
                        }
                    }
                    break;

                case "Plant":
                    foreach (SelectMonsterControl c in flowPanelAllMonsters.Controls)
                    {
                        if (c.MonsterType == "plant")
                        {
                            c.Visible = true;
                        }
                        else
                        {
                            c.Visible = false;
                        }
                    }
                    break;

                case "Undead":
                    foreach (SelectMonsterControl c in flowPanelAllMonsters.Controls)
                    {
                        if (c.MonsterType == "undead")
                        {
                            c.Visible = true;
                        }
                        else
                        {
                            c.Visible = false;
                        }
                    }
                    break;
            }
        }
    }
}
