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
using System.IO;
using System.Threading.Tasks;

namespace BattleBuddy
{
    public partial class AddPlayer : Form
    {
        public AddPlayer()
        {
            InitializeComponent();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
            MessageBox.Show("Successfully added!");
            ClearTextBoxes();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            this.Close();
        }

        protected void Add()
        {
            
            Player player = new Player();
            player.name = textBoxName.Text;
            player.race = textBoxRace.Text;
            player.@class = textBoxClass.Text;
            player.hp = Int32.Parse(textBoxHP.Text);
            player.ac = Int32.Parse(textBoxAC.Text);
            player.speed = Int32.Parse(textBoxSpeed.Text);
            player.str =  Int32.Parse(textBoxStr.Text);
            player.dex = Int32.Parse(textBoxDex.Text);
            player.@int = Int32.Parse(textBoxInt.Text);
            player.wis = Int32.Parse(textBoxWis.Text);
            player.con = Int32.Parse(textBoxCon.Text);

            AddToFile(player);

            

        }

        private void AddToFile(Player player)
        {
            List<Player> playerlist = Main.playerlist;
            playerlist.Add(player);

            string file = "test.json";
            string path = Path.Combine(Environment.CurrentDirectory, @"json\", file);

            File.WriteAllText(path, JsonConvert.SerializeObject(playerlist));
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
    }
}
