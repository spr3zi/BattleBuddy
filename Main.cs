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
            //var monNameString = monlist.Select(s => new { Name= s }).ToList();
            //dataGridMonsterAdd.DataSource = monNameString;
            //dataGridMonsterAdd.DataSource = monlist.Select(o => new MyViewModel()
            //{
            //    Name = o.name
            //});
            dataGridMonsterAdd.DataSource = monListGrid;


            //Load player data from json
            playerlist = handler.ImportPlayer("player.json");

            //Builds the player data grid
            List<string> playerName = new List<string>();
            foreach (Creature i in playerlist)
            {
                playerName.Add(i.name);
            }
            var playerNameString = playerName.Select(s => new { Name = s }).ToList();
            dataGridPlayerAdd.DataSource = playerNameString;

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
            
            
            DataRefresh();
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
            combat.ShowDialog();
        }

        class MyViewModel
        {
            public string Name { get; set; }
        }
    }
}
