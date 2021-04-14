using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Reflection;

namespace BattleBuddy
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }
        public static Monster monView = new Monster();
        public static Player playView = new Player();
        public static bool ViewChoice;
        private void View_Load(object sender, EventArgs e)
        {
            if (ViewChoice == true)
            {
                MonViewer();
            }
            else
            {
                PlayerViewer();
            }
        }
        public void PlayerViewer()
        { 
            txtViewer.Text = playView.name + Environment.NewLine + playView.race + " " + playView.@class + Environment.NewLine + "Strength: " + playView.str + 
                "   Dexterity: " + playView.dex + "   Constitution: " + playView.con + "   Intelligence: " + playView.@int + "   Wisdom: " + playView.wis + 
                "   Charisma: " + +playView.cha + Environment.NewLine + "Armor Class: " + playView.ac + "   Health: " + playView.hp;
        }
        public void MonViewer()
        {
            string ACString = monView.ac[0].ToString();
            string match = Regex.Match(ACString, @"\d+").Value;
            txtViewer.Text = monView.name + Environment.NewLine + "Challenge Rating: " + monView.cr.ToString() +  Environment.NewLine + "Strength: " + monView.str +
                "   Dexterity: " + monView.dex + "   Constitution: " + monView.con + "   Intelligence: " + monView.@int + "   Wisdom: " + monView.wis +
                "   Charisma: " + monView.cha + Environment.NewLine + "Armor Class: " + match + Environment.NewLine + "Health: " + monView.hp.average + Environment.NewLine
                + "Size: " + monView.size;      
        }
    }


}
