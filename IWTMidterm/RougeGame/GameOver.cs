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
    public partial class GameOver : UserControl
    {
        //private GameManager _gm = new GameManager();
        public GameOver()
        {
            InitializeComponent();
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            //var combatScreen = new MainMenu();
            //combatScreen.Dock = DockStyle.Fill;
            //Controls.Add(combatScreen);
            //((Form)this.TopLevelControl).Close();

        }
    }
}
