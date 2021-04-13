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
    public partial class FormDataSelect : Form
    {
        public FormDataSelect()
        {
            InitializeComponent();
        }
        public static List<string> selected = new List<string>();
        private void btnStart_Click(object sender, EventArgs e)
        {
            

            if (checkBoxMM.Checked)
            {

                selected.Add("mm.json");
            }
            if (checkBoxHomebrew.Checked)
            {
                //selected.Add("homebrew.json");
            }
            this.Hide();
            Main main = new Main();
            main.ShowDialog();


        }

        private void FormDataSelect_Load(object sender, EventArgs e)
        {

        }
    }
}
