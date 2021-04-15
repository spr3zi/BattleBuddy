using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Text.RegularExpressions;

namespace BattleBuddy
{
    public partial class Combat : Form
    {
        public Combat()
        {
            InitializeComponent();
        }
        List<string> creatures = Main.creatures;
        List<Monster> monlist = Main.monlist;
        List<Player> playerlist = Main.playerlist;
        
        private void Combat_Load(object sender, EventArgs e)
        {
            LoadCreatures(creatures);
            InitializeTurnOrder();
            lblTurnOrder.Text = sortedNames[0];
        }
        protected List<Combatants> combatants = new List<Combatants>();
        protected void LoadCreatures(List<string> list)
        {
            
            foreach (string i in list)
            {
                if (monlist.Any(p => p.name == i))
                {
                    var select = monlist.Where(j => j.name == i).FirstOrDefault();
                    string ACString = select.ac[0].ToString();
                    string match = Regex.Match(ACString, @"\d+").Value;

                    Combatants comb = new Combatants();
                    comb.Name = select.name;
                    comb.AC = Int32.Parse(match);
                    comb.maxHealth = select.hp.average;
                    comb.currentHealth = select.hp.average;
                    comb.DexMod = (select.dex - 10) % 2;
                    comb.Initiative = InitiativeRoll(comb.DexMod);

                    combatants.Add(comb);
                    
                }
                if (playerlist.Any(p => p.name == i))
                {
                    var select = playerlist.Where(j => j.name == i).FirstOrDefault();

                    Combatants comb = new Combatants();
                    int ac2 = select.ac;
                    comb.Name = select.name;
                    comb.AC = select.ac;
                    comb.maxHealth = select.hp;
                    comb.currentHealth = select.hp;
                    comb.DexMod = (select.dex - 10) % 2;
                    comb.Initiative = InitiativeRoll(comb.DexMod);

                    combatants.Add(comb);

                }
                DataRefresh();

            }
        }

        protected int InitiativeRoll(int dex)
        {
            Random rnd = new Random();
            int result = dex + (rnd.Next(1, 21));
            return result;
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBoxHealth.Text))
            {
                int heal = Int32.Parse(txtBoxHealth.Text);
                Combatants target = (Combatants)dataGridCombat.CurrentRow.DataBoundItem;
                if ((target.currentHealth + heal) >= target.maxHealth)
                {
                    target.currentHealth = target.maxHealth;
                    DataRefresh();
                }
                else
                {
                    target.currentHealth += heal;
                }
                DataRefresh();
            }
        }

        private void btnDamage_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBoxHealth.Text)){
                int dmg = Int32.Parse(txtBoxHealth.Text);
                Combatants target = (Combatants)dataGridCombat.CurrentRow.DataBoundItem;
                if ((target.currentHealth - dmg >= 0))
                {
                    target.currentHealth -= dmg;
                    DataRefresh();
                }
                else
                {
                    target.currentHealth = 0;
                    DataRefresh();
                }
            }
            
        }
        protected void DataRefresh()
        {
            List<Combatants> sorted = combatants.OrderByDescending(o => o.Initiative).ToList();
            dataGridCombat.DataSource = sorted;
            txtBoxHealth.Clear();
            dataGridCombat.Columns[2].HeaderText = "Health";
            dataGridCombat.Columns[3].HeaderText = "Max Health";
            dataGridCombat.Columns[dataGridCombat.Columns.Count-1].Visible = false;
        }

        List<string> sortedNames = new List<string>();
        protected void InitializeTurnOrder() 
        {

            List<Combatants> sorted = combatants.OrderByDescending(o => o.Initiative).ToList();
            foreach(Combatants i in sorted)
            {
                sortedNames.Add(i.Name);
            }

        }
        int index = 0;
        int roundCount = 1;
        
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (index < sortedNames.Count)
            {
                index++;
                
            }   
            if (index == sortedNames.Count)
            {
                index = 0;
                roundCount++;
            }
            lblTurnOrder.Text = sortedNames[index];
            lblRoundCount.Text = roundCount.ToString();
            dataGridCombat.CurrentCell = dataGridCombat.Rows[index].Cells[0];
        }

        public Main parent;
        private void btnEndFight_Click(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }
    }

    public class Combatants
    {
        public string  Name { get; set; }
        public int AC { get; set; }
        public int currentHealth { get; set; }
        public int maxHealth { get; set; }
        public int Initiative { get; set; }
        public int DexMod { get; set; }
    }
}
