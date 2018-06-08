namespace RougeGame
{
    partial class CombatScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.combatScreenGroupBox = new System.Windows.Forms.GroupBox();
            this.torchPictureBox = new System.Windows.Forms.PictureBox();
            this.lightCount = new System.Windows.Forms.Label();
            this.displayLevel = new System.Windows.Forms.Label();
            this.xpDisplay = new System.Windows.Forms.Label();
            this.xpProgressBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.enemyPictureBox = new System.Windows.Forms.PictureBox();
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.depthCounter = new System.Windows.Forms.Label();
            this.enemyDefenseValue = new System.Windows.Forms.Label();
            this.playerDefenseValue = new System.Windows.Forms.Label();
            this.enemyAttackValue = new System.Windows.Forms.Label();
            this.playerAttackValue = new System.Windows.Forms.Label();
            this.NextRoomBtn = new System.Windows.Forms.Button();
            this.enemyProgressBar = new System.Windows.Forms.ProgressBar();
            this.playerProgressBar = new System.Windows.Forms.ProgressBar();
            this.playerHealth = new System.Windows.Forms.Label();
            this.enemyHealth = new System.Windows.Forms.Label();
            this.healthPotionBtn = new System.Windows.Forms.Button();
            this.QUITBtn = new System.Windows.Forms.Button();
            this.attackBtn = new System.Windows.Forms.Button();
            this.playerName = new System.Windows.Forms.Label();
            this.enemyName = new System.Windows.Forms.Label();
            this.combatScreenGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.torchPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // combatScreenGroupBox
            // 
            this.combatScreenGroupBox.Controls.Add(this.torchPictureBox);
            this.combatScreenGroupBox.Controls.Add(this.lightCount);
            this.combatScreenGroupBox.Controls.Add(this.displayLevel);
            this.combatScreenGroupBox.Controls.Add(this.xpDisplay);
            this.combatScreenGroupBox.Controls.Add(this.xpProgressBar);
            this.combatScreenGroupBox.Controls.Add(this.label2);
            this.combatScreenGroupBox.Controls.Add(this.enemyPictureBox);
            this.combatScreenGroupBox.Controls.Add(this.playerPictureBox);
            this.combatScreenGroupBox.Controls.Add(this.depthCounter);
            this.combatScreenGroupBox.Controls.Add(this.enemyDefenseValue);
            this.combatScreenGroupBox.Controls.Add(this.playerDefenseValue);
            this.combatScreenGroupBox.Controls.Add(this.enemyAttackValue);
            this.combatScreenGroupBox.Controls.Add(this.playerAttackValue);
            this.combatScreenGroupBox.Controls.Add(this.NextRoomBtn);
            this.combatScreenGroupBox.Controls.Add(this.enemyProgressBar);
            this.combatScreenGroupBox.Controls.Add(this.playerProgressBar);
            this.combatScreenGroupBox.Controls.Add(this.playerHealth);
            this.combatScreenGroupBox.Controls.Add(this.enemyHealth);
            this.combatScreenGroupBox.Controls.Add(this.healthPotionBtn);
            this.combatScreenGroupBox.Controls.Add(this.QUITBtn);
            this.combatScreenGroupBox.Controls.Add(this.attackBtn);
            this.combatScreenGroupBox.Controls.Add(this.playerName);
            this.combatScreenGroupBox.Controls.Add(this.enemyName);
            this.combatScreenGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combatScreenGroupBox.Location = new System.Drawing.Point(0, 0);
            this.combatScreenGroupBox.Name = "combatScreenGroupBox";
            this.combatScreenGroupBox.Size = new System.Drawing.Size(562, 426);
            this.combatScreenGroupBox.TabIndex = 0;
            this.combatScreenGroupBox.TabStop = false;
            this.combatScreenGroupBox.Text = "groupBox1";
            // 
            // torchPictureBox
            // 
            this.torchPictureBox.Image = global::RougeGame.Properties.Resources.Torch;
            this.torchPictureBox.Location = new System.Drawing.Point(199, 117);
            this.torchPictureBox.Name = "torchPictureBox";
            this.torchPictureBox.Size = new System.Drawing.Size(79, 86);
            this.torchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.torchPictureBox.TabIndex = 50;
            this.torchPictureBox.TabStop = false;
            // 
            // lightCount
            // 
            this.lightCount.AutoSize = true;
            this.lightCount.BackColor = System.Drawing.Color.Transparent;
            this.lightCount.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lightCount.Location = new System.Drawing.Point(195, 93);
            this.lightCount.Name = "lightCount";
            this.lightCount.Size = new System.Drawing.Size(83, 21);
            this.lightCount.TabIndex = 49;
            this.lightCount.Text = "Light Count";
            // 
            // displayLevel
            // 
            this.displayLevel.AutoSize = true;
            this.displayLevel.BackColor = System.Drawing.Color.Transparent;
            this.displayLevel.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLevel.Location = new System.Drawing.Point(329, 19);
            this.displayLevel.Name = "displayLevel";
            this.displayLevel.Size = new System.Drawing.Size(40, 21);
            this.displayLevel.TabIndex = 48;
            this.displayLevel.Text = "Level";
            // 
            // xpDisplay
            // 
            this.xpDisplay.AutoSize = true;
            this.xpDisplay.BackColor = System.Drawing.Color.Transparent;
            this.xpDisplay.Font = new System.Drawing.Font("Pristina", 9.75F, System.Drawing.FontStyle.Bold);
            this.xpDisplay.Location = new System.Drawing.Point(107, 19);
            this.xpDisplay.Name = "xpDisplay";
            this.xpDisplay.Size = new System.Drawing.Size(25, 18);
            this.xpDisplay.TabIndex = 47;
            this.xpDisplay.Text = "XP";
            // 
            // xpProgressBar
            // 
            this.xpProgressBar.Location = new System.Drawing.Point(138, 19);
            this.xpProgressBar.Name = "xpProgressBar";
            this.xpProgressBar.Size = new System.Drawing.Size(184, 18);
            this.xpProgressBar.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Pristina", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(184, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "DEPTH";
            // 
            // enemyPictureBox
            // 
            this.enemyPictureBox.Location = new System.Drawing.Point(303, 93);
            this.enemyPictureBox.Name = "enemyPictureBox";
            this.enemyPictureBox.Size = new System.Drawing.Size(118, 68);
            this.enemyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyPictureBox.TabIndex = 44;
            this.enemyPictureBox.TabStop = false;
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.Location = new System.Drawing.Point(67, 93);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(118, 68);
            this.playerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPictureBox.TabIndex = 43;
            this.playerPictureBox.TabStop = false;
            // 
            // depthCounter
            // 
            this.depthCounter.AutoSize = true;
            this.depthCounter.BackColor = System.Drawing.Color.Transparent;
            this.depthCounter.Font = new System.Drawing.Font("Pristina", 9.75F, System.Drawing.FontStyle.Bold);
            this.depthCounter.Location = new System.Drawing.Point(243, 320);
            this.depthCounter.Name = "depthCounter";
            this.depthCounter.Size = new System.Drawing.Size(46, 18);
            this.depthCounter.TabIndex = 42;
            this.depthCounter.Text = "Counter";
            // 
            // enemyDefenseValue
            // 
            this.enemyDefenseValue.AutoSize = true;
            this.enemyDefenseValue.BackColor = System.Drawing.Color.Transparent;
            this.enemyDefenseValue.Font = new System.Drawing.Font("Pristina", 9.75F, System.Drawing.FontStyle.Bold);
            this.enemyDefenseValue.Location = new System.Drawing.Point(300, 182);
            this.enemyDefenseValue.Name = "enemyDefenseValue";
            this.enemyDefenseValue.Size = new System.Drawing.Size(101, 18);
            this.enemyDefenseValue.TabIndex = 41;
            this.enemyDefenseValue.Text = "enemyDefenseValue";
            // 
            // playerDefenseValue
            // 
            this.playerDefenseValue.AutoSize = true;
            this.playerDefenseValue.BackColor = System.Drawing.Color.Transparent;
            this.playerDefenseValue.Font = new System.Drawing.Font("Pristina", 9.75F, System.Drawing.FontStyle.Bold);
            this.playerDefenseValue.Location = new System.Drawing.Point(82, 185);
            this.playerDefenseValue.Name = "playerDefenseValue";
            this.playerDefenseValue.Size = new System.Drawing.Size(103, 18);
            this.playerDefenseValue.TabIndex = 40;
            this.playerDefenseValue.Text = "playerDefenseValue";
            // 
            // enemyAttackValue
            // 
            this.enemyAttackValue.AutoSize = true;
            this.enemyAttackValue.BackColor = System.Drawing.Color.Transparent;
            this.enemyAttackValue.Font = new System.Drawing.Font("Pristina", 9.75F, System.Drawing.FontStyle.Bold);
            this.enemyAttackValue.Location = new System.Drawing.Point(300, 164);
            this.enemyAttackValue.Name = "enemyAttackValue";
            this.enemyAttackValue.Size = new System.Drawing.Size(99, 18);
            this.enemyAttackValue.TabIndex = 39;
            this.enemyAttackValue.Text = "enemyAttackValue";
            // 
            // playerAttackValue
            // 
            this.playerAttackValue.AutoSize = true;
            this.playerAttackValue.BackColor = System.Drawing.Color.Transparent;
            this.playerAttackValue.Font = new System.Drawing.Font("Pristina", 9.75F, System.Drawing.FontStyle.Bold);
            this.playerAttackValue.Location = new System.Drawing.Point(82, 164);
            this.playerAttackValue.Name = "playerAttackValue";
            this.playerAttackValue.Size = new System.Drawing.Size(101, 18);
            this.playerAttackValue.TabIndex = 38;
            this.playerAttackValue.Text = "playerAttackValue";
            // 
            // NextRoomBtn
            // 
            this.NextRoomBtn.BackColor = System.Drawing.Color.Firebrick;
            this.NextRoomBtn.Font = new System.Drawing.Font("Pristina", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextRoomBtn.Location = new System.Drawing.Point(299, 306);
            this.NextRoomBtn.Name = "NextRoomBtn";
            this.NextRoomBtn.Size = new System.Drawing.Size(102, 32);
            this.NextRoomBtn.TabIndex = 36;
            this.NextRoomBtn.Text = "NEXT ROOM";
            this.NextRoomBtn.UseVisualStyleBackColor = false;
            this.NextRoomBtn.Click += new System.EventHandler(this.NextRoomBtn_Click);
            // 
            // enemyProgressBar
            // 
            this.enemyProgressBar.Location = new System.Drawing.Point(272, 231);
            this.enemyProgressBar.Name = "enemyProgressBar";
            this.enemyProgressBar.Size = new System.Drawing.Size(127, 23);
            this.enemyProgressBar.TabIndex = 34;
            // 
            // playerProgressBar
            // 
            this.playerProgressBar.Location = new System.Drawing.Point(85, 231);
            this.playerProgressBar.Name = "playerProgressBar";
            this.playerProgressBar.Size = new System.Drawing.Size(118, 23);
            this.playerProgressBar.TabIndex = 33;
            // 
            // playerHealth
            // 
            this.playerHealth.AutoSize = true;
            this.playerHealth.BackColor = System.Drawing.Color.Transparent;
            this.playerHealth.Font = new System.Drawing.Font("Pristina", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHealth.Location = new System.Drawing.Point(82, 210);
            this.playerHealth.Name = "playerHealth";
            this.playerHealth.Size = new System.Drawing.Size(72, 18);
            this.playerHealth.TabIndex = 31;
            this.playerHealth.Text = "playerHealth";
            // 
            // enemyHealth
            // 
            this.enemyHealth.AutoSize = true;
            this.enemyHealth.BackColor = System.Drawing.Color.Transparent;
            this.enemyHealth.Font = new System.Drawing.Font("Pristina", 9.75F, System.Drawing.FontStyle.Bold);
            this.enemyHealth.Location = new System.Drawing.Point(329, 210);
            this.enemyHealth.Name = "enemyHealth";
            this.enemyHealth.Size = new System.Drawing.Size(70, 18);
            this.enemyHealth.TabIndex = 30;
            this.enemyHealth.Text = "enemyHealth";
            // 
            // healthPotionBtn
            // 
            this.healthPotionBtn.BackColor = System.Drawing.Color.Firebrick;
            this.healthPotionBtn.Font = new System.Drawing.Font("Pristina", 9.75F, System.Drawing.FontStyle.Bold);
            this.healthPotionBtn.Location = new System.Drawing.Point(272, 271);
            this.healthPotionBtn.Name = "healthPotionBtn";
            this.healthPotionBtn.Size = new System.Drawing.Size(95, 27);
            this.healthPotionBtn.TabIndex = 28;
            this.healthPotionBtn.Text = "POTION 1";
            this.healthPotionBtn.UseVisualStyleBackColor = false;
            this.healthPotionBtn.Click += new System.EventHandler(this.healthPotionBtn_Click);
            // 
            // QUITBtn
            // 
            this.QUITBtn.BackColor = System.Drawing.Color.Firebrick;
            this.QUITBtn.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QUITBtn.Location = new System.Drawing.Point(83, 306);
            this.QUITBtn.Name = "QUITBtn";
            this.QUITBtn.Size = new System.Drawing.Size(95, 33);
            this.QUITBtn.TabIndex = 27;
            this.QUITBtn.Text = "QUIT";
            this.QUITBtn.UseVisualStyleBackColor = false;
            this.QUITBtn.Click += new System.EventHandler(this.QUITBtn_Click_1);
            // 
            // attackBtn
            // 
            this.attackBtn.BackColor = System.Drawing.Color.Firebrick;
            this.attackBtn.Font = new System.Drawing.Font("Pristina", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackBtn.Location = new System.Drawing.Point(110, 271);
            this.attackBtn.Name = "attackBtn";
            this.attackBtn.Size = new System.Drawing.Size(93, 27);
            this.attackBtn.TabIndex = 26;
            this.attackBtn.Text = "ATTACK";
            this.attackBtn.UseVisualStyleBackColor = false;
            this.attackBtn.Click += new System.EventHandler(this.attackBtn_Click);
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.BackColor = System.Drawing.Color.Transparent;
            this.playerName.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName.Location = new System.Drawing.Point(114, 63);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(89, 27);
            this.playerName.TabIndex = 25;
            this.playerName.Text = "PLAYER";
            // 
            // enemyName
            // 
            this.enemyName.AutoSize = true;
            this.enemyName.BackColor = System.Drawing.Color.Transparent;
            this.enemyName.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Bold);
            this.enemyName.Location = new System.Drawing.Point(276, 63);
            this.enemyName.Name = "enemyName";
            this.enemyName.Size = new System.Drawing.Size(83, 27);
            this.enemyName.TabIndex = 24;
            this.enemyName.Text = "ENEMY";
            // 
            // CombatScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.combatScreenGroupBox);
            this.Name = "CombatScreen";
            this.Size = new System.Drawing.Size(562, 426);
            this.combatScreenGroupBox.ResumeLayout(false);
            this.combatScreenGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.torchPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox combatScreenGroupBox;
        private System.Windows.Forms.Button NextRoomBtn;
        private System.Windows.Forms.ProgressBar enemyProgressBar;
        private System.Windows.Forms.ProgressBar playerProgressBar;
        private System.Windows.Forms.Label playerHealth;
        private System.Windows.Forms.Label enemyHealth;
        private System.Windows.Forms.Button healthPotionBtn;
        private System.Windows.Forms.Button QUITBtn;
        private System.Windows.Forms.Button attackBtn;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.Label enemyName;
        private System.Windows.Forms.Label enemyAttackValue;
        private System.Windows.Forms.Label playerAttackValue;
        private System.Windows.Forms.Label enemyDefenseValue;
        private System.Windows.Forms.Label playerDefenseValue;
        private System.Windows.Forms.Label depthCounter;
        private System.Windows.Forms.PictureBox enemyPictureBox;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar xpProgressBar;
        private System.Windows.Forms.Label displayLevel;
        private System.Windows.Forms.Label xpDisplay;
        private System.Windows.Forms.Label lightCount;
        private System.Windows.Forms.PictureBox torchPictureBox;
    }
}
