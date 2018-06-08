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
    public partial class InformationScreen : UserControl
    {
        private GameManager _gm;

        public InformationScreen(GameManager gm)
        {
            InitializeComponent();
            _gm = gm;
            infoLabel.Text = string.Format(
                "You play as Haru, a noble shinobi on \n" +
                "the run trying to retrieve his pride that was stolen by Hazuki the \n" +
                "Saint Warlord. You must face the deadly monsters that await in \n" +
                "Hazuki's dungeon in order to get back what \n" +
                "was stolen from you. BEGIN YOUR ADVENTURE");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var invScreen = new EquipmentScreen(_gm);
            invScreen.Dock = DockStyle.Fill;
            Controls.Add(invScreen);

            infoGroupBox.Visible = false;
        }
    }
}
