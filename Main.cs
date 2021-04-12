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
        
        private void Main_Load(object sender, EventArgs e)
        {
            //Load monster data from json
            JsonHandler handler = new JsonHandler();
            string import = FormDataSelect.selected[0];
            List<Monster> monlist = handler.ImportMonster(import);

            //Build the monster data grid
            List<string> monName = new List<string>();
            foreach (Creature i in monlist)
            {
                monName.Add(i.name);
            }
            var monNameString = monName.Select(s => new { Name = s }).ToList();
            dataGridMonsterAdd.DataSource = monNameString;


            //Load player data from json
            List<Player> playerlist = handler.ImportPlayer("player.json");

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
        protected List<string> selectedNameStrings = new List<string>();
        protected List<Object> creatures = new List<object>();
        

    #region buttons
    private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (DBTabControl.SelectedTab == tabPage1)
            {
                creatures.Add(dataGridPlayerAdd.CurrentRow.Cells[0].Value);
                DataRefresh();
            }
            if (DBTabControl.SelectedTab == tabPage2)
            {
                creatures.Add(dataGridMonsterAdd.CurrentRow.Cells[0].Value);
                
                DataRefresh();
            }
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

        }
    }
}
