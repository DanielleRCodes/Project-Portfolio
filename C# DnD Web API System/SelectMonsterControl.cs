using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanielleRodriguez_CPT_206_Project
{
    public partial class SelectMonsterControl : UserControl
    {
        public SelectMonsterControl()
        {
            InitializeComponent();
        }

        //Fields
        private string _monName;
        private string _monIndex;
        private string _monURL;
        private string _monCR;
        private string _monType;
        private Image _monIcon;

        //Properties
        [Category("Custom Properties")]
        public string MonsterName
        {
            get { return _monName; }
            set { _monName = value; lblMonsterName.Text = value; }
        }   

        [Category("Custom Properties")]
        public string MonsterCR
        {
            get { return _monCR; }
            set { _monCR = value; }
        }

        [Category("Custom Properties")]
        public Image MonsterIcon
        {
            get { return _monIcon; }
            set { _monIcon = value; picMonster.Image = value; }
        }

        public string MonsterIndex
        {
            get { return _monIndex; }
            set { _monIndex = value;}
        }

        public string MonsterURL
        {
            get { return _monURL; }
            set { _monURL = value; }
        }

        public string MonsterType
        {
            get { return _monType; }
            set { _monType = value; lblMonType.Text = value; }
        }

        //Constructor
        public SelectMonsterControl(string name )
        {
            MonsterName = name;
            //MonsterCR = cr;
            //MonsterIcon = pic;
        }

        //Functions
        public void ChangePicture(string type)
        {
            switch (type)
            {
                case "aberration":
                    picMonster.Image = ResourcePics.cthulhu;
                    break;

                case "beast":
                    picMonster.Image = ResourcePics.wolf;
                    break;

                case "celestial":
                    picMonster.Image = ResourcePics.pegasus;
                    break;

                case "construct":
                    picMonster.Image = ResourcePics.golem;
                    break;

                case "dragon":
                    picMonster.Image = ResourcePics.dragon;
                    break;

                case "elemental":
                    picMonster.Image = ResourcePics.elemental;
                    break;

                case "fey":
                    picMonster.Image = ResourcePics.nymph;
                    break;

                case "fiend":
                    picMonster.Image = ResourcePics.demon;
                    break;

                case "giant":
                    picMonster.Image = ResourcePics.ogre;
                    break;

                case "humanoid":
                    picMonster.Image = ResourcePics.ghost;
                    break;

                case "monstrosity":
                    picMonster.Image = ResourcePics.zombie;
                    break;

                case "ooze":
                    picMonster.Image = ResourcePics.slime;
                    break;

                case "plant":
                    picMonster.Image = ResourcePics.plant;
                    break;

                case "undead":
                    picMonster.Image = ResourcePics.zombie;
                    break;
            }
        }



        private void btnMonsterDetails_Click(object sender, EventArgs e)
        {           
            using (WebClient client = new WebClient())
            {
                string url = "https://www.dnd5eapi.co" + this.MonsterURL;
                var json = client.DownloadString(url);
                DetailedMonsterConnection.root Info = JsonConvert.DeserializeObject<DetailedMonsterConnection.root>(json);

                Main_Form.formMonsters.lblNameOutput.Text = Info.name;
                Main_Form.formMonsters.lblSizeOutput.Text = Info.size;
                Main_Form.formMonsters.lblTypeOutput.Text = Info.type;
                Main_Form.formMonsters.lblHPOutput.Text = Info.hit_points.ToString();
                Main_Form.formMonsters.lblCROutput.Text = Info.challenge_rating;
                Main_Form.formMonsters.lblSpeedOutput.Text = Info.speed.walk;
                Main_Form.formMonsters.lblCHA.Text = Info.charisma.ToString();
                Main_Form.formMonsters.lblDEX.Text = Info.dexterity.ToString();
                Main_Form.formMonsters.lblSTR.Text = Info.strength.ToString();
                Main_Form.formMonsters.lblCON.Text = Info.constitution.ToString();
                Main_Form.formMonsters.lblWIS.Text = Info.wisdom.ToString();
                Main_Form.formMonsters.lblINT.Text = Info.intelligence.ToString();

                Main_Form.formMonsters.flowLayoutPaneActions.Controls.Clear();
                
                foreach (var action in Info.actions)
                {
                    
                    ActionControl control = new ActionControl();
                    control.ActionName = action.name;
                    control.ActionDescription = action.desc;
                    if (action.damage == null)
                    {
                        
                    }
                    else
                    {
                        foreach (var damageInfo in action.damage)
                        {
                            control.ActionType = damageInfo.damage_type.name;
                        }
                    }
                    control.ActionHit = action.attack_bonus.ToString();
                    Main_Form.formMonsters.flowLayoutPaneActions.Controls.Add(control);
                    
                }
               
                

                try
                {
                    Main_Form.formMonsters.picMonsterImage.Load("https://www.dnd5eapi.co" + Info.image);
                }
                catch
                {
                    Main_Form.formMonsters.picMonsterImage.Image = null;
                }
            }
        }
    }
}
