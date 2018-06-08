using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RougeGame
{
    public partial class MainMenu : Form
    {
        private GameManager _gm;

        public MainMenu()
        {
            InitializeComponent();
            _gm = new GameManager();
            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            //this.BeginInvoke(new MethodInvoker(this.Close));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Dock = DockStyle.Fill;
            mainMenu.Close();
        }

        private void playBtn_Click_1(object sender, EventArgs e)
        {
            var infoScreen = new InformationScreen(_gm);
            infoScreen.Dock = DockStyle.Fill;
            Controls.Add(infoScreen);

            mainMenuGroupBox.Visible = false;
        }
    }
}
