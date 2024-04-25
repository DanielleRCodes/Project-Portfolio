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
    public partial class ActionControl : UserControl
    {
        public ActionControl()
        {
            InitializeComponent();
        }

        //Fields
        private string _actName;
        private string _actDesc;
        private string _actType;
        private string _actHit;
        private string _actDice;

        public string ActionName
        {
            get { return _actName; }
            set { _actName = value; lblName.Text = value; }
        }

        public string ActionDescription
        {
            get { return _actDesc; }
            set { _actDesc = value; tboxActionDesc.Text = value;  }
        }

        public string ActionType
        {
            get { return _actType; }
            set { _actType = value;lblOutputDamType.Text = value; }
        }

        public string ActionHit
        {
            get { return _actHit; }
            set { _actHit = value; lblOutputBonus.Text = value; }
        }

        public string ActionDamageDice
        {
            get { return _actDice; }
            set { _actDice = value; lblOutputDice.Text = value; }
        }
    }
}
