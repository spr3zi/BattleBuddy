using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JsonHandler;

namespace BattleBuddy
{
    public partial class FormDataSelect : Form
    {
        public FormDataSelect()
        {
            InitializeComponent();
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Handler bestiary = new Handler();
            if (checkBoxMM.Checked)
            {
                
                bestiary.ImportJson("mm");
            }
            Form main = new Main();
            this.Hide();
            main.ShowDialog();
            
        }
    }
}
