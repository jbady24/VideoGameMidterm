using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RougeGame
{
    public partial class Main : UserControl
    {
        public Main()
        {
            InitializeComponent();

            /*Adjusts the background image layout to stretch 
            when the user expands the form*/
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            Hide();
            //CombatScreen combat_Screen = new CombatScreen();
            //combat_Screen.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
