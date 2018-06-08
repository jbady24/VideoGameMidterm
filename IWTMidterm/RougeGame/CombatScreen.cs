using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace RougeGame
{
    public partial class CombatScreen : UserControl
    {
        private GameManager _gm = new GameManager();
        private Random _rand = new Random();
        private RandomItemFactory _randomItem;
        private Image _image;

        public CombatScreen(GameManager gm)
        {
            InitializeComponent();
            _gm = gm;
            displayLevel.Text = "XP";
            _randomItem = new RandomItemFactory();
            depthCounter.Text = Convert.ToString(_gm.Depth);

            torchPictureBox.Image = Properties.Resources.Torch;
            lightCount.Text = "Light " + "" + _gm.light.ToString();

            enemyPictureBox.Image = _gm.Enemy.Image;
            _image = Properties.Resources.Haru;
            
            playerPictureBox.Image = _image;

            xpProgressBar.Minimum = 0;
            xpProgressBar.Maximum = 100;

            enemyProgressBar.Value = _gm.Enemy.CurrentHealth;
            playerProgressBar.Value = _gm.Player.CurrentHealth;

            string playerHpStatus = Convert.ToString(_gm.Player.CurrentHealth);
            string enemyHpStatus = Convert.ToString(_gm.Enemy.CurrentHealth);
            playerHealth.Text = playerHpStatus;
            enemyHealth.Text = enemyHpStatus;

            NextRoomBtn.Visible = false;
            playerName.Text = _gm.Player.Name;
            enemyName.Text = _gm.Enemy.Name;
            enemyAttackValue.Text =  "Attack - " + _gm.Enemy.CalcTotalAttackValue();
            playerAttackValue.Text = "Attack Value - " + _gm.Player.CalcTotalAttackValue();
            playerDefenseValue.Text = "Defense Value - " + _gm.Player.CalcTotalDefenseValue();
            enemyDefenseValue.Text = "Defense Value - " + _gm.Enemy.CalcTotalDefenseValue();

            

            if (_gm.light < 5)
            {
                torchPictureBox.Image = null;
                BackColor = Color.DarkGray;
            }

            xpProgressBar.Value = _gm.XP;
            int levelUpStatus = xpProgressBar.Value;
            xpDisplay.Text = string.Format("{0}/100", levelUpStatus);

            displayLevel.Text = string.Format("Level {0}", _gm.LevelUp);
            


            if (_gm.Depth == 5)
            {
                _gm.EnemyFactory.SpawnMiniBoss();
            }

            if (_gm.Depth == 10)
            {
                
            }

            if (_gm.Depth == 20)
            {
                _gm.EnemyFactory.SpawnBoss();

                if (_gm.Enemy.IsDead)
                {
                    NextRoomBtn.Text = "YOU WIN";
                    var youWinScreen = new YouWin();
                    youWinScreen.Dock = DockStyle.Fill;
                    Controls.Add(youWinScreen);
                }
            }


            if (_gm.YouWin == true)
            {
                var youWinScreen = new YouWin();
                youWinScreen.Dock = DockStyle.Fill;
                Controls.Add(youWinScreen);
            }

            if (_gm.Depth > 5)
            {
                BackColor = Color.Gray;
            }


        }

        private void attackBtn_Click(object sender, EventArgs e)
        {

            _gm.Attack();
            System.IO.Stream str = Properties.Resources.AttackSound;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            enemyProgressBar.Value = _gm.Enemy.CurrentHealth;
            playerProgressBar.Value = _gm.Player.CurrentHealth;

            string playerHpStatus = Convert.ToString(_gm.Player.CurrentHealth);
            string enemyHpStatus = Convert.ToString(_gm.Enemy.CurrentHealth);
            playerHealth.Text = playerHpStatus;
            enemyHealth.Text = enemyHpStatus;
           

            if (_gm.Enemy.IsDead)
            {
                attackBtn.Enabled = false;
                healthPotionBtn.Enabled = false;
                NextRoomBtn.Visible = true;
                enemyProgressBar.Value = 0;
                _gm.Enemy.UnequipAll();

            }
            else if (_gm.Player.IsDead)
            {
                var gameOverScreen = new GameOver();
                gameOverScreen.Dock = DockStyle.Fill;
                Controls.Add(gameOverScreen);
                combatScreenGroupBox.Visible = false;
                NextRoomBtn.Visible = false;
                playerProgressBar.Value = 0;
            }

            
        }

        private void NextRoomBtn_Click(object sender, EventArgs e)
        {
            xpProgressBar.Value += 5;
            var equipmentScreen = new EquipmentScreen(_gm);
            equipmentScreen.Dock = DockStyle.Fill;
            Controls.Add(equipmentScreen);
            combatScreenGroupBox.Visible = false;
            
        }

        private void healthPotionBtn_Click(object sender, EventArgs e)
        {
            if (playerProgressBar.Value == 100)
            {
                healthPotionBtn.Enabled = true;
            }
            else
            {
                playerProgressBar.Value = _gm.IncreasePlayerHealth();
                playerHealth.Text = string.Format("{0}", _gm.IncreasePlayerHealth());
                healthPotionBtn.Enabled = false;
            }

            healthPotionBtn.Enabled = false;
        }
        

        private void QUITBtn_Click_1(object sender, EventArgs e)
        {
            
            ((Form)this.TopLevelControl).Close();
        }
    }
}
