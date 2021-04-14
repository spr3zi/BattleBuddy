using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleBuddy
{
    public partial class Main : Form
    {
        
        #region Load Data
        public Main()
        {
            InitializeComponent();
            
        }
        
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        public static List<Monster> monlist = new List<Monster>();
        public static List<Player> playerlist = new List<Player>();
        public void Main_Load(object sender, EventArgs e)
        {
            //Load monster data from json
            JsonHandler handler = new JsonHandler();
            string import = FormDataSelect.selected[0];
            monlist = handler.ImportMonster(import);

            //Build the monster data grid
            List<string> monName = new List<string>();
            foreach (Creature i in monlist)
            {
                monName.Add(i.name);
            }
            var monListGrid = monlist.Select(x => new
            {
                Name = x.name
            }).ToList();
            dataGridMonsterAdd.DataSource = monListGrid;


            //Load player data from json, puts in the data grid
            playerlist = handler.ImportPlayer("player.json");
            PlayerList();

        }
        #endregion

        //Create lists for active selected data grid
        public static List<string> creatures = new List<string>();
        
    #region buttons
    private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (DBTabControl.SelectedTab == tabPage1)
            {
                var i = dataGridPlayerAdd.CurrentRow.Cells[0].Value;
                var j = Convert.ToString(i);
                creatures.Add(j);
            }
            if (DBTabControl.SelectedTab == tabPage2)
            {
                var i =dataGridMonsterAdd.CurrentRow.Cells[0].Value;
                var j = Convert.ToString(i);
                creatures.Add(j);
            }
            DataRefresh();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (creatures.Count == 0)
            {
                return;
            }
            else
            {
                creatures.Remove((string)dataGridActive.CurrentRow.Cells[0].Value);

                DataRefresh();
            }
            
        }
        #endregion
        
        public void DataRefresh()
        {
            var creatureNames = creatures.Select(s => new { Name = s }).ToList();
            dataGridActive.DataSource = null;
            dataGridActive.DataSource = creatureNames;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Combat combat = new Combat();
            combat.parent = this;
            combat.ShowDialog();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            creatures.Clear();
            DataRefresh();
        }
        public static object viewer = new object();
        private void btnView_Click(object sender, EventArgs e)
        {
            
            if (DBTabControl.SelectedTab == tabPage1)
            {
                var i = dataGridPlayerAdd.CurrentRow.Cells[0].Value;
                var j = GetPlayerByName(i.ToString());
                View.playView = j;
                View.ViewChoice = false;
            }
            if (DBTabControl.SelectedTab == tabPage2)
            {
                var i = dataGridMonsterAdd.CurrentRow.Cells[0].Value.ToString();
                var j  = GetMonsterByName(i);
                View.monView = j;
                View.ViewChoice = true;

            }
            View view = new View();
            view.ShowDialog();
        }
        public Monster GetMonsterByName (string search)
        {
            var mon = monlist.Where(monster => monster.name == search).FirstOrDefault();
            return mon;
        }
        public Player GetPlayerByName (string search)
        {
            var play = playerlist.Where(player => player.name == search).FirstOrDefault();
            return play;
        }

        private void btnCreatePlayer_Click(object sender, EventArgs e)
        {
            AddPlayer addplayer = new AddPlayer();
            addplayer.ShowDialog();
        }

        public void PlayerList()
        {
            List<string> playerName = new List<string>();
            foreach (Creature i in playerlist)
            {
                playerName.Add(i.name);
            }
            var playerNameString = playerName.Select(s => new { Name = s }).ToList();
            dataGridPlayerAdd.DataSource = playerNameString;
        }
    }
}
